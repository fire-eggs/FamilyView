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
        private bool _isEdit;

        private static Font _addFont = new Font("Wingdings 2", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(2)));

        public PersonDataBox2()
        {
            InitializeComponent();

            btnNotesOrEdit.Font = _addFont;

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
                btnNotesOrEdit.Visible = value;
            }
        }

        public bool HasMedia    
        {
            get { return _hasMedia; }
            set
            {
                _hasMedia = value;
                btnMedia.Visible = value;
            }
        }

        public bool HasSours
        {
            get { return _hasSours; }
            set
            {
                _hasSours = value;
                btnSources.Visible = value;
            }
        }

        public bool IsEdit
        {
            set
            {
                _isEdit = value;
                UpdateButton();
            }
        }

        private void UpdateButton()
        {
            btnSources.Visible = _hasSours & !_isEdit;
            btnMedia.Visible = _hasMedia & !_isEdit;
            btnNotesOrEdit.Visible = _hasNotes | _isEdit;
            if (_hasNotes)
            {
                btnNotesOrEdit.BackgroundImage = FamilyView.Properties.Resources.notes_icon2_24;
                btnNotesOrEdit.Text = "";
            }
            if (_isEdit)
            {
                btnNotesOrEdit.BackgroundImage = null;
                btnNotesOrEdit.Text = "!";
            }
        }

        private void btnNotesOrEdit_Click(object sender, EventArgs e)
        {
            // TODO 'Add' state!
            Raise(_isEdit ? PersonArgs.EventType.Edit : PersonArgs.EventType.Notes);
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            Raise(PersonArgs.EventType.Media);
        }

        private void btnSources_Click(object sender, EventArgs e)
        {
            Raise(PersonArgs.EventType.Sources);
        }
    }
}
