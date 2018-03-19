namespace FamilyView
{
    partial class View4
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
            this.goDad = new System.Windows.Forms.Button();
            this.Marr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goMom = new System.Windows.Forms.Button();
            this.goSDad = new System.Windows.Forms.Button();
            this.goSMom = new System.Windows.Forms.Button();
            this.Primary = new FamilyView.PersonDataBox();
            this.Spouse = new FamilyView.PersonDataBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dad = new FamilyView.TBox();
            this.Mom = new FamilyView.TBox();
            this.sDad = new FamilyView.TBox();
            this.sMom = new FamilyView.TBox();
            this.childGrid = new System.Windows.Forms.DataGridView();
            this.navTo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSpouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.navToSpouse = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cMMarr = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.splitButton1 = new FamilyView.SplitButton();
            this.splitButton2 = new FamilyView.SplitButton();
            this.tboxPDad2 = new FamilyView.ParentTBox2();
            ((System.ComponentModel.ISupportInitialize)(this.childGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // goDad
            // 
            this.goDad.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.goDad.Location = new System.Drawing.Point(765, 26);
            this.goDad.Margin = new System.Windows.Forms.Padding(2);
            this.goDad.Name = "goDad";
            this.goDad.Size = new System.Drawing.Size(27, 25);
            this.goDad.TabIndex = 2;
            this.goDad.Text = "u";
            this.goDad.UseVisualStyleBackColor = true;
            this.goDad.Click += new System.EventHandler(this.goDad_Click);
            // 
            // Marr
            // 
            this.Marr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Marr.Location = new System.Drawing.Point(129, 132);
            this.Marr.Margin = new System.Windows.Forms.Padding(4);
            this.Marr.Name = "Marr";
            this.Marr.Size = new System.Drawing.Size(149, 22);
            this.Marr.TabIndex = 3;
            this.Marr.Text = "Marriage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spouse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Children:";
            // 
            // goMom
            // 
            this.goMom.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.goMom.Location = new System.Drawing.Point(765, 76);
            this.goMom.Margin = new System.Windows.Forms.Padding(2);
            this.goMom.Name = "goMom";
            this.goMom.Size = new System.Drawing.Size(27, 25);
            this.goMom.TabIndex = 2;
            this.goMom.Text = "u";
            this.goMom.UseVisualStyleBackColor = true;
            this.goMom.Click += new System.EventHandler(this.goMom_Click);
            // 
            // goSDad
            // 
            this.goSDad.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.goSDad.Location = new System.Drawing.Point(765, 189);
            this.goSDad.Margin = new System.Windows.Forms.Padding(2);
            this.goSDad.Name = "goSDad";
            this.goSDad.Size = new System.Drawing.Size(27, 25);
            this.goSDad.TabIndex = 2;
            this.goSDad.Text = "u";
            this.goSDad.UseVisualStyleBackColor = true;
            this.goSDad.Click += new System.EventHandler(this.goSDad_Click);
            // 
            // goSMom
            // 
            this.goSMom.Font = new System.Drawing.Font("Wingdings 3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.goSMom.Location = new System.Drawing.Point(765, 238);
            this.goSMom.Margin = new System.Windows.Forms.Padding(2);
            this.goSMom.Name = "goSMom";
            this.goSMom.Size = new System.Drawing.Size(27, 25);
            this.goSMom.TabIndex = 2;
            this.goSMom.Text = "u";
            this.goSMom.UseVisualStyleBackColor = true;
            this.goSMom.Click += new System.EventHandler(this.goSMom_Click);
            // 
            // Primary
            // 
            this.Primary.BackColor = System.Drawing.SystemColors.Control;
            this.Primary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Primary.ForeColor = System.Drawing.Color.Black;
            this.Primary.HasMedia = false;
            this.Primary.HasNotes = false;
            this.Primary.HasSours = false;
            this.Primary.Location = new System.Drawing.Point(39, 19);
            this.Primary.Margin = new System.Windows.Forms.Padding(4);
            this.Primary.Multiline = true;
            this.Primary.Name = "Primary";
            this.Primary.Owner = null;
            this.Primary.ReadOnly = true;
            this.Primary.Selected = false;
            this.Primary.Size = new System.Drawing.Size(388, 85);
            this.Primary.TabIndex = 7;
            this.Primary.TabStop = false;
            this.Primary.Who = null;
            // 
            // Spouse
            // 
            this.Spouse.BackColor = System.Drawing.SystemColors.Control;
            this.Spouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spouse.ForeColor = System.Drawing.Color.Black;
            this.Spouse.HasMedia = false;
            this.Spouse.HasNotes = false;
            this.Spouse.HasSours = false;
            this.Spouse.Location = new System.Drawing.Point(57, 191);
            this.Spouse.Margin = new System.Windows.Forms.Padding(4);
            this.Spouse.Multiline = true;
            this.Spouse.Name = "Spouse";
            this.Spouse.Owner = null;
            this.Spouse.ReadOnly = true;
            this.Spouse.Selected = false;
            this.Spouse.Size = new System.Drawing.Size(367, 85);
            this.Spouse.TabIndex = 8;
            this.Spouse.TabStop = false;
            this.Spouse.Who = null;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(431, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 2);
            this.label3.TabIndex = 9;
            this.label3.Text = "-----------";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(431, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 2);
            this.label4.TabIndex = 9;
            this.label4.Text = "-----------";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(487, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(487, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "label5";
            // 
            // Dad
            // 
            this.Dad.BackColor = System.Drawing.Color.White;
            this.Dad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dad.ForeColor = System.Drawing.Color.Black;
            this.Dad.Location = new System.Drawing.Point(460, 28);
            this.Dad.Margin = new System.Windows.Forms.Padding(4);
            this.Dad.Multiline = true;
            this.Dad.Name = "Dad";
            this.Dad.Owner = null;
            this.Dad.ReadOnly = true;
            this.Dad.Selected = false;
            this.Dad.Size = new System.Drawing.Size(296, 20);
            this.Dad.TabIndex = 11;
            this.Dad.TabStop = false;
            this.Dad.Who = null;
            // 
            // Mom
            // 
            this.Mom.BackColor = System.Drawing.Color.White;
            this.Mom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mom.ForeColor = System.Drawing.Color.Black;
            this.Mom.Location = new System.Drawing.Point(460, 78);
            this.Mom.Margin = new System.Windows.Forms.Padding(4);
            this.Mom.Multiline = true;
            this.Mom.Name = "Mom";
            this.Mom.Owner = null;
            this.Mom.ReadOnly = true;
            this.Mom.Selected = false;
            this.Mom.Size = new System.Drawing.Size(296, 20);
            this.Mom.TabIndex = 12;
            this.Mom.TabStop = false;
            this.Mom.Who = null;
            // 
            // sDad
            // 
            this.sDad.BackColor = System.Drawing.Color.White;
            this.sDad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sDad.ForeColor = System.Drawing.Color.Black;
            this.sDad.Location = new System.Drawing.Point(460, 191);
            this.sDad.Margin = new System.Windows.Forms.Padding(4);
            this.sDad.Multiline = true;
            this.sDad.Name = "sDad";
            this.sDad.Owner = null;
            this.sDad.ReadOnly = true;
            this.sDad.Selected = false;
            this.sDad.Size = new System.Drawing.Size(296, 21);
            this.sDad.TabIndex = 13;
            this.sDad.TabStop = false;
            this.sDad.Who = null;
            // 
            // sMom
            // 
            this.sMom.BackColor = System.Drawing.Color.White;
            this.sMom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sMom.ForeColor = System.Drawing.Color.Black;
            this.sMom.Location = new System.Drawing.Point(460, 240);
            this.sMom.Margin = new System.Windows.Forms.Padding(4);
            this.sMom.Multiline = true;
            this.sMom.Name = "sMom";
            this.sMom.Owner = null;
            this.sMom.ReadOnly = true;
            this.sMom.Selected = false;
            this.sMom.Size = new System.Drawing.Size(294, 20);
            this.sMom.TabIndex = 14;
            this.sMom.TabStop = false;
            this.sMom.Who = null;
            // 
            // childGrid
            // 
            this.childGrid.AllowUserToAddRows = false;
            this.childGrid.AllowUserToDeleteRows = false;
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
            this.childGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.childGrid.Location = new System.Drawing.Point(43, 317);
            this.childGrid.MultiSelect = false;
            this.childGrid.Name = "childGrid";
            this.childGrid.ReadOnly = true;
            this.childGrid.RowHeadersVisible = false;
            this.childGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.childGrid.ShowEditingIcon = false;
            this.childGrid.Size = new System.Drawing.Size(735, 129);
            this.childGrid.TabIndex = 16;
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
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(147, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 35);
            this.label7.TabIndex = 10;
            this.label7.Text = "label5";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(147, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Marriage:";
            // 
            // splitButton1
            // 
            this.splitButton1.DropDownOnly = false;
            this.splitButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton1.Location = new System.Drawing.Point(300, 111);
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
            this.splitButton2.Location = new System.Drawing.Point(300, 279);
            this.splitButton2.Name = "splitButton2";
            this.splitButton2.Size = new System.Drawing.Size(124, 23);
            this.splitButton2.TabIndex = 18;
            this.splitButton2.Text = "Other Marriages";
            this.splitButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.splitButton2.UseVisualStyleBackColor = true;
            // 
            // tboxPDad2
            // 
            this.tboxPDad2.Key = null;
            this.tboxPDad2.Location = new System.Drawing.Point(460, 114);
            this.tboxPDad2.Margin = new System.Windows.Forms.Padding(4);
            this.tboxPDad2.Name = "tboxPDad2";
            this.tboxPDad2.Size = new System.Drawing.Size(332, 22);
            this.tboxPDad2.TabIndex = 20;
            // 
            // View4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 458);
            this.Controls.Add(this.tboxPDad2);
            this.Controls.Add(this.splitButton2);
            this.Controls.Add(this.splitButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Marr);
            this.Controls.Add(this.childGrid);
            this.Controls.Add(this.sMom);
            this.Controls.Add(this.sDad);
            this.Controls.Add(this.Mom);
            this.Controls.Add(this.Dad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Spouse);
            this.Controls.Add(this.Primary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goSMom);
            this.Controls.Add(this.goSDad);
            this.Controls.Add(this.goMom);
            this.Controls.Add(this.goDad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View4";
            this.Text = "View4";
            ((System.ComponentModel.ISupportInitialize)(this.childGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goDad;
        private System.Windows.Forms.TextBox Marr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goMom;
        private System.Windows.Forms.Button goSDad;
        private System.Windows.Forms.Button goSMom;
        private PersonDataBox Primary;
        private PersonDataBox Spouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private TBox Dad;
        private TBox Mom;
        private TBox sDad;
        private TBox sMom;
        private System.Windows.Forms.DataGridView childGrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
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
    }
}