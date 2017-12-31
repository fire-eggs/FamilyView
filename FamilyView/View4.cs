using System;
using System.Drawing;
using System.Windows.Forms;

// TODO winforms dropdown-button for 'other marriages'

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

            _childBtns = new[] { goChild1, goChild2, goChild3, goChild4, goChild5 };
            //_primary = Primary;
            //_spouse = Spouse;
            _marr = Marr;
            _dad = Dad;
            _mom = Mom;
            _childs = listBox1;
            _goDad = goDad;
            _goMom = goMom;

            Dad.Owner = Mom.Owner = sDad.Owner = sMom.Owner = Primary.Owner = Spouse.Owner = this;

            Dad.Multiline = false;
            Mom.Multiline = false;
            sDad.Multiline = false;
            sMom.Multiline = false;

            SetContents();
        }

        private void goDad_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.pDad.who);
        }

        private void goMom_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.pMom.who);
        }

        private void goChild1_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.children[0].who);
        }

        private void goChild2_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.children[1].who);
        }

        private void goChild3_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.children[2].who);
        }

        private void goChild4_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.children[3].who);
        }

        private void goChild5_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.children[4].who);
        }

        protected override void SetContents()
        {
            base.SetContents();

            _dad.Text = oneLine(_dataset.pDad);
            _mom.Text = oneLine(_dataset.pMom);

            sDad.Text = oneLine(_dataset.sDad);
            sMom.Text = oneLine(_dataset.sMom);

            sDad.Who = _dataset.sDad;
            sMom.Who = _dataset.sMom;

            btnMarriages.Visible = _dataset.primary.HasMMarr;
            btnSMarriages.Visible = _dataset.spouse.HasValue && _dataset.spouse.Value.HasMMarr;

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

        }

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
