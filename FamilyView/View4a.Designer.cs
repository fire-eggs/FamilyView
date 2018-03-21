namespace FamilyView
{
    partial class View4a
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Marr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Primary = new FamilyView.PersonDataBox2();
            this.Spouse = new FamilyView.PersonDataBox2();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.childGrid = new System.Windows.Forms.DataGridView();
            this.navTo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSpouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navToSpouse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cMMarr = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.marrLineDown = new System.Windows.Forms.Label();
            this.marrLineUp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.splitButton1 = new FamilyView.SplitButton();
            this.splitButton2 = new FamilyView.SplitButton();
            this.tboxPDad2 = new FamilyView.ParentTBox2();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxSMom = new FamilyView.ParentTBox2();
            this.tboxSDad = new FamilyView.ParentTBox2();
            this.tboxPMom = new FamilyView.ParentTBox2();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.childGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Marr
            // 
            this.Marr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Marr.Location = new System.Drawing.Point(109, 130);
            this.Marr.Margin = new System.Windows.Forms.Padding(4);
            this.Marr.Name = "Marr";
            this.Marr.Size = new System.Drawing.Size(149, 22);
            this.Marr.TabIndex = 3;
            this.Marr.Text = "Marriage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-154, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spouse:";
            // 
            // Primary
            // 
            this.Primary.BackColor = System.Drawing.SystemColors.Control;
            this.Primary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Primary.ForeColor = System.Drawing.Color.Black;
            this.Primary.HasMedia = false;
            this.Primary.HasNotes = false;
            this.Primary.HasSours = false;
            this.Primary.IsSelected = false;
            this.Primary.Location = new System.Drawing.Point(19, 17);
            this.Primary.Margin = new System.Windows.Forms.Padding(4);
            this.Primary.Name = "Primary";
            this.Primary.Size = new System.Drawing.Size(388, 85);
            this.Primary.TabIndex = 7;
            this.Primary.TabStop = false;
            this.Primary.Who = null;
            this.Primary.Person += new System.EventHandler(this.personEvent);
            this.Primary.Selected += new System.EventHandler(this.selectedEvent);
            // 
            // Spouse
            // 
            this.Spouse.BackColor = System.Drawing.SystemColors.Control;
            this.Spouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spouse.ForeColor = System.Drawing.Color.Black;
            this.Spouse.HasMedia = false;
            this.Spouse.HasNotes = false;
            this.Spouse.HasSours = false;
            this.Spouse.IsSelected = false;
            this.Spouse.Location = new System.Drawing.Point(37, 178);
            this.Spouse.Margin = new System.Windows.Forms.Padding(4);
            this.Spouse.Name = "Spouse";
            this.Spouse.Size = new System.Drawing.Size(367, 85);
            this.Spouse.TabIndex = 8;
            this.Spouse.TabStop = false;
            this.Spouse.Who = null;
            this.Spouse.Person += new System.EventHandler(this.personEvent);
            this.Spouse.Selected += new System.EventHandler(this.selectedEvent);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(411, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 2);
            this.label3.TabIndex = 9;
            this.label3.Text = "-----------";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(411, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 2);
            this.label4.TabIndex = 9;
            this.label4.Text = "-----------";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(467, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(467, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "label5";
            // 
            // childGrid
            // 
            this.childGrid.AllowUserToAddRows = false;
            this.childGrid.AllowUserToDeleteRows = false;
            this.childGrid.AllowUserToResizeRows = false;
            this.childGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.childGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.childGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.navTo,
            this.cName,
            this.bDate,
            this.dDate,
            this.cSpouseName,
            this.navToSpouse,
            this.cMMarr});
            this.childGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.childGrid.Location = new System.Drawing.Point(3, 18);
            this.childGrid.MultiSelect = false;
            this.childGrid.Name = "childGrid";
            this.childGrid.ReadOnly = true;
            this.childGrid.RowHeadersVisible = false;
            this.childGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.childGrid.ShowCellErrors = false;
            this.childGrid.ShowEditingIcon = false;
            this.childGrid.ShowRowErrors = false;
            this.childGrid.Size = new System.Drawing.Size(788, 196);
            this.childGrid.TabIndex = 16;
            this.childGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChildGridCellClick);
            this.childGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChildGridCellDoubleClick);
            // 
            // navTo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.navTo.DefaultCellStyle = dataGridViewCellStyle2;
            this.navTo.HeaderText = "";
            this.navTo.MinimumWidth = 25;
            this.navTo.Name = "navTo";
            this.navTo.ReadOnly = true;
            this.navTo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.navTo.Width = 40;
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.MinimumWidth = 50;
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            this.cName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cName.Width = 200;
            // 
            // bDate
            // 
            this.bDate.HeaderText = "Birth";
            this.bDate.MinimumWidth = 50;
            this.bDate.Name = "bDate";
            this.bDate.ReadOnly = true;
            this.bDate.Width = 75;
            // 
            // dDate
            // 
            this.dDate.HeaderText = "Death";
            this.dDate.MinimumWidth = 50;
            this.dDate.Name = "dDate";
            this.dDate.ReadOnly = true;
            this.dDate.Width = 75;
            // 
            // cSpouseName
            // 
            this.cSpouseName.HeaderText = "Spouse";
            this.cSpouseName.MinimumWidth = 50;
            this.cSpouseName.Name = "cSpouseName";
            this.cSpouseName.ReadOnly = true;
            this.cSpouseName.Width = 200;
            // 
            // navToSpouse
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.navToSpouse.DefaultCellStyle = dataGridViewCellStyle3;
            this.navToSpouse.HeaderText = "";
            this.navToSpouse.MinimumWidth = 25;
            this.navToSpouse.Name = "navToSpouse";
            this.navToSpouse.ReadOnly = true;
            this.navToSpouse.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.navToSpouse.Width = 40;
            // 
            // cMMarr
            // 
            this.cMMarr.FalseValue = "false";
            this.cMMarr.HeaderText = "Multi";
            this.cMMarr.Name = "cMMarr";
            this.cMMarr.ReadOnly = true;
            this.cMMarr.TrueValue = "true";
            // 
            // marrLineDown
            // 
            this.marrLineDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marrLineDown.Location = new System.Drawing.Point(145, 141);
            this.marrLineDown.Name = "marrLineDown";
            this.marrLineDown.Size = new System.Drawing.Size(2, 35);
            this.marrLineDown.TabIndex = 10;
            this.marrLineDown.Text = "label5";
            // 
            // marrLineUp
            // 
            this.marrLineUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marrLineUp.Location = new System.Drawing.Point(145, 99);
            this.marrLineUp.Name = "marrLineUp";
            this.marrLineUp.Size = new System.Drawing.Size(2, 30);
            this.marrLineUp.TabIndex = 10;
            this.marrLineUp.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Marriage:";
            // 
            // splitButton1
            // 
            this.splitButton1.DropDownOnly = false;
            this.splitButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton1.Location = new System.Drawing.Point(280, 109);
            this.splitButton1.Name = "splitButton1";
            this.splitButton1.Size = new System.Drawing.Size(124, 23);
            this.splitButton1.TabIndex = 18;
            this.splitButton1.Text = "Other Marriages";
            this.splitButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.splitButton1.UseVisualStyleBackColor = true;
            // 
            // splitButton2
            // 
            this.splitButton2.DropDownOnly = false;
            this.splitButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton2.Location = new System.Drawing.Point(280, 266);
            this.splitButton2.Name = "splitButton2";
            this.splitButton2.Size = new System.Drawing.Size(124, 23);
            this.splitButton2.TabIndex = 18;
            this.splitButton2.Text = "Other Marriages";
            this.splitButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.splitButton2.UseVisualStyleBackColor = true;
            // 
            // tboxPDad2
            // 
            this.tboxPDad2.Key = FamilyView.PersonArgs.ParentKey.PrimaryDad;
            this.tboxPDad2.Location = new System.Drawing.Point(440, 21);
            this.tboxPDad2.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPDad2.Name = "tboxPDad2";
            this.tboxPDad2.Size = new System.Drawing.Size(332, 22);
            this.tboxPDad2.TabIndex = 20;
            this.tboxPDad2.Person += new System.EventHandler(this.personEvent);
            this.tboxPDad2.Selected += new System.EventHandler(this.selectedEvent);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 550);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.childGrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Children:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tboxSMom);
            this.panel1.Controls.Add(this.tboxSDad);
            this.panel1.Controls.Add(this.tboxPMom);
            this.panel1.Controls.Add(this.Primary);
            this.panel1.Controls.Add(this.tboxPDad2);
            this.panel1.Controls.Add(this.splitButton2);
            this.panel1.Controls.Add(this.splitButton1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Marr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Spouse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.marrLineDown);
            this.panel1.Controls.Add(this.marrLineUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 292);
            this.panel1.TabIndex = 0;
            // 
            // tboxSMom
            // 
            this.tboxSMom.Key = FamilyView.PersonArgs.ParentKey.SpouseMom;
            this.tboxSMom.Location = new System.Drawing.Point(440, 234);
            this.tboxSMom.Margin = new System.Windows.Forms.Padding(5);
            this.tboxSMom.Name = "tboxSMom";
            this.tboxSMom.Size = new System.Drawing.Size(332, 22);
            this.tboxSMom.TabIndex = 22;
            this.tboxSMom.Person += new System.EventHandler(this.personEvent);
            this.tboxSMom.Selected += new System.EventHandler(this.selectedEvent);
            // 
            // tboxSDad
            // 
            this.tboxSDad.Key = FamilyView.PersonArgs.ParentKey.SpouseDad;
            this.tboxSDad.Location = new System.Drawing.Point(440, 173);
            this.tboxSDad.Margin = new System.Windows.Forms.Padding(4);
            this.tboxSDad.Name = "tboxSDad";
            this.tboxSDad.Size = new System.Drawing.Size(332, 22);
            this.tboxSDad.TabIndex = 22;
            this.tboxSDad.Person += new System.EventHandler(this.personEvent);
            this.tboxSDad.Selected += new System.EventHandler(this.selectedEvent);
            // 
            // tboxPMom
            // 
            this.tboxPMom.Key = FamilyView.PersonArgs.ParentKey.PrimaryMom;
            this.tboxPMom.Location = new System.Drawing.Point(440, 81);
            this.tboxPMom.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPMom.Name = "tboxPMom";
            this.tboxPMom.Size = new System.Drawing.Size(332, 22);
            this.tboxPMom.TabIndex = 21;
            this.tboxPMom.Person += new System.EventHandler(this.personEvent);
            this.tboxPMom.Selected += new System.EventHandler(this.selectedEvent);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // View4a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View4a";
            this.Text = "View4";
            ((System.ComponentModel.ISupportInitialize)(this.childGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Marr;
        private System.Windows.Forms.Label label1;
        private PersonDataBox2 Primary;
        private PersonDataBox2 Spouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView childGrid;
        private System.Windows.Forms.Label marrLineDown;
        private System.Windows.Forms.Label marrLineUp;
        private System.Windows.Forms.Label label9;
        private SplitButton splitButton1;
        private SplitButton splitButton2;
        private System.Windows.Forms.DataGridViewButtonColumn navTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSpouseName;
        private System.Windows.Forms.DataGridViewButtonColumn navToSpouse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cMMarr;
        private ParentTBox2 tboxPDad2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private ParentTBox2 tboxSMom;
        private ParentTBox2 tboxSDad;
        private ParentTBox2 tboxPMom;
    }
}