using System;
using System.Drawing;
using System.Windows.Forms;

namespace FamilyView
{
    public partial class TBox : TextBox
    {
        private Color _normBack = Color.White;
        private Color _normFore = Color.Black;
        private Color _selBack = Color.CornflowerBlue;
        private Color _selFore = Color.White;

        public TBox()
        {
            InitializeComponent();

            Multiline = true;
            ReadOnly = true;
            TabStop = false;
            BorderStyle = BorderStyle.FixedSingle;

            BackColor = _normBack;
            ForeColor = _normFore;

            Margin = new Padding(4);

            Click += TBox_Click;
            DoubleClick += TBox_DoubleClick;
        }

        void TBox_DoubleClick(object sender, EventArgs e)
        {
            if (Who.HasValue)
                MessageBox.Show(Who.Value.Fullname, "Editing person");
            else
                MessageBox.Show("Add new person / select existing", "No person");
        }

        void TBox_Click(object sender, EventArgs e)
        {
            Owner.CoordinateSelection(sender);
        }

        public ViewBase Owner { get; set; }

        public PData? Who { get; set; }

        private bool _selected;
        public bool Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                DrawSelected(value); 
            }
        }

        private void DrawSelected(bool selected)
        {
            ForeColor = selected ? _selFore : _normFore;
            BackColor = selected ? _selBack : _normBack;
        }
    }
}
