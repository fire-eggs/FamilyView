using System;
using System.Text;

namespace FamilyView
{
    public partial class View3 : ViewBase
    {
        private View3()
        {
            InitializeComponent();
        }

        public View3(DataSet baseData) : base(baseData)
        {
            InitializeComponent();

            _childBtns = new[] { goChild1, goChild2, goChild3, goChild4, goChild5 };
            _primary = Primary;
            _spouse = Spouse;
            _marr = Marr;
            _dad = Dad;
            _mom = Mom;
            _childs = listBox1;
            _goDad = goDad;
            _goMom = goMom;

            Dad.Owner = Mom.Owner = sDad.Owner = sMom.Owner = Primary.Owner = Spouse.Owner = this;

            SetContents();
        }

        private void goChild5_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.children[4].who);
        }

        private void goChild4_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.children[3].who);
        }

        private void goChild3_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.children[2].who);
        }

        private void goChild2_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.children[1].who);
        }

        private void goChild1_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.children[0].who);
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
            base.SetContents();

            _dad.Text = twoLines(_dataset.pDad);
            _mom.Text = twoLines(_dataset.pMom);

            sDad.Text = twoLines(_dataset.sDad);
            sMom.Text = twoLines(_dataset.sMom);

            sDad.Who = _dataset.sDad;
            sMom.Who = _dataset.sMom;

            btnMarriages.Visible = _dataset.primary.HasMMarr;

            button7.Visible = _dataset.sDad.who != null;
            button6.Visible = _dataset.sMom.who != null;
        }

        protected string twoLines(PData? p)
        {
            if (!p.HasValue)
                return "";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(p.Value.Fullname);
            sb.AppendLine(p.Value.DateRange);
            return sb.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            changePerson(_dataset.sDad.who);
        }

        private void button6_Click(object sender, EventArgs e)
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
