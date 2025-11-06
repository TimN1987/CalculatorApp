namespace CalculatorApp
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            screen = new TextBox();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n4 = new Button();
            n7 = new Button();
            n5 = new Button();
            n6 = new Button();
            n8 = new Button();
            n9 = new Button();
            n0 = new Button();
            bc = new Button();
            bdp = new Button();
            badd = new Button();
            bsub = new Button();
            bmult = new Button();
            bdiv = new Button();
            bpn = new Button();
            bac = new Button();
            bequal = new Button();
            Signature = new TextBox();
            bsci = new Button();
            bprime = new Button();
            bfrac = new Button();
            bquad = new Button();
            SuspendLayout();
            // 
            // screen
            // 
            screen.Font = new Font("Lucida Console", 36F);
            screen.Location = new Point(12, 15);
            screen.Margin = new Padding(6);
            screen.Name = "screen";
            screen.ReadOnly = true;
            screen.Size = new Size(573, 55);
            screen.TabIndex = 0;
            screen.Text = "0";
            screen.TextAlign = HorizontalAlignment.Right;
            // 
            // n1
            // 
            n1.BackColor = Color.FromArgb(192, 255, 255);
            n1.FlatStyle = FlatStyle.Popup;
            n1.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n1.ForeColor = Color.Fuchsia;
            n1.Location = new Point(12, 282);
            n1.Name = "n1";
            n1.Size = new Size(125, 125);
            n1.TabIndex = 1;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = false;
            n1.Click += n1_Click;
            // 
            // n2
            // 
            n2.BackColor = Color.FromArgb(192, 255, 255);
            n2.FlatStyle = FlatStyle.Popup;
            n2.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n2.ForeColor = Color.Fuchsia;
            n2.Location = new Point(164, 282);
            n2.Name = "n2";
            n2.Size = new Size(125, 125);
            n2.TabIndex = 2;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = false;
            n2.Click += n2_Click;
            // 
            // n3
            // 
            n3.BackColor = Color.FromArgb(192, 255, 255);
            n3.FlatStyle = FlatStyle.Popup;
            n3.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n3.ForeColor = Color.Fuchsia;
            n3.Location = new Point(316, 282);
            n3.Name = "n3";
            n3.Size = new Size(125, 125);
            n3.TabIndex = 3;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = false;
            n3.Click += n3_Click;
            // 
            // n4
            // 
            n4.BackColor = Color.FromArgb(192, 255, 255);
            n4.FlatStyle = FlatStyle.Popup;
            n4.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n4.ForeColor = Color.Fuchsia;
            n4.Location = new Point(12, 413);
            n4.Name = "n4";
            n4.Size = new Size(125, 125);
            n4.TabIndex = 4;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = false;
            n4.Click += n4_Click;
            // 
            // n7
            // 
            n7.BackColor = Color.FromArgb(192, 255, 255);
            n7.FlatStyle = FlatStyle.Popup;
            n7.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n7.ForeColor = Color.Fuchsia;
            n7.Location = new Point(12, 544);
            n7.Name = "n7";
            n7.Size = new Size(125, 125);
            n7.TabIndex = 5;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = false;
            n7.Click += n7_Click;
            // 
            // n5
            // 
            n5.BackColor = Color.FromArgb(192, 255, 255);
            n5.FlatStyle = FlatStyle.Popup;
            n5.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n5.ForeColor = Color.Fuchsia;
            n5.Location = new Point(164, 413);
            n5.Name = "n5";
            n5.Size = new Size(125, 125);
            n5.TabIndex = 6;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = false;
            n5.Click += n5_Click;
            // 
            // n6
            // 
            n6.BackColor = Color.FromArgb(192, 255, 255);
            n6.FlatStyle = FlatStyle.Popup;
            n6.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n6.ForeColor = Color.Fuchsia;
            n6.Location = new Point(316, 413);
            n6.Name = "n6";
            n6.Size = new Size(125, 125);
            n6.TabIndex = 7;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = false;
            n6.Click += n6_Click;
            // 
            // n8
            // 
            n8.BackColor = Color.FromArgb(192, 255, 255);
            n8.FlatStyle = FlatStyle.Popup;
            n8.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n8.ForeColor = Color.Fuchsia;
            n8.Location = new Point(164, 544);
            n8.Name = "n8";
            n8.Size = new Size(125, 125);
            n8.TabIndex = 8;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = false;
            n8.Click += n8_Click;
            // 
            // n9
            // 
            n9.BackColor = Color.FromArgb(192, 255, 255);
            n9.FlatStyle = FlatStyle.Popup;
            n9.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n9.ForeColor = Color.Fuchsia;
            n9.Location = new Point(316, 544);
            n9.Name = "n9";
            n9.Size = new Size(125, 125);
            n9.TabIndex = 9;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = false;
            n9.Click += n9_Click;
            // 
            // n0
            // 
            n0.BackColor = Color.FromArgb(192, 255, 255);
            n0.FlatStyle = FlatStyle.Popup;
            n0.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            n0.ForeColor = Color.Fuchsia;
            n0.Location = new Point(164, 675);
            n0.Name = "n0";
            n0.Size = new Size(125, 125);
            n0.TabIndex = 10;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = false;
            n0.Click += n0_Click;
            // 
            // bc
            // 
            bc.BackColor = Color.FromArgb(192, 255, 255);
            bc.FlatStyle = FlatStyle.Popup;
            bc.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bc.ForeColor = Color.Fuchsia;
            bc.Location = new Point(460, 544);
            bc.Name = "bc";
            bc.Size = new Size(125, 125);
            bc.TabIndex = 1;
            bc.Text = "C";
            bc.UseVisualStyleBackColor = false;
            bc.Click += bc_Click;
            // 
            // bdp
            // 
            bdp.BackColor = Color.FromArgb(192, 255, 255);
            bdp.FlatStyle = FlatStyle.Popup;
            bdp.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdp.ForeColor = Color.Fuchsia;
            bdp.Location = new Point(12, 675);
            bdp.Name = "bdp";
            bdp.Size = new Size(125, 125);
            bdp.TabIndex = 1;
            bdp.Text = ".";
            bdp.UseVisualStyleBackColor = false;
            bdp.Click += bdp_Click;
            // 
            // badd
            // 
            badd.BackColor = Color.FromArgb(192, 255, 255);
            badd.FlatStyle = FlatStyle.Popup;
            badd.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            badd.ForeColor = Color.Fuchsia;
            badd.Location = new Point(12, 151);
            badd.Name = "badd";
            badd.Size = new Size(125, 125);
            badd.TabIndex = 1;
            badd.Text = "+";
            badd.UseVisualStyleBackColor = false;
            badd.Click += badd_Click;
            // 
            // bsub
            // 
            bsub.BackColor = Color.FromArgb(192, 255, 255);
            bsub.FlatStyle = FlatStyle.Popup;
            bsub.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bsub.ForeColor = Color.Fuchsia;
            bsub.Location = new Point(164, 151);
            bsub.Name = "bsub";
            bsub.Size = new Size(125, 125);
            bsub.TabIndex = 1;
            bsub.Text = "-";
            bsub.UseVisualStyleBackColor = false;
            bsub.Click += bsub_Click;
            // 
            // bmult
            // 
            bmult.BackColor = Color.FromArgb(192, 255, 255);
            bmult.FlatStyle = FlatStyle.Popup;
            bmult.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bmult.ForeColor = Color.Fuchsia;
            bmult.Location = new Point(316, 151);
            bmult.Name = "bmult";
            bmult.Size = new Size(125, 125);
            bmult.TabIndex = 1;
            bmult.Text = "x";
            bmult.UseVisualStyleBackColor = false;
            bmult.Click += bmult_Click;
            // 
            // bdiv
            // 
            bdiv.BackColor = Color.FromArgb(192, 255, 255);
            bdiv.FlatStyle = FlatStyle.Popup;
            bdiv.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdiv.ForeColor = Color.Fuchsia;
            bdiv.Location = new Point(460, 151);
            bdiv.Name = "bdiv";
            bdiv.Size = new Size(125, 125);
            bdiv.TabIndex = 1;
            bdiv.Text = "/";
            bdiv.UseVisualStyleBackColor = false;
            bdiv.Click += bdiv_Click;
            // 
            // bpn
            // 
            bpn.BackColor = Color.FromArgb(192, 255, 255);
            bpn.FlatStyle = FlatStyle.Popup;
            bpn.Font = new Font("Showcard Gothic", 36F);
            bpn.ForeColor = Color.Fuchsia;
            bpn.Location = new Point(316, 675);
            bpn.Name = "bpn";
            bpn.Size = new Size(125, 125);
            bpn.TabIndex = 1;
            bpn.Text = "+/-";
            bpn.UseVisualStyleBackColor = false;
            bpn.Click += bpn_Click;
            // 
            // bac
            // 
            bac.BackColor = Color.FromArgb(192, 255, 255);
            bac.FlatStyle = FlatStyle.Popup;
            bac.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bac.ForeColor = Color.Fuchsia;
            bac.Location = new Point(460, 675);
            bac.Name = "bac";
            bac.Size = new Size(125, 125);
            bac.TabIndex = 1;
            bac.Text = "AC";
            bac.UseVisualStyleBackColor = false;
            bac.Click += bac_Click;
            // 
            // bequal
            // 
            bequal.BackColor = Color.FromArgb(192, 255, 255);
            bequal.FlatStyle = FlatStyle.Popup;
            bequal.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bequal.ForeColor = Color.Fuchsia;
            bequal.Location = new Point(460, 282);
            bequal.Name = "bequal";
            bequal.Size = new Size(125, 256);
            bequal.TabIndex = 1;
            bequal.Text = "=";
            bequal.UseVisualStyleBackColor = false;
            bequal.Click += bequal_Click;
            // 
            // Signature
            // 
            Signature.BackColor = Color.Fuchsia;
            Signature.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Signature.ForeColor = Color.FromArgb(192, 255, 255);
            Signature.Location = new Point(12, 806);
            Signature.Name = "Signature";
            Signature.ReadOnly = true;
            Signature.Size = new Size(576, 37);
            Signature.TabIndex = 11;
            Signature.Text = "A simple calculator - Created by Daddy ";
            Signature.TextAlign = HorizontalAlignment.Center;
            // 
            // bsci
            // 
            bsci.BackColor = Color.DodgerBlue;
            bsci.FlatStyle = FlatStyle.Popup;
            bsci.Font = new Font("Showcard Gothic", 24F);
            bsci.ForeColor = Color.LightPink;
            bsci.Location = new Point(12, 79);
            bsci.Name = "bsci";
            bsci.Size = new Size(125, 65);
            bsci.TabIndex = 1;
            bsci.Text = "Sci";
            bsci.UseVisualStyleBackColor = false;
            bsci.Click += bsci_Click;
            // 
            // bprime
            // 
            bprime.BackColor = Color.DodgerBlue;
            bprime.FlatStyle = FlatStyle.Popup;
            bprime.Font = new Font("Showcard Gothic", 24F);
            bprime.ForeColor = Color.LightPink;
            bprime.Location = new Point(164, 79);
            bprime.Name = "bprime";
            bprime.Size = new Size(125, 65);
            bprime.TabIndex = 1;
            bprime.Text = "Prime";
            bprime.UseVisualStyleBackColor = false;
            bprime.Click += bprime_Click;
            // 
            // bfrac
            // 
            bfrac.BackColor = Color.DodgerBlue;
            bfrac.FlatStyle = FlatStyle.Popup;
            bfrac.Font = new Font("Showcard Gothic", 24F);
            bfrac.ForeColor = Color.LightPink;
            bfrac.Location = new Point(316, 80);
            bfrac.Name = "bfrac";
            bfrac.Size = new Size(125, 65);
            bfrac.TabIndex = 1;
            bfrac.Text = "Frac";
            bfrac.UseVisualStyleBackColor = false;
            bfrac.Click += bfrac_Click;
            // 
            // bquad
            // 
            bquad.BackColor = Color.DodgerBlue;
            bquad.FlatStyle = FlatStyle.Popup;
            bquad.Font = new Font("Showcard Gothic", 24F);
            bquad.ForeColor = Color.LightPink;
            bquad.Location = new Point(460, 79);
            bquad.Name = "bquad";
            bquad.Size = new Size(125, 65);
            bquad.TabIndex = 1;
            bquad.Text = "Quad";
            bquad.UseVisualStyleBackColor = false;
            bquad.Click += bquad_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 240, 255);
            ClientSize = new Size(599, 846);
            Controls.Add(Signature);
            Controls.Add(n0);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n7);
            Controls.Add(n4);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(bdp);
            Controls.Add(bequal);
            Controls.Add(bdiv);
            Controls.Add(bmult);
            Controls.Add(bsub);
            Controls.Add(bquad);
            Controls.Add(bfrac);
            Controls.Add(bprime);
            Controls.Add(bsci);
            Controls.Add(badd);
            Controls.Add(bac);
            Controls.Add(bpn);
            Controls.Add(bc);
            Controls.Add(n1);
            Controls.Add(screen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox screen;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n4;
        private Button n7;
        private Button n5;
        private Button n6;
        private Button n8;
        private Button n9;
        private Button n0;
        private Button bc;
        private Button bdp;
        private Button badd;
        private Button bsub;
        private Button bmult;
        private Button bdiv;
        private Button bpn;
        private Button bac;
        private Button bequal;
        private TextBox Signature;
        private Button bsci;
        private Button bprime;
        private Button bfrac;
        private Button bquad;
    }
}
