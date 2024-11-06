using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MessDiskChooser
{
    public partial class Form1 : Form
    {
        public string CMDLine, DiskImage1, DiskImage2;  //mess emulator command line, disk image file names
        public bool Disk1Ready, Disk2Ready = false;
        public String MessPath = "\"M:\backup\\Google Drive\\Software\\Apple II\\windows programs\\mess\\mess.exe\"";

        public Form1()
        {
            InitializeComponent();
        }

        private void Disk1BTN_Click(object sender, EventArgs e)  //disk1 button
        {
            Disk1OpenDLG.ShowDialog(this);  //open file dialog

            if ( Disk1OpenDLG.FileName.Length > 0 )
            {
                DiskImage1 = Disk1OpenDLG.FileName;  //save file name for later
                Disk1TB.Text = DiskImage1;  //display file name in textbox                
                Disk1Ready = true;
                StatusTB.Text = "Disk 1 is ready.";
            }
        }

        private void StartBTN_Click_1(object sender, EventArgs e)
        {
            if (Disk1Ready == true)
            {
                SetCommandLine();
                StatusTB.Text = MessPath + " " + CMDLine;
                System.Diagnostics.Process.Start(MessPath + " " + CMDLine);
                Application.Exit();
            }
            else
            {
                StatusTB.Text = "A Disk image must be selected for drive 1.";
                System.Media.SystemSounds.Exclamation.Play();
            }
        }

        private void Disk2BTN_Click(object sender, EventArgs e) //disk2 button
        {
            Disk2OpenDLG.ShowDialog(this);  //open file dialog
            if (Disk2OpenDLG.FileName.Length > 0)
            {
                DiskImage2 = Disk2OpenDLG.FileName;  //save file name for later
                Disk2TB.Text = DiskImage1;  //display file name in textbox                
                Disk2Ready = true;
                StatusTB.Text = "Disk 2 is ready.";
            }
        }   

  
        private void SetCommandLine()  //generate emulator command line
        {
                      
            CMDLine = "apple2ee -flop1 \"" + DiskImage1 + "\" ";

            if ( Disk2Ready == true )
            {
                CMDLine += "-flop2 \"" + DiskImage2 + "\"";
            }
       }   
    }
}
