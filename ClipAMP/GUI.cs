// ClipAMP
// Version 0.0.0.1
// Noah Bartley

// ClipAMP is licensed under the GPL-3.0 License.
// You can find the ClipAMP repository on GitHub here:
// https://github.com/LBartNoah
// https://github.com/LBartNoah/ClipAMP

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace ClipAMP
{
    public partial class GUI : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string ClassName, string WindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr HWindow, String String, int MaxCount);

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            if(File.Exists("EasterEggs.txt") == true)
            {
                MessageBox.Show("Noah Bartley Presents\nClipAMP \nVersion 0.0.0.1 \n \nThe amazing and constantly updated program that lets you view Winamp's currently playing song and place it into a simple text file!\n\nThank you for using this program. We hope you enjoy it as much as we did making it!", "You Unlocked An Easter Egg!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("How did you find this anyways.....\nOh well enjoy the program now.\n\n\nYou can remove this message from startup by removing the EasterEggs text file.", "Wait A Minute!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ShowWAMark.Checked = false;
            NoSpaceCheck.Checked = false;
            if(File.Exists("WinampSong.txt") == false)
            {
                try
                {
                    File.CreateText("WinampSong.txt");
                    UpdateMethod.Start();
                }
                catch
                {
                    MessageBox.Show("Failed to create Winamp Song text file. Try running as administrator and make sure the path the executable is in has valid access.", "Failed To Create File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                UpdateMethod.Start();
            }
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void UpdateMethod_Tick(object sender, EventArgs e)
        {
            IntPtr WAWindow = FindWindow("Winamp v1.x", null);
            if(WAWindow.Equals(IntPtr.Zero))
            {
                SongOutputBox.Text = "";
            }
            else
            {
                string SongName = new string((char)0, 100);
                int WindowText = GetWindowText(WAWindow, SongName, SongName.Length);
                if(ShowWAMark.Checked == true && NoSpaceCheck.Checked == true)
                {
                    SongOutputBox.Text = SongName.Replace(" ", string.Empty).ToString();
                }
                if (ShowWAMark.Checked == true && NoSpaceCheck.Checked == false)
                {
                    SongOutputBox.Text = SongName.ToString();
                }
                if (ShowWAMark.Checked == false && NoSpaceCheck.Checked == true)
                {
                    SongOutputBox.Text = SongName.Replace("- Winamp", string.Empty).Replace(" ", string.Empty).ToString();
                }
                if (ShowWAMark.Checked == false && NoSpaceCheck.Checked == false)
                {
                    SongOutputBox.Text = SongName.Replace("- Winamp", string.Empty).ToString();
                }
                File.WriteAllText("WinampSong.txt", SongOutputBox.Text.ToString());
             }
         }
    }
}
