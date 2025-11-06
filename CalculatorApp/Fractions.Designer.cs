namespace CalculatorApp
{
    partial class Fraction
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
            FInt = new TextBox();
            FNum = new TextBox();
            FDen = new TextBox();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            bce = new Button();
            n0 = new Button();
            bac = new Button();
            bnext = new Button();
            badd = new Button();
            bsub = new Button();
            bmult = new Button();
            bdiv = new Button();
            bequal = new Button();
            SuspendLayout();
            // 
            // FInt
            // 
            FInt.BackColor = Color.FromArgb(220, 255, 255);
            FInt.Font = new Font("Modern No. 20", 71.99999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FInt.ForeColor = Color.Lime;
            FInt.Location = new Point(7, 12);
            FInt.Name = "FInt";
            FInt.ReadOnly = true;
            FInt.Size = new Size(311, 110);
            FInt.TabIndex = 0;
            FInt.Text = "0";
            FInt.TextAlign = HorizontalAlignment.Right;
            // 
            // FNum
            // 
            FNum.BackColor = Color.FromArgb(220, 255, 255);
            FNum.Font = new Font("Modern No. 20", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FNum.ForeColor = Color.Lime;
            FNum.Location = new Point(330, 12);
            FNum.Name = "FNum";
            FNum.ReadOnly = true;
            FNum.Size = new Size(257, 47);
            FNum.TabIndex = 1;
            FNum.Text = "0";
            FNum.TextAlign = HorizontalAlignment.Right;
            // 
            // FDen
            // 
            FDen.BackColor = Color.FromArgb(220, 255, 255);
            FDen.Font = new Font("Modern No. 20", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FDen.ForeColor = Color.Lime;
            FDen.Location = new Point(330, 75);
            FDen.Name = "FDen";
            FDen.ReadOnly = true;
            FDen.Size = new Size(257, 47);
            FDen.TabIndex = 1;
            FDen.Text = "0";
            FDen.TextAlign = HorizontalAlignment.Right;
            // 
            // n1
            // 
            n1.BackColor = Color.FromArgb(50, 50, 50);
            n1.FlatStyle = FlatStyle.Popup;
            n1.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n1.ForeColor = Color.Lime;
            n1.Location = new Point(6, 136);
            n1.Name = "n1";
            n1.Size = new Size(100, 100);
            n1.TabIndex = 2;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = false;
            n1.Click += n1_Click;
            // 
            // n2
            // 
            n2.BackColor = Color.FromArgb(50, 50, 50);
            n2.FlatStyle = FlatStyle.Popup;
            n2.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n2.ForeColor = Color.Lime;
            n2.Location = new Point(112, 136);
            n2.Name = "n2";
            n2.Size = new Size(100, 100);
            n2.TabIndex = 2;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = false;
            n2.Click += n2_Click;
            // 
            // n3
            // 
            n3.BackColor = Color.FromArgb(50, 50, 50);
            n3.FlatStyle = FlatStyle.Popup;
            n3.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n3.ForeColor = Color.Lime;
            n3.Location = new Point(218, 136);
            n3.Name = "n3";
            n3.Size = new Size(100, 100);
            n3.TabIndex = 2;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = false;
            n3.Click += n3_Click;
            // 
            // n4
            // 
            n4.BackColor = Color.FromArgb(50, 50, 50);
            n4.FlatStyle = FlatStyle.Popup;
            n4.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n4.ForeColor = Color.Lime;
            n4.Location = new Point(6, 242);
            n4.Name = "n4";
            n4.Size = new Size(100, 100);
            n4.TabIndex = 2;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = false;
            n4.Click += n4_Click;
            // 
            // n5
            // 
            n5.BackColor = Color.FromArgb(50, 50, 50);
            n5.FlatStyle = FlatStyle.Popup;
            n5.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n5.ForeColor = Color.Lime;
            n5.Location = new Point(112, 242);
            n5.Name = "n5";
            n5.Size = new Size(100, 100);
            n5.TabIndex = 2;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = false;
            n5.Click += n5_Click;
            // 
            // n6
            // 
            n6.BackColor = Color.FromArgb(50, 50, 50);
            n6.FlatStyle = FlatStyle.Popup;
            n6.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n6.ForeColor = Color.Lime;
            n6.Location = new Point(218, 242);
            n6.Name = "n6";
            n6.Size = new Size(100, 100);
            n6.TabIndex = 2;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = false;
            n6.Click += n6_Click;
            // 
            // n7
            // 
            n7.BackColor = Color.FromArgb(50, 50, 50);
            n7.FlatStyle = FlatStyle.Popup;
            n7.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n7.ForeColor = Color.Lime;
            n7.Location = new Point(6, 348);
            n7.Name = "n7";
            n7.Size = new Size(100, 100);
            n7.TabIndex = 2;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = false;
            n7.Click += n7_Click;
            // 
            // n8
            // 
            n8.BackColor = Color.FromArgb(50, 50, 50);
            n8.FlatStyle = FlatStyle.Popup;
            n8.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n8.ForeColor = Color.Lime;
            n8.Location = new Point(112, 348);
            n8.Name = "n8";
            n8.Size = new Size(100, 100);
            n8.TabIndex = 2;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = false;
            n8.Click += n8_Click;
            // 
            // n9
            // 
            n9.BackColor = Color.FromArgb(50, 50, 50);
            n9.FlatStyle = FlatStyle.Popup;
            n9.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n9.ForeColor = Color.Lime;
            n9.Location = new Point(218, 348);
            n9.Name = "n9";
            n9.Size = new Size(100, 100);
            n9.TabIndex = 2;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = false;
            n9.Click += n9_Click;
            // 
            // bce
            // 
            bce.BackColor = Color.FromArgb(50, 50, 50);
            bce.FlatStyle = FlatStyle.Popup;
            bce.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bce.ForeColor = Color.Lime;
            bce.Location = new Point(6, 454);
            bce.Name = "bce";
            bce.Size = new Size(100, 100);
            bce.TabIndex = 2;
            bce.Text = "CE";
            bce.UseVisualStyleBackColor = false;
            bce.Click += bce_Click;
            // 
            // n0
            // 
            n0.BackColor = Color.FromArgb(50, 50, 50);
            n0.FlatStyle = FlatStyle.Popup;
            n0.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n0.ForeColor = Color.Lime;
            n0.Location = new Point(112, 454);
            n0.Name = "n0";
            n0.Size = new Size(100, 100);
            n0.TabIndex = 2;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = false;
            n0.Click += n0_Click;
            // 
            // bac
            // 
            bac.BackColor = Color.FromArgb(50, 50, 50);
            bac.FlatStyle = FlatStyle.Popup;
            bac.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bac.ForeColor = Color.Lime;
            bac.Location = new Point(218, 454);
            bac.Name = "bac";
            bac.Size = new Size(100, 100);
            bac.TabIndex = 2;
            bac.Text = "AC";
            bac.UseVisualStyleBackColor = false;
            bac.Click += bac_Click;
            // 
            // bnext
            // 
            bnext.BackColor = Color.FromArgb(80, 80, 80);
            bnext.FlatStyle = FlatStyle.Popup;
            bnext.Font = new Font("Modern No. 20", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bnext.ForeColor = Color.Lime;
            bnext.Location = new Point(330, 136);
            bnext.Name = "bnext";
            bnext.Size = new Size(257, 100);
            bnext.TabIndex = 3;
            bnext.Text = "Next number";
            bnext.UseVisualStyleBackColor = false;
            bnext.Click += bnext_Click;
            // 
            // badd
            // 
            badd.BackColor = Color.FromArgb(80, 80, 80);
            badd.FlatStyle = FlatStyle.Popup;
            badd.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            badd.ForeColor = Color.Lime;
            badd.Location = new Point(6, 560);
            badd.Name = "badd";
            badd.Size = new Size(100, 100);
            badd.TabIndex = 4;
            badd.Text = "+";
            badd.TextAlign = ContentAlignment.TopCenter;
            badd.UseVisualStyleBackColor = false;
            badd.Click += badd_Click;
            // 
            // bsub
            // 
            bsub.BackColor = Color.FromArgb(80, 80, 80);
            bsub.FlatStyle = FlatStyle.Popup;
            bsub.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bsub.ForeColor = Color.Lime;
            bsub.Location = new Point(112, 560);
            bsub.Name = "bsub";
            bsub.Size = new Size(100, 100);
            bsub.TabIndex = 4;
            bsub.Text = "-";
            bsub.UseVisualStyleBackColor = false;
            bsub.Click += bsub_Click;
            // 
            // bmult
            // 
            bmult.BackColor = Color.FromArgb(80, 80, 80);
            bmult.FlatStyle = FlatStyle.Popup;
            bmult.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bmult.ForeColor = Color.Lime;
            bmult.Location = new Point(6, 666);
            bmult.Name = "bmult";
            bmult.Size = new Size(100, 100);
            bmult.TabIndex = 4;
            bmult.Text = "x";
            bmult.UseVisualStyleBackColor = false;
            bmult.Click += bmult_Click;
            // 
            // bdiv
            // 
            bdiv.BackColor = Color.FromArgb(80, 80, 80);
            bdiv.FlatStyle = FlatStyle.Popup;
            bdiv.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdiv.ForeColor = Color.Lime;
            bdiv.Location = new Point(112, 666);
            bdiv.Name = "bdiv";
            bdiv.Size = new Size(100, 100);
            bdiv.TabIndex = 4;
            bdiv.Text = "/";
            bdiv.UseVisualStyleBackColor = false;
            bdiv.Click += bdiv_Click;
            // 
            // bequal
            // 
            bequal.BackColor = Color.FromArgb(80, 80, 80);
            bequal.FlatStyle = FlatStyle.Popup;
            bequal.Font = new Font("Modern No. 20", 71.99999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bequal.ForeColor = Color.Lime;
            bequal.Location = new Point(218, 560);
            bequal.Name = "bequal";
            bequal.Size = new Size(100, 206);
            bequal.TabIndex = 4;
            bequal.Text = "=";
            bequal.UseVisualStyleBackColor = false;
            bequal.Click += bequal_Click;
            // 
            // Fraction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(599, 846);
            Controls.Add(bequal);
            Controls.Add(bdiv);
            Controls.Add(bmult);
            Controls.Add(bsub);
            Controls.Add(badd);
            Controls.Add(bnext);
            Controls.Add(bac);
            Controls.Add(n0);
            Controls.Add(bce);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(FDen);
            Controls.Add(FNum);
            Controls.Add(FInt);
            Name = "Fraction";
            Text = "Fraction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FInt;
        private TextBox FNum;
        private TextBox FDen;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button n7;
        private Button n8;
        private Button n9;
        private Button bce;
        private Button n0;
        private Button bac;
        private Button bnext;
        private Button badd;
        private Button bsub;
        private Button bmult;
        private Button bdiv;
        private Button bequal;
    }
}