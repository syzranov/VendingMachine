namespace VM
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.vmPocketStateControl1 = new VM.Controls.VMPocketStateControl();
            this.userPocketControl1 = new VM.Controls.UserPocketControl();
            this.coinsTabloControl1 = new VM.Controls.CoinsTabloControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vmPocketStateControl1);
            this.panel1.Controls.Add(this.userPocketControl1);
            this.panel1.Controls.Add(this.coinsTabloControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(753, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 741);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ассортимент товаров";
            // 
            // flpMain
            // 
            this.flpMain.AutoScroll = true;
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.Location = new System.Drawing.Point(0, 0);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(753, 741);
            this.flpMain.TabIndex = 38;
            // 
            // vmPocketStateControl1
            // 
            this.vmPocketStateControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.vmPocketStateControl1.Location = new System.Drawing.Point(0, 459);
            this.vmPocketStateControl1.Name = "vmPocketStateControl1";
            this.vmPocketStateControl1.Size = new System.Drawing.Size(309, 292);
            this.vmPocketStateControl1.TabIndex = 14;
            // 
            // userPocketControl1
            // 
            this.userPocketControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.userPocketControl1.Location = new System.Drawing.Point(0, 171);
            this.userPocketControl1.Name = "userPocketControl1";
            this.userPocketControl1.Size = new System.Drawing.Size(309, 288);
            this.userPocketControl1.TabIndex = 13;
            // 
            // coinsTabloControl1
            // 
            this.coinsTabloControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.coinsTabloControl1.Location = new System.Drawing.Point(0, 0);
            this.coinsTabloControl1.Name = "coinsTabloControl1";
            this.coinsTabloControl1.Size = new System.Drawing.Size(309, 171);
            this.coinsTabloControl1.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 741);
            this.Controls.Add(this.flpMain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Виртуальный аппарат по продаже кофе";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private Controls.CoinsTabloControl coinsTabloControl1;
        private Controls.UserPocketControl userPocketControl1;
        private Controls.VMPocketStateControl vmPocketStateControl1;
    }
}

