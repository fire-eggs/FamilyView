using System.Drawing;
using System.Windows.Forms;

namespace FamilyView
{
    public partial class PersonDataBox : UserControl
    {
        private bool _selected;

        public PersonDataBox()
        {
            InitializeComponent();
        }

        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        public ViewBase Owner { get; set; }

        public bool ReadOnly
        {
            get { return textBox1.ReadOnly; }
            set { textBox1.ReadOnly = value; }
        }

        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                DrawSelected(value);
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

        private void DrawSelected(bool selected)
        {
            textBox1.ForeColor = selected ? _selFore : _normFore;
            textBox1.BackColor = selected ? _selBack : _normBack;
        }

        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
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
