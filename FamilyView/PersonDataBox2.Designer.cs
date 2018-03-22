namespace FamilyView
{
    partial class PersonDataBox2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNotesOrEdit = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnSources = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNotesOrEdit
            // 
            this.btnNotesOrEdit.BackgroundImage = global::FamilyView.Properties.Resources.notes_icon2_24;
            this.btnNotesOrEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotesOrEdit.Location = new System.Drawing.Point(228, 0);
            this.btnNotesOrEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnNotesOrEdit.MaximumSize = new System.Drawing.Size(30, 30);
            this.btnNotesOrEdit.Name = "btnNotesOrEdit";
            this.btnNotesOrEdit.Size = new System.Drawing.Size(26, 26);
            this.btnNotesOrEdit.TabIndex = 1;
            this.btnNotesOrEdit.UseVisualStyleBackColor = true;
            this.btnNotesOrEdit.Click += new System.EventHandler(this.btnNotesOrEdit_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackgroundImage = global::FamilyView.Properties.Resources.Picture_icon_24;
            this.btnMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedia.Location = new System.Drawing.Point(228, 26);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(0);
            this.btnMedia.MaximumSize = new System.Drawing.Size(30, 30);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(26, 26);
            this.btnMedia.TabIndex = 2;
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnSources
            // 
            this.btnSources.BackgroundImage = global::FamilyView.Properties.Resources.book_icon_24;
            this.btnSources.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSources.Location = new System.Drawing.Point(228, 52);
            this.btnSources.Margin = new System.Windows.Forms.Padding(0);
            this.btnSources.Name = "btnSources";
            this.btnSources.Size = new System.Drawing.Size(26, 26);
            this.btnSources.TabIndex = 3;
            this.btnSources.UseVisualStyleBackColor = true;
            this.btnSources.Click += new System.EventHandler(this.btnSources_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Controls.Add(this.btnNotesOrEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSources, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMedia, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 135);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(228, 135);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // PersonDataBox2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PersonDataBox2";
            this.Size = new System.Drawing.Size(254, 135);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNotesOrEdit;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnSources;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
