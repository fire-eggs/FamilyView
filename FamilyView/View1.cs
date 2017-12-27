﻿using System;

// TODO: primary/spouse switch

namespace FamilyView
{
    public partial class View1 : ViewBase
    {
        [Obsolete("Designer only", true)]
        private View1()
        {
            InitializeComponent();
        }

        public View1(DataSet baseData) : base(baseData)
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

            Dad.Owner = Mom.Owner = Primary.Owner = Spouse.Owner = this;

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
            btnMarriages.Visible = _dataset.primary.HasMMarr;
        }

        public override void CoordinateSelection(object sender)
        {
            TBox selected = sender as TBox;
            if (selected == null || selected.Selected)
                return;

            Primary.Selected = Spouse.Selected = false;
            Dad.Selected = Mom.Selected = false;

            selected.Selected = true;
        }

    }
}
