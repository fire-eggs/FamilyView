namespace FamilyView
{
    partial class View1
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
            this.Marr = new System.Windows.Forms.TextBox();
            this.goDad = new System.Windows.Forms.Button();
            this.goMom = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goChild1 = new System.Windows.Forms.Button();
            this.goChild2 = new System.Windows.Forms.Button();
            this.goChild3 = new System.Windows.Forms.Button();
            this.goChild4 = new System.Windows.Forms.Button();
            this.goChild5 = new System.Windows.Forms.Button();
            this.Primary = new FamilyView.TBox();
            this.Spouse = new FamilyView.TBox();
            this.Dad = new FamilyView.TBox();
            this.Mom = new FamilyView.TBox();
            this.btnMarriages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Marr
            // 
            this.Marr.BackColor = System.Drawing.SystemColors.Window;
            this.Marr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Marr.Location = new System.Drawing.Point(157, 182);
            this.Marr.Margin = new System.Windows.Forms.Padding(4);
            this.Marr.Name = "Marr";
            this.Marr.ReadOnly = true;
            this.Marr.Size = new System.Drawing.Size(266, 22);
            this.Marr.TabIndex = 2;
            this.Marr.TabStop = false;
            this.Marr.Text = "Marriage:";
            // 
            // goDad
            // 
            this.goDad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goDad.Location = new System.Drawing.Point(865, 58);
            this.goDad.Margin = new System.Windows.Forms.Padding(2);
            this.goDad.Name = "goDad";
            this.goDad.Size = new System.Drawing.Size(27, 25);
            this.goDad.TabIndex = 12;
            this.goDad.Text = ">>";
            this.goDad.UseVisualStyleBackColor = true;
            this.goDad.Click += new System.EventHandler(this.goDad_Click);
            // 
            // goMom
            // 
            this.goMom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goMom.Location = new System.Drawing.Point(860, 154);
            this.goMom.Margin = new System.Windows.Forms.Padding(2);
            this.goMom.Name = "goMom";
            this.goMom.Size = new System.Drawing.Size(27, 25);
            this.goMom.TabIndex = 13;
            this.goMom.Text = ">>";
            this.goMom.UseVisualStyleBackColor = true;
            this.goMom.Click += new System.EventHandler(this.goMom_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(73, 345);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(781, 132);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spouse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Children";
            // 
            // goChild1
            // 
            this.goChild1.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.goChild1.Location = new System.Drawing.Point(34, 345);
            this.goChild1.Margin = new System.Windows.Forms.Padding(2);
            this.goChild1.Name = "goChild1";
            this.goChild1.Size = new System.Drawing.Size(27, 25);
            this.goChild1.TabIndex = 7;
            this.goChild1.Text = "v";
            this.goChild1.UseVisualStyleBackColor = true;
            this.goChild1.Click += new System.EventHandler(this.goChild1_Click);
            // 
            // goChild2
            // 
            this.goChild2.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.goChild2.Location = new System.Drawing.Point(34, 374);
            this.goChild2.Margin = new System.Windows.Forms.Padding(2);
            this.goChild2.Name = "goChild2";
            this.goChild2.Size = new System.Drawing.Size(27, 25);
            this.goChild2.TabIndex = 8;
            this.goChild2.Text = "t";
            this.goChild2.UseVisualStyleBackColor = true;
            this.goChild2.Click += new System.EventHandler(this.goChild2_Click);
            // 
            // goChild3
            // 
            this.goChild3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goChild3.Location = new System.Drawing.Point(34, 403);
            this.goChild3.Margin = new System.Windows.Forms.Padding(2);
            this.goChild3.Name = "goChild3";
            this.goChild3.Size = new System.Drawing.Size(27, 25);
            this.goChild3.TabIndex = 9;
            this.goChild3.Text = "<<";
            this.goChild3.UseVisualStyleBackColor = true;
            this.goChild3.Click += new System.EventHandler(this.goChild3_Click);
            // 
            // goChild4
            // 
            this.goChild4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goChild4.Location = new System.Drawing.Point(34, 432);
            this.goChild4.Margin = new System.Windows.Forms.Padding(2);
            this.goChild4.Name = "goChild4";
            this.goChild4.Size = new System.Drawing.Size(27, 25);
            this.goChild4.TabIndex = 10;
            this.goChild4.Text = "<<";
            this.goChild4.UseVisualStyleBackColor = true;
            this.goChild4.Click += new System.EventHandler(this.goChild4_Click);
            // 
            // goChild5
            // 
            this.goChild5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goChild5.Location = new System.Drawing.Point(34, 461);
            this.goChild5.Margin = new System.Windows.Forms.Padding(2);
            this.goChild5.Name = "goChild5";
            this.goChild5.Size = new System.Drawing.Size(27, 25);
            this.goChild5.TabIndex = 11;
            this.goChild5.Text = "<<";
            this.goChild5.UseVisualStyleBackColor = true;
            this.goChild5.Click += new System.EventHandler(this.goChild5_Click);
            // 
            // Primary
            // 
            this.Primary.BackColor = System.Drawing.Color.White;
            this.Primary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Primary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Primary.ForeColor = System.Drawing.Color.Black;
            this.Primary.Location = new System.Drawing.Point(73, 76);
            this.Primary.Margin = new System.Windows.Forms.Padding(4);
            this.Primary.Multiline = true;
            this.Primary.Name = "Primary";
            this.Primary.Owner = null;
            this.Primary.ReadOnly = true;
            this.Primary.Selected = false;
            this.Primary.Size = new System.Drawing.Size(349, 80);
            this.Primary.TabIndex = 16;
            this.Primary.TabStop = false;
            this.Primary.Who = null;
            // 
            // Spouse
            // 
            this.Spouse.BackColor = System.Drawing.Color.White;
            this.Spouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Spouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spouse.ForeColor = System.Drawing.Color.Black;
            this.Spouse.Location = new System.Drawing.Point(74, 236);
            this.Spouse.Margin = new System.Windows.Forms.Padding(4);
            this.Spouse.Multiline = true;
            this.Spouse.Name = "Spouse";
            this.Spouse.Owner = null;
            this.Spouse.ReadOnly = true;
            this.Spouse.Selected = false;
            this.Spouse.Size = new System.Drawing.Size(349, 80);
            this.Spouse.TabIndex = 17;
            this.Spouse.TabStop = false;
            this.Spouse.Who = null;
            // 
            // Dad
            // 
            this.Dad.BackColor = System.Drawing.Color.White;
            this.Dad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dad.ForeColor = System.Drawing.Color.Black;
            this.Dad.Location = new System.Drawing.Point(505, 32);
            this.Dad.Margin = new System.Windows.Forms.Padding(4);
            this.Dad.Multiline = true;
            this.Dad.Name = "Dad";
            this.Dad.Owner = null;
            this.Dad.ReadOnly = true;
            this.Dad.Selected = false;
            this.Dad.Size = new System.Drawing.Size(349, 75);
            this.Dad.TabIndex = 18;
            this.Dad.TabStop = false;
            this.Dad.Who = null;
            // 
            // Mom
            // 
            this.Mom.BackColor = System.Drawing.Color.White;
            this.Mom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mom.ForeColor = System.Drawing.Color.Black;
            this.Mom.Location = new System.Drawing.Point(505, 129);
            this.Mom.Margin = new System.Windows.Forms.Padding(4);
            this.Mom.Multiline = true;
            this.Mom.Name = "Mom";
            this.Mom.Owner = null;
            this.Mom.ReadOnly = true;
            this.Mom.Selected = false;
            this.Mom.Size = new System.Drawing.Size(349, 75);
            this.Mom.TabIndex = 19;
            this.Mom.TabStop = false;
            this.Mom.Who = null;
            // 
            // btnMarriages
            // 
            this.btnMarriages.Location = new System.Drawing.Point(310, 46);
            this.btnMarriages.Name = "btnMarriages";
            this.btnMarriages.Size = new System.Drawing.Size(112, 23);
            this.btnMarriages.TabIndex = 20;
            this.btnMarriages.Text = "Marriages...";
            this.btnMarriages.UseVisualStyleBackColor = true;
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 497);
            this.Controls.Add(this.btnMarriages);
            this.Controls.Add(this.Mom);
            this.Controls.Add(this.Dad);
            this.Controls.Add(this.Spouse);
            this.Controls.Add(this.Primary);
            this.Controls.Add(this.goChild5);
            this.Controls.Add(this.goChild4);
            this.Controls.Add(this.goChild3);
            this.Controls.Add(this.goChild2);
            this.Controls.Add(this.goChild1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.goMom);
            this.Controls.Add(this.goDad);
            this.Controls.Add(this.Marr);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View1";
            this.Text = "Variant 1 (PAF)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Marr;
        private System.Windows.Forms.Button goDad;
        private System.Windows.Forms.Button goMom;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button goChild1;
        private System.Windows.Forms.Button goChild2;
        private System.Windows.Forms.Button goChild3;
        private System.Windows.Forms.Button goChild4;
        private System.Windows.Forms.Button goChild5;
        private TBox Primary;
        private TBox Spouse;
        private TBox Dad;
        private TBox Mom;
        private System.Windows.Forms.Button btnMarriages;
    }
}