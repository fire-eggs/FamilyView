using System;
using System.Drawing;
using System.Windows.Forms;
using GEDWrap;

namespace FamilyView
{
    public partial class View4a : ViewBase
    {
        private bool _editMode = false;

        public View4a(DataSet baseData) : base(baseData)
        {
            InitializeComponent();

            _marr = Marr;

            // 'goto' button in column 0 of grid
            var dgvbc = (childGrid.Columns[0] as DataGridViewButtonColumn);
            dgvbc.Text = "t";
            dgvbc.UseColumnTextForButtonValue = false;
            dgvbc.Resizable = DataGridViewTriState.False;
            dgvbc.ToolTipText = "Make this child the primary";

            // 'goto' button in column 5 of grid
            dgvbc = (childGrid.Columns[5] as DataGridViewButtonColumn);
            dgvbc.Text = "t";
            dgvbc.UseColumnTextForButtonValue = true;
            dgvbc.Resizable = DataGridViewTriState.False;
            dgvbc.ToolTipText = "Make this child's spouse the primary";
            
            childGrid.CellClick += ChildGridCellClick;
            childGrid.CellDoubleClick += ChildGridCellDoubleClick;
            SetContents();
        }

        void ChildGridCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 5)
                return;

            var dex = e.RowIndex;
            if (dex < 0)
                return;
            if (dex >= _dataset.children.Count)
            {
                addChild();
                return;
            }

            var who = _dataset.children[dex].primary;
            if (e.ColumnIndex == 4 && _dataset.children[dex].spouse.HasValue)
                who = _dataset.children[dex].spouse.Value;
            MessageBox.Show(who.Fullname, "Editing person");
        }

        void ChildGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var dex = e.RowIndex;
                if (dex < 0)
                    return;
                if (dex >= _dataset.children.Count)
                    addChild();
                else
                    changePerson(_dataset.children[dex].primary.who);
            }
            if (e.ColumnIndex == 5)
            {
                var dex = e.RowIndex;
                if (dex < 0)
                    return;
                changePerson(_dataset.children[dex].spouse.Value.who);
            }
        }

        protected override void SetContents()
        {
            tboxPDad2.Who = _dataset.pDad;
            tboxPMom.Who = _dataset.pMom;
            tboxSDad.Who = _dataset.sDad;
            tboxSMom.Who = _dataset.sMom;

            _marr.Text = _dataset.marriage;

            splitButton1.Visible = _dataset.primary.HasMMarr;
            splitButton1.Menu = null;
            if (_dataset.primary.HasMMarr)
            {
                ContextMenuStrip cms = new ContextMenuStrip();
                foreach (var un in _dataset.primary.who.SpouseIn)
                {
                    var sp = un.Spouse(_dataset.primary.who);
                    ToolStripMenuItem tsi = new ToolStripMenuItem(sp.Name);
                    tsi.Click += OthSpClick;
                    tsi.Tag = sp;
                    cms.Items.Add(tsi);
                }
                splitButton1.Menu = cms;
                splitButton1.DropDownOnly = true;
            }

            splitButton2.Visible = _dataset.spouse.HasValue && _dataset.spouse.Value.HasMMarr;
            splitButton2.Menu = null;
            if (_dataset.spouse.HasValue && _dataset.spouse.Value.HasMMarr)
            {
                ContextMenuStrip cms = new ContextMenuStrip();
                foreach (var un in _dataset.spouse.Value.who.SpouseIn)
                {
                    var sp = un.Spouse(_dataset.spouse.Value.who);
                    ToolStripMenuItem tsi = new ToolStripMenuItem(sp.Name);
                    tsi.Click += OthSpClick; // TODO does this need to be distinct vs primary?
                    tsi.Tag = sp;
                    cms.Items.Add(tsi);
                }
                splitButton2.Menu = cms;
                splitButton2.DropDownOnly = true;
            }

            Primary.Text = buildLines(_dataset.primary);
            Primary.Who = _dataset.primary;
            Primary.HasNotes = _dataset.primary.who.Indi.Notes.Count > 0; // TODO better accessor!
            Primary.HasMedia = _dataset.primary.who.Indi.Media.Count > 0; // TODO better accessor!
            Primary.HasSours = _dataset.primary.who.Indi.Cits.Count > 0; // TODO better accessor!

            Primary.HasNotes = Primary.HasMedia = Primary.HasSours = true;

            doSpouse(_dataset.spouse);

            childGrid.Rows.Clear();
            if (_dataset.children != null)
            {
                int i = 0;
                foreach (var childDS in _dataset.children)
                {
                    var child = childDS.primary;

                    childGrid.Rows.Add(new object[] { "t", child.Fullname, child.BirthYear, child.DeathYear, null, null});

                    string spouse = "";
                    if (childDS.spouse.HasValue)
                    {
                        spouse = childDS.spouse.Value.Fullname;
                    }
                    else
                    {
                        spouse = "";
                        childGrid.Rows[i].Cells[5].Style = _hideBtn;
                        childGrid.Rows[i].Cells[5].ToolTipText = "";
                    }
                    childGrid.Rows[i].Cells[4].Value = spouse;

                    childGrid.Rows[i].Height = 25;
                    childGrid.Rows[i].Cells[2].ToolTipText = child.Birth;
                    childGrid.Rows[i].Cells[3].ToolTipText = child.Death;

                    childGrid.Rows[i].Cells[6].Value = child.HasMMarr;
                    i++;
                }

                // Provide an 'add' button
                childGrid.Rows.Add(new object[] { "É", "Add a new child", "", "", "" });
                childGrid.Rows[i].Height = 25;
                //childGrid.Rows[i].Cells[0].Style = _hideBtn;
                //childGrid.Rows[i].Cells[0].ToolTipText = "";
                childGrid.Rows[i].Cells[0].Style = _addBtn;
                _addBtn.Font = _addFont;
                childGrid.Rows[i].Cells[1].Style = _addChld;
                childGrid.Rows[i].Cells[5].Style = _hideBtn;
                childGrid.Rows[i].Cells[5].ToolTipText = "";
                childGrid.Rows[i].Cells[6].Style = _hideBtn;
                childGrid.Rows[i].Cells[6].ToolTipText = "";

            }
        }

        private void personEvent(object sender, EventArgs e)
        {
            // User has initiated an event on a parent box

            var pea = e as PersonArgs;
            if (pea == null)
                return;
            switch (pea.Which)
            {
                case ParentTBox2.EventType.Add:
                    MessageBox.Show(this, "Add key " + pea.Key + " For " + _dataset.primary.Fullname, "Add person");
                    break;
                case ParentTBox2.EventType.Go:
                    changePerson(pea.Who.Value.who);
                    break;
                case ParentTBox2.EventType.Edit:
                    MessageBox.Show(this, "Edit " + pea.Who.Value.Fullname, "Edit person");
                    break;
            }
        }

        private void OthSpClick(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            var who = tsmi.Tag as Person;
            changePerson(who);
            
            //changeVisibleSpouse(who); // TODO won't work unless have alternate spouse data as well
            // TODO should this *not* change the primary? (i.e. change the spouse and children and spouse's parents...)
        }

        private void doSpouse(PData? spouse)
        {
            Spouse.Who = spouse;
            Spouse.Text = buildLines(spouse);
            if (spouse.HasValue)
            {
                Spouse.HasNotes = spouse.Value.who.Indi.Notes.Count > 0; // TODO better accessor!
                Spouse.HasMedia = spouse.Value.who.Indi.Media.Count > 0; // TODO better accessor!
                Spouse.HasSours = spouse.Value.who.Indi.Cits.Count > 0; // TODO better accessor!

                Spouse.HasNotes = Spouse.HasMedia = Spouse.HasSours = true; // TODO debugging
            }
            else
            {
                Spouse.HasNotes = Spouse.HasMedia = Spouse.HasSours = false;
            }
        }

        // A style used to hide the "goto" button in the datagridview
        private DataGridViewCellStyle _hideBtn = new DataGridViewCellStyle() {Padding = new Padding(100,0,0,0)};
        private DataGridViewCellStyle _addChld = new DataGridViewCellStyle() { ForeColor = Color.DarkGray};
        private Font _addFont = new Font("Wingdings 2", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));

        private DataGridViewCellStyle _addBtn = new DataGridViewCellStyle();

        public override void CoordinateSelection(object sender)
        {
            TBox selected = sender as TBox;
            if (selected == null || selected.Selected)
                return;

            if (_primary != null)
                _primary.Selected = false;
            if (_spouse != null)
                _spouse.Selected = false;
            if (_dad != null)
                _dad.Selected = false;
            if (_mom != null)
                _mom.Selected = false;

            selected.Selected = true;
        }

        private void addChild()
        {
            MessageBox.Show("For " + _dataset.primary.Fullname, "Add new child");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _editMode = !_editMode;
            button1.Text = _editMode ? "Done edit" : "Edit";
            tboxPDad2.IsEdit = _editMode; // TODO have control subscribe to button?
            tboxPMom.IsEdit = _editMode;
            tboxSDad.IsEdit = _editMode;
            tboxSMom.IsEdit = _editMode;
        }
    }
}
