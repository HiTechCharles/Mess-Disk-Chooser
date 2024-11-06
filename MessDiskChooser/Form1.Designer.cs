namespace MessDiskChooser
{
    partial class Form1
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
            this.Disk1BTN = new System.Windows.Forms.Button();
            this.Disk2BTN = new System.Windows.Forms.Button();
            this.Disk1TB = new System.Windows.Forms.TextBox();
            this.Disk2TB = new System.Windows.Forms.TextBox();
            this.Disk1OpenDLG = new System.Windows.Forms.OpenFileDialog();
            this.Disk2OpenDLG = new System.Windows.Forms.OpenFileDialog();
            this.StatusTB = new System.Windows.Forms.TextBox();
            this.StartBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Disk1BTN
            // 
            this.Disk1BTN.AutoSize = true;
            this.Disk1BTN.BackColor = System.Drawing.Color.Black;
            this.Disk1BTN.ForeColor = System.Drawing.Color.Yellow;
            this.Disk1BTN.Location = new System.Drawing.Point(22, 12);
            this.Disk1BTN.Name = "Disk1BTN";
            this.Disk1BTN.Size = new System.Drawing.Size(134, 92);
            this.Disk1BTN.TabIndex = 0;
            this.Disk1BTN.Text = "Disk &1";
            this.Disk1BTN.UseVisualStyleBackColor = false;
            this.Disk1BTN.Click += new System.EventHandler(this.Disk1BTN_Click);
            // 
            // Disk2BTN
            // 
            this.Disk2BTN.AutoSize = true;
            this.Disk2BTN.BackColor = System.Drawing.Color.Black;
            this.Disk2BTN.ForeColor = System.Drawing.Color.Yellow;
            this.Disk2BTN.Location = new System.Drawing.Point(22, 145);
            this.Disk2BTN.Name = "Disk2BTN";
            this.Disk2BTN.Size = new System.Drawing.Size(134, 92);
            this.Disk2BTN.TabIndex = 1;
            this.Disk2BTN.Text = "Disk &2";
            this.Disk2BTN.UseVisualStyleBackColor = false;
            this.Disk2BTN.Click += new System.EventHandler(this.Disk2BTN_Click);
            // 
            // Disk1TB
            // 
            this.Disk1TB.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Disk1TB.Location = new System.Drawing.Point(192, 12);
            this.Disk1TB.Multiline = true;
            this.Disk1TB.Name = "Disk1TB";
            this.Disk1TB.Size = new System.Drawing.Size(515, 92);
            this.Disk1TB.TabIndex = 2;
            // 
            // Disk2TB
            // 
            this.Disk2TB.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.Disk2TB.Location = new System.Drawing.Point(192, 145);
            this.Disk2TB.Multiline = true;
            this.Disk2TB.Name = "Disk2TB";
            this.Disk2TB.Size = new System.Drawing.Size(515, 92);
            this.Disk2TB.TabIndex = 3;
            // 
            // Disk1OpenDLG
            // 
            this.Disk1OpenDLG.FileName = "openFileDialog1";
            this.Disk1OpenDLG.Filter = "ProDos Order (*.po)|*.po|Disk Image(*.dsk)|*.dsk\"";
            this.Disk1OpenDLG.Title = "Select a disk image for drive 2";
            // 
            // Disk2OpenDLG
            // 
            this.Disk2OpenDLG.FileName = "openFileDialog1";
            this.Disk2OpenDLG.Filter = "ProDos Order (*.po)|*.po|Disk Image(*.dsk)|*.dsk\"";
            this.Disk2OpenDLG.Title = "Select a disk image for drive 2";
            // 
            // StatusTB
            // 
            this.StatusTB.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.StatusTB.Location = new System.Drawing.Point(192, 277);
            this.StatusTB.Multiline = true;
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.Size = new System.Drawing.Size(515, 92);
            this.StatusTB.TabIndex = 5;
            this.StatusTB.Text = "Choose Disk images for the MESS Apple II emulator.  Disk 1 is required, disk 2 is" +
    " optional.  Click to boot up!";
            // 
            // StartBTN
            // 
            this.StartBTN.AutoSize = true;
            this.StartBTN.BackColor = System.Drawing.Color.Black;
            this.StartBTN.ForeColor = System.Drawing.Color.Yellow;
            this.StartBTN.Location = new System.Drawing.Point(22, 278);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(134, 92);
            this.StartBTN.TabIndex = 4;
            this.StartBTN.Text = "&Start!";
            this.StartBTN.UseVisualStyleBackColor = false;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(747, 397);
            this.Controls.Add(this.StatusTB);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.Disk2TB);
            this.Controls.Add(this.Disk1TB);
            this.Controls.Add(this.Disk2BTN);
            this.Controls.Add(this.Disk1BTN);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "MESS Apple II Emulator Disk Chooser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Disk1BTN;
        private System.Windows.Forms.Button Disk2BTN;
        private System.Windows.Forms.TextBox Disk1TB;
        private System.Windows.Forms.TextBox Disk2TB;
        private System.Windows.Forms.OpenFileDialog Disk1OpenDLG;
        private System.Windows.Forms.OpenFileDialog Disk2OpenDLG;
        private System.Windows.Forms.TextBox StatusTB;
        private System.Windows.Forms.Button StartBTN;
    }
}

