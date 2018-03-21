﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace FamilyView
{
    public partial class ParentTBox2 : UserControl
    {
        private static Font _addFont = new Font("Wingdings 2", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));
        private static Font _goFont = new Font("Wingdings 3", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));

        public event EventHandler Person;

        private PData? _who;
        private bool _isgo;  // TODO use EventType as 'state' instead?
        private bool _isEdit;

        public ParentTBox2()
        {
            InitializeComponent();

            btnGo.Click += OnGoClick;
            label1.DoubleClick += OnDClick;
        }

        public enum EventType
        {
            Go,
            Add,
            Edit
        };

        private void Raise(EventType which)
        {
            if (Person == null)
                return;
            var pea = new PersonArgs();
            pea.Key = Key;
            pea.Which = which;
            pea.Who = _who;
            Person(this, pea);
        }

        private void OnGoClick(object sender, EventArgs e)
        {
            if (!_isgo) // add
            {
                Raise(EventType.Add);
            }
            else if (_isEdit) // not add, edit
            {
                Raise(EventType.Edit);
            }
            else // go, not edit
            {
                Raise(EventType.Go);
            }
        }

        private void OnDClick(object sender, EventArgs e)
        {
            Raise(_isgo ? EventType.Edit : EventType.Add);
        }

        public PData? Who 
        {
            set
            {
                _who = value;

                _isgo = _who.HasValue && _who.Value.who != null;
                label1.Text = oneLine(_who);
                UpdateButton();
            } 
        }

        private void UpdateButton()
        {
            if (!_isgo) // add
            {
                btnGo.Font = _addFont;
                btnGo.Text = "É";
            }
            else if (_isEdit) // not add, edit
            {
                btnGo.Font = _addFont;
                btnGo.Text = "!";
            }
            else // go, not edit
            {
                btnGo.Font = _goFont;
                btnGo.Text = "u";
            }
        }

        public PersonArgs.ParentKey Key { get; set; } // NOTE: Defined type useful in designer

        protected string oneLine(PData? p)
        {
            if (!p.HasValue)
                return "";
            return string.Format("{0} {1}",
                p.Value.Fullname, p.Value.DateRange);
        }

        public bool IsEdit
        {
            set
            {
                _isEdit = value; 
                UpdateButton();
            }
        }
    }

    public class PersonArgs : EventArgs // TODO to separate file?
    {
        public enum ParentKey
        {
            PrimaryDad,
            PrimaryMom,
            SpouseDad,
            SpouseMom
        }

        public ParentKey Key { get; set; } 
        public PData? Who { get; set; } // TODO declare as object instead?
        public ParentTBox2.EventType Which { get; set; }
    }

}