using GEDWrap;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// TODO *spouse* with other marriages [Jennie /Eames/][Abigail /Burnham/][Mary /Wood/] - only shown in PAF when spouse is primary
// TODO children as grid
// TODO adoption?
// TODO indication that parent/child have family
// TODO draw lines parents->primary etc?
// TODO PAF btns are 19x22: create custom go btn class
// TODO GedDate.Year isn't always just the year
// TODO tooltips

// TODO KEL comment: would like to be able to make the child list taller when necessary
// TODO KEL comment: program should remember last scroll position in child list [constantly having to scroll]
// TODO KEL comment: useful to have child birth/death dates, maybe age. 'Parent link' is not useful.
// TODO KEL comment: didn't know what the little triangle in corner meant. Useful but needs to be more obvious.
// TODO KEL comment: Indi list really needs only name, sex, birth and death dates.
// TODO KEL comment: pedigree needs to show birth/death dates

// TODO KEL comment: birth/death dates useful to disambiguate people
// TODO KEL comment: prefers variant 4

namespace FamilyView
{
    public partial class Form1 : Form
    {
        private string _path; // Path to GED
        private bool _gedLoadOK;
        private bool _gedFound;

        public Form1()
        {
            InitializeComponent();

            setButtonStates();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _gedFound = false;
            _gedLoadOK = false;

            try
            {
                // browse for ged file
                var ofd = new OpenFileDialog();
                ofd.Multiselect = false;
                ofd.Filter = "GEDCOM files|*.ged;*.GED";
                ofd.FilterIndex = 1;
                ofd.DefaultExt = "ged";
                ofd.CheckFileExists = true;
                if (DialogResult.OK != ofd.ShowDialog(this))
                {
                    _gedFound = _gedLoadOK = true; // previous GED still valid
                    return;
                }
                _path = ofd.FileName;
                textBox1.Text = Path.GetFileName(_path);
                _gedFound = true;
            }
            finally
            {
                setButtonStates();
            }
        }

        private Forest _gedtrees;
        private void button6_Click(object sender, EventArgs e)
        {
            // load ged file into memory
            _gedtrees = new Forest();
            _gedtrees.LoadGEDCOM(_path);
            _gedLoadOK = !_gedtrees.IsEmpty;

            if (!_gedLoadOK)
                MessageBox.Show(this, "Error Loading GED file. Please find another.", "Couldn't load",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            var firstP = _gedtrees.AllPeople.FirstOrDefault();
            _baseData = Data.fetchData(firstP).GetValueOrDefault();

            // enable all view buttons on success
            setButtonStates();
        }

        // TODO prevent multiple clicks

        private void button1_Click(object sender, EventArgs e)
        {
            // variant 1
            var v1 = new View1(_baseData);
            v1.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // variant 2
            var v1 = new View2(_baseData);
            v1.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // variant 3
            var v1 = new View3(_baseData);
            v1.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // variant 4
            var v1 = new View4(_baseData);
            v1.Show(this);
        }

        private void setButtonStates()
        {
            button1.Enabled = _gedLoadOK;
            button2.Enabled = _gedLoadOK;
            button3.Enabled = _gedLoadOK;
            button4.Enabled = _gedLoadOK;
            button6.Enabled = _gedFound;
        }


        private DataSet _baseData;
    }
}
