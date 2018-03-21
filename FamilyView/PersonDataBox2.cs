using System;
using System.Drawing;
using System.Windows.Forms;

namespace FamilyView
{
    public partial class PersonDataBox2 : UserControl
    {
        public event EventHandler Person;
        public event EventHandler Selected;

        private bool _selected;

        public PersonDataBox2()
        {
            InitializeComponent();

            label1.Click += label1_Click;
            label1.DoubleClick += label1_DoubleClick;
            panel1.Click += label1_Click;
            panel1.DoubleClick += label1_DoubleClick;
        }

        void label1_DoubleClick(object sender, EventArgs e)
        {
            Raise(Who.HasValue ? PersonArgs.EventType.Edit : PersonArgs.EventType.Add);
        }

        private void Raise(PersonArgs.EventType which)
        {
            if (Person == null)
                return;
            var pea = new PersonArgs();
            pea.Which = which;
            pea.Who = Who;
            Person(this, pea);
        }

        void label1_Click(object sender, EventArgs e)
        {
            if (Selected != null)
                Selected(this, null);
        }

        public bool IsSelected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                label1.ForeColor = _selected ? _selFore : _normFore;
                label1.BackColor = _selected ? _selBack : _normBack;
                panel1.BackColor = _selected ? _selBack : _normBack;
            }
        }

        public PData? Who { get; set; }

        private Color _normBack = Color.White;
        private Color _normFore = Color.Black;
        private Color _selBack = Color.CornflowerBlue;
        private Color _selFore = Color.White;
        private bool _hasNotes;
        private bool _hasMedia;
        private bool _hasSours;

        public override string Text
        {
            set { label1.Text = value; }
        }

        public bool HasNotes
        {
            get { return _hasNotes; }
            set
            {
                _hasNotes = value;
                button1.Visible = value;
            }
        }

        public bool HasMedia    
        {
            get { return _hasMedia; }
            set
            {
                _hasMedia = value;
                button2.Visible = value;
            }
        }

        public bool HasSours
        {
            get { return _hasSours; }
            set
            {
                _hasSours = value;
                button3.Visible = value;
            }
        }
    }
}
