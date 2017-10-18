namespace VM.Controls
{
    partial class CoinsTabloControl
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTablo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(-1, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Внесенная сумма";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lTablo);
            this.panel1.Location = new System.Drawing.Point(6, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 140);
            this.panel1.TabIndex = 14;
            // 
            // lTablo
            // 
            this.lTablo.AutoSize = true;
            this.lTablo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lTablo.Font = new System.Drawing.Font("Segoe UI Semibold", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTablo.ForeColor = System.Drawing.Color.White;
            this.lTablo.Location = new System.Drawing.Point(0, -19);
            this.lTablo.Name = "lTablo";
            this.lTablo.Size = new System.Drawing.Size(134, 159);
            this.lTablo.TabIndex = 14;
            this.lTablo.Text = "0";
            this.lTablo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CoinsTabloControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Name = "CoinsTabloControl";
            this.Size = new System.Drawing.Size(310, 183);
            this.Load += new System.EventHandler(this.CoinsTabloControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lTablo;
    }
}
