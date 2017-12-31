using System;
using System.Drawing;
using System.Windows.Forms;

// TODO winforms dropdown-button for 'other marriages'
// TODO MVC variant
// TODO how to make 'add new' functionality more obvious ['Add' btn in grid;'Add' btn in PersonDataBox?;parents?]

namespace FamilyView
{
    public partial class View4 : ViewBase
    {
        private View4()
        {
            InitializeComponent();
        }

        public View4(DataSet baseData) : base(baseData)
        {
            InitializeComponent();

            _marr = Marr;
            _dad = Dad;
            _mom = Mom;
            _goDad = goDad;
            _goMom = goMom;

            Dad.Owner = Mom.Owner = sDad.Owner = sMom.Owner = Primary.Owner = Spouse.Owner = this;

            Dad.Multiline = false;
            Mom.Multiline = false;
            sDad.Multiline = false;
            sMom.Multiline = false;

            // 'goto' button in column 0 of grid
            var dgvbc = (childGrid.Columns[0] as DataGridViewButtonColumn);
            dgvbc.Text = "t";
            dgvbc.UseColumnTextForButtonValue = true;
            dgvbc.Resizable = DataGridViewTriState.False;
            dgvbc.ToolTipText = "Make this child the primary";
            
            childGrid.CellClick += ChildGridCellClick;
            childGrid.CellDoubleClick += ChildGridCellDoubleClick;
            SetContents();
        }

        void ChildGridCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0)
            {
                var dex = e.RowIndex;
                if (dex < 0)
                    return;
                if (dex >= _dataset.children.Count)
                {
                    MessageBox.Show("Add new child", "Add new child");
                }
                else
                {
                    var Who = _dataset.children[dex];
                    MessageBox.Show(Who.Fullname, "Editing person");
                }
            }
        }

        void ChildGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var dex = e.RowIndex;
                if (dex < 0)
                    return;
                changePerson(_dataset.children[dex].who);
            }
        }

        private void goDad_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.pDad.who);
        }

        private void goMom_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.pMom.who);
        }

        protected override void SetContents()
        {
            _dad.Text = oneLine(_dataset.pDad);
            _mom.Text = oneLine(_dataset.pMom);

            sDad.Text = oneLine(_dataset.sDad);
            sMom.Text = oneLine(_dataset.sMom);

            sDad.Who = _dataset.sDad;
            sMom.Who = _dataset.sMom;

            btnMarriages.Visible = _dataset.primary.HasMMarr;
            btnSMarriages.Visible = _dataset.spouse.HasValue && _dataset.spouse.Value.HasMMarr;
            _marr.Text = _dataset.marriage;

            _goDad.Visible = _dataset.pDad.who != null;
            _goMom.Visible = _dataset.pMom.who != null;
            goSDad.Visible = _dataset.sDad.who != null;
            goSMom.Visible = _dataset.sMom.who != null;

            Primary.Text = buildLines(_dataset.primary);
            Primary.Who = _dataset.primary;
            Primary.HasNotes = _dataset.primary.who.Indi.Notes.Count > 0; // TODO better accessor!
            Primary.HasMedia = _dataset.primary.who.Indi.Media.Count > 0; // TODO better accessor!
            Primary.HasSours = _dataset.primary.who.Indi.Cits.Count > 0; // TODO better accessor!

            Spouse.Who = _dataset.spouse;
            Spouse.Text = buildLines(_dataset.spouse);
            if (_dataset.spouse.HasValue)
            {
                Spouse.HasNotes = _dataset.spouse.Value.who.Indi.Notes.Count > 0; // TODO better accessor!
                Spouse.HasMedia = _dataset.spouse.Value.who.Indi.Media.Count > 0; // TODO better accessor!
                Spouse.HasSours = _dataset.spouse.Value.who.Indi.Cits.Count > 0; // TODO better accessor!
            }
            else
            {
                Spouse.HasNotes = Spouse.HasMedia = Spouse.HasSours = false;
            }

            childGrid.Rows.Clear();
            if (_dataset.children != null)
            {
                int i = 0;
                foreach (var child in _dataset.children)
                {
                    childGrid.Rows.Add(new object[] {null, child.Fullname, child.BirthYear, child.DeathYear});
                    childGrid.Rows[i].Height = 25;
                    childGrid.Rows[i].Cells[2].ToolTipText = child.Birth;
                    childGrid.Rows[i].Cells[3].ToolTipText = child.Death;

                    i++;
                }

                // TODO consider an 'add' button instead?
                childGrid.Rows.Add(new object[] {null, "", "", ""});
                childGrid.Rows[i].Height = 25;
                childGrid.Rows[i].Cells[0].Style = _hideBtn;
                childGrid.Rows[i].Cells[0].ToolTipText = "";
            }
        }

        // A style used to hide the "goto" button in the datagridview
        private DataGridViewCellStyle _hideBtn = new DataGridViewCellStyle() {Padding = new Padding(100,0,0,0)};

        protected string oneLine(PData? p)
        {
            if (!p.HasValue)
                return "";
            return string.Format("{0} {1}",
                p.Value.Fullname, p.Value.DateRange);
        }

        private void goSDad_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.sDad.who);
        }

        private void goSMom_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.sMom.who);
        }

        public override void CoordinateSelection(object sender)
        {
            sDad.Selected = sMom.Selected = false;
            base.CoordinateSelection(sender);
        }
    }
}
