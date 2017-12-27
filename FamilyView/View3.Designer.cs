namespace FamilyView
{
    partial class View3
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
            this.label1 = new System.Windows.Forms.Label();
            this.Marr = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.goChild1 = new System.Windows.Forms.Button();
            this.goChild2 = new System.Windows.Forms.Button();
            this.goChild3 = new System.Windows.Forms.Button();
            this.goChild4 = new System.Windows.Forms.Button();
            this.goChild5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.goMom = new System.Windows.Forms.Button();
            this.goDad = new System.Windows.Forms.Button();
            this.Dad = new FamilyView.TBox();
            this.Primary = new FamilyView.TBox();
            this.Mom = new FamilyView.TBox();
            this.sDad = new FamilyView.TBox();
            this.sMom = new FamilyView.TBox();
            this.Spouse = new FamilyView.TBox();
            this.btnMarriages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spouse:";
            // 
            // Marr
            // 
            this.Marr.Location = new System.Drawing.Point(311, 217);
            this.Marr.Margin = new System.Windows.Forms.Padding(4);
            this.Marr.Name = "Marr";
            this.Marr.Size = new System.Drawing.Size(235, 22);
            this.Marr.TabIndex = 3;
            this.Marr.Text = "Marriage:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Child 1",
            "Child 2",
            "Child 3",
            "Child 4",
            "Child 5"});
            this.listBox1.Location = new System.Drawing.Point(68, 261);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(800, 132);
            this.listBox1.TabIndex = 4;
            // 
            // goChild1
            // 
            this.goChild1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goChild1.Location = new System.Drawing.Point(20, 261);
            this.goChild1.Margin = new System.Windows.Forms.Padding(2);
            this.goChild1.Name = "goChild1";
            this.goChild1.Size = new System.Drawing.Size(27, 25);
            this.goChild1.TabIndex = 5;
            this.goChild1.Text = "<<";
            this.goChild1.UseVisualStyleBackColor = true;
            this.goChild1.Click += new System.EventHandler(this.goChild1_Click);
            // 
            // goChild2
            // 
            this.goChild2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goChild2.Location = new System.Drawing.Point(20, 290);
            this.goChild2.Margin = new System.Windows.Forms.Padding(2);
            this.goChild2.Name = "goChild2";
            this.goChild2.Size = new System.Drawing.Size(27, 25);
            this.goChild2.TabIndex = 5;
            this.goChild2.Text = "<<";
            this.goChild2.UseVisualStyleBackColor = true;
            this.goChild2.Click += new System.EventHandler(this.goChild2_Click);
            // 
            // goChild3
            // 
            this.goChild3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goChild3.Location = new System.Drawing.Point(20, 319);
            this.goChild3.Margin = new System.Windows.Forms.Padding(2);
            this.goChild3.Name = "goChild3";
            this.goChild3.Size = new System.Drawing.Size(27, 25);
            this.goChild3.TabIndex = 5;
            this.goChild3.Text = "<<";
            this.goChild3.UseVisualStyleBackColor = true;
            this.goChild3.Click += new System.EventHandler(this.goChild3_Click);
            // 
            // goChild4
            // 
            this.goChild4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goChild4.Location = new System.Drawing.Point(20, 348);
            this.goChild4.Margin = new System.Windows.Forms.Padding(2);
            this.goChild4.Name = "goChild4";
            this.goChild4.Size = new System.Drawing.Size(27, 25);
            this.goChild4.TabIndex = 5;
            this.goChild4.Text = "<<";
            this.goChild4.UseVisualStyleBackColor = true;
            this.goChild4.Click += new System.EventHandler(this.goChild4_Click);
            // 
            // goChild5
            // 
            this.goChild5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goChild5.Location = new System.Drawing.Point(20, 377);
            this.goChild5.Margin = new System.Windows.Forms.Padding(2);
            this.goChild5.Name = "goChild5";
            this.goChild5.Size = new System.Drawing.Size(27, 25);
            this.goChild5.TabIndex = 5;
            this.goChild5.Text = "<<";
            this.goChild5.UseVisualStyleBackColor = true;
            this.goChild5.Click += new System.EventHandler(this.goChild5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(769, 15);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 25);
            this.button6.TabIndex = 5;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(531, 20);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 25);
            this.button7.TabIndex = 5;
            this.button7.Text = ">>";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // goMom
            // 
            this.goMom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goMom.Location = new System.Drawing.Point(311, 12);
            this.goMom.Margin = new System.Windows.Forms.Padding(2);
            this.goMom.Name = "goMom";
            this.goMom.Size = new System.Drawing.Size(27, 25);
            this.goMom.TabIndex = 5;
            this.goMom.Text = ">>";
            this.goMom.UseVisualStyleBackColor = true;
            this.goMom.Click += new System.EventHandler(this.goMom_Click);
            // 
            // goDad
            // 
            this.goDad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goDad.Location = new System.Drawing.Point(96, 12);
            this.goDad.Margin = new System.Windows.Forms.Padding(2);
            this.goDad.Name = "goDad";
            this.goDad.Size = new System.Drawing.Size(27, 25);
            this.goDad.TabIndex = 5;
            this.goDad.Text = ">>";
            this.goDad.UseVisualStyleBackColor = true;
            this.goDad.Click += new System.EventHandler(this.goDad_Click);
            // 
            // Dad
            // 
            this.Dad.BackColor = System.Drawing.Color.White;
            this.Dad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dad.ForeColor = System.Drawing.Color.Black;
            this.Dad.Location = new System.Drawing.Point(20, 50);
            this.Dad.Margin = new System.Windows.Forms.Padding(4);
            this.Dad.Multiline = true;
            this.Dad.Name = "Dad";
            this.Dad.Owner = null;
            this.Dad.ReadOnly = true;
            this.Dad.Selected = false;
            this.Dad.Size = new System.Drawing.Size(189, 45);
            this.Dad.TabIndex = 6;
            this.Dad.TabStop = false;
            this.Dad.Who = null;
            // 
            // Primary
            // 
            this.Primary.BackColor = System.Drawing.Color.White;
            this.Primary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Primary.ForeColor = System.Drawing.Color.Black;
            this.Primary.Location = new System.Drawing.Point(68, 130);
            this.Primary.Margin = new System.Windows.Forms.Padding(4);
            this.Primary.Multiline = true;
            this.Primary.Name = "Primary";
            this.Primary.Owner = null;
            this.Primary.ReadOnly = true;
            this.Primary.Selected = false;
            this.Primary.Size = new System.Drawing.Size(305, 78);
            this.Primary.TabIndex = 7;
            this.Primary.TabStop = false;
            this.Primary.Who = null;
            // 
            // Mom
            // 
            this.Mom.BackColor = System.Drawing.Color.White;
            this.Mom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mom.ForeColor = System.Drawing.Color.Black;
            this.Mom.Location = new System.Drawing.Point(238, 50);
            this.Mom.Margin = new System.Windows.Forms.Padding(4);
            this.Mom.Multiline = true;
            this.Mom.Name = "Mom";
            this.Mom.Owner = null;
            this.Mom.ReadOnly = true;
            this.Mom.Selected = false;
            this.Mom.Size = new System.Drawing.Size(177, 45);
            this.Mom.TabIndex = 8;
            this.Mom.TabStop = false;
            this.Mom.Who = null;
            // 
            // sDad
            // 
            this.sDad.BackColor = System.Drawing.Color.White;
            this.sDad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sDad.ForeColor = System.Drawing.Color.Black;
            this.sDad.Location = new System.Drawing.Point(455, 51);
            this.sDad.Margin = new System.Windows.Forms.Padding(4);
            this.sDad.Multiline = true;
            this.sDad.Name = "sDad";
            this.sDad.Owner = null;
            this.sDad.ReadOnly = true;
            this.sDad.Selected = false;
            this.sDad.Size = new System.Drawing.Size(186, 44);
            this.sDad.TabIndex = 9;
            this.sDad.TabStop = false;
            this.sDad.Who = null;
            // 
            // sMom
            // 
            this.sMom.BackColor = System.Drawing.Color.White;
            this.sMom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sMom.ForeColor = System.Drawing.Color.Black;
            this.sMom.Location = new System.Drawing.Point(687, 51);
            this.sMom.Margin = new System.Windows.Forms.Padding(4);
            this.sMom.Multiline = true;
            this.sMom.Name = "sMom";
            this.sMom.Owner = null;
            this.sMom.ReadOnly = true;
            this.sMom.Selected = false;
            this.sMom.Size = new System.Drawing.Size(181, 44);
            this.sMom.TabIndex = 10;
            this.sMom.TabStop = false;
            this.sMom.Who = null;
            // 
            // Spouse
            // 
            this.Spouse.BackColor = System.Drawing.Color.White;
            this.Spouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Spouse.ForeColor = System.Drawing.Color.Black;
            this.Spouse.Location = new System.Drawing.Point(492, 130);
            this.Spouse.Margin = new System.Windows.Forms.Padding(4);
            this.Spouse.Multiline = true;
            this.Spouse.Name = "Spouse";
            this.Spouse.Owner = null;
            this.Spouse.ReadOnly = true;
            this.Spouse.Selected = false;
            this.Spouse.Size = new System.Drawing.Size(335, 78);
            this.Spouse.TabIndex = 11;
            this.Spouse.TabStop = false;
            this.Spouse.Who = null;
            // 
            // btnMarriages
            // 
            this.btnMarriages.Location = new System.Drawing.Point(68, 216);
            this.btnMarriages.Name = "btnMarriages";
            this.btnMarriages.Size = new System.Drawing.Size(103, 23);
            this.btnMarriages.TabIndex = 12;
            this.btnMarriages.Text = "Marriages ...";
            this.btnMarriages.UseVisualStyleBackColor = true;
            // 
            // View3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 409);
            this.Controls.Add(this.btnMarriages);
            this.Controls.Add(this.Spouse);
            this.Controls.Add(this.sMom);
            this.Controls.Add(this.sDad);
            this.Controls.Add(this.Mom);
            this.Controls.Add(this.Primary);
            this.Controls.Add(this.Dad);
            this.Controls.Add(this.goChild5);
            this.Controls.Add(this.goChild4);
            this.Controls.Add(this.goChild3);
            this.Controls.Add(this.goChild2);
            this.Controls.Add(this.goDad);
            this.Controls.Add(this.goMom);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.goChild1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Marr);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View3";
            this.Text = "View3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Marr;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button goChild1;
        private System.Windows.Forms.Button goChild2;
        private System.Windows.Forms.Button goChild3;
        private System.Windows.Forms.Button goChild4;
        private System.Windows.Forms.Button goChild5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button goMom;
        private System.Windows.Forms.Button goDad;
        private TBox Dad;
        private TBox Primary;
        private TBox Mom;
        private TBox sDad;
        private TBox sMom;
        private TBox Spouse;
        private System.Windows.Forms.Button btnMarriages;
    }
}