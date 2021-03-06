﻿using System.Text;
using System.Windows.Forms;
using GEDWrap;

namespace FamilyView
{
    public class ViewBase : Form
    {
        protected DataSet _dataset;

        protected Button[] _childBtns;

        protected const int MAX_CHILD_BTNS = 5;

        protected TBox _primary;
        protected TBox _spouse;
        protected TextBox _marr;
        protected TBox _dad;
        protected TBox _mom;
        protected ListBox _childs;
        protected Button _goDad;
        protected Button _goMom;

        protected ViewBase() // designer required
        {
        }

        public ViewBase(DataSet baseData)
        {
            _dataset = baseData;
            ShowInTaskbar = false;
        }

        protected string buildLines(PData? p)
        {
            if (!p.HasValue)
                return "";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(p.Value.Fullname);
            sb.AppendLine(p.Value.Birth);
            sb.AppendLine(p.Value.Death);
            return sb.ToString();
        }

        protected virtual void SetContents()
        {
            _spouse.Text = buildLines(_dataset.spouse);

            _dad.Text = buildLines(_dataset.pDad);
            _mom.Text = buildLines(_dataset.pMom);

            _marr.Text = "Marriage:" + _dataset.marriage;

            if (_childs != null)
            {
                _childs.Items.Clear();
                int nchil = 0;
                if (_dataset.children != null)
                {
                    foreach (var child in _dataset.children)
                    {
                        _childs.Items.Add(child.primary.Fullname);
                    }
                    nchil = _dataset.children.Count;
                }
                for (int i = 0; i < MAX_CHILD_BTNS; i++)
                {
                    _childBtns[i].Visible = i < nchil;
                }
            }

            _goDad.Visible = _dataset.pDad.who != null;
            _goMom.Visible = _dataset.pMom.who != null;

            _spouse.Who = _dataset.spouse;
            _dad.Who = _dataset.pDad;
            _mom.Who = _dataset.pMom;

            if (_primary != null)
            {
                _primary.Who = _dataset.primary;
                _primary.Text = buildLines(_dataset.primary);
                CoordinateSelection(_primary); // force primary to be selected on change
            }

        }

        protected void changePerson(Person p)
        {
            _dataset = Data.fetchData(p).GetValueOrDefault();
            SetContents();
        }

        public virtual void CoordinateSelection(object sender)
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
            //sDad.Selected = sMom.Selected = false;

            selected.Selected = true;
        }

    }
}
