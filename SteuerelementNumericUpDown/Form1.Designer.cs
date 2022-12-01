namespace SteuerelementNumericUpDown
{
    partial class Form1
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
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.NumZahl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumZahl)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(149, 16);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(53, 15);
            this.LblAnzeige.TabIndex = 3;
            this.LblAnzeige.Text = "Wert: 2,0";
            // 
            // NumZahl
            // 
            this.NumZahl.DecimalPlaces = 1;
            this.NumZahl.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumZahl.Location = new System.Drawing.Point(12, 12);
            this.NumZahl.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumZahl.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.NumZahl.Name = "NumZahl";
            this.NumZahl.Size = new System.Drawing.Size(120, 23);
            this.NumZahl.TabIndex = 2;
            this.NumZahl.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumZahl.ValueChanged += new System.EventHandler(this.NumZahl_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.NumZahl);
            this.Name = "Form1";
            this.Text = "Zahlenauswahlfeld";
            ((System.ComponentModel.ISupportInitialize)(this.NumZahl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblAnzeige;
        private NumericUpDown NumZahl;
    }
}