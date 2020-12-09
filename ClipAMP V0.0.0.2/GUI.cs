using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;

namespace ClipAMP_Update
{
    public partial class GUI : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string ClassName, string WindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr HWindow, String String, int MaxCount);

        bool MouseCurrentlyDown = false;

        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            if(File.Exists("WinampCurrentSong.txt") == false)
            {
                var CurrentSongText = File.Create("WinampCurrentSong.txt");
                Thread.Sleep(250);
                CurrentSongText.Flush();
                Thread.Sleep(350);
                UpdateSongFile.Start();
            }
            else
            {
                UpdateSongFile.Start();
            }
        }

        private void MovementPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MouseCurrentlyDown = true;
        }

        private void MovementPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MouseCurrentlyDown = false;
        }

        private void MovementPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(MouseCurrentlyDown == true)
            {
                Location = Cursor.Position;
            }
            else
            {
                return;
            }
        }

        private void UpdateSongFile_Tick(object sender, EventArgs e)
        {
            IntPtr WAWindow = FindWindow("Winamp v1.x", null);
            if (WAWindow.Equals(IntPtr.Zero))
            {
                OutputData.Text = "";
            }
            else
            {
                string SongName = new string((char)0, 100);
                int WindowText = GetWindowText(WAWindow, SongName, SongName.Length);
                if (GetPerfectionCheck.Checked == true)
                {
                    OutputData.Text = SongName.Replace(" - Winamp", string.Empty).Replace("[Stopped]", string.Empty).Replace("[Paused]", string.Empty).ToString();
                }
                else
                {
                    OutputData.Text = SongName.ToString();
                }
                try
                {
                    File.WriteAllText("WinampCurrentSong.txt", OutputData.Text.ToString());
                }
                catch
                {
                    File.WriteAllText("WinampCurrentSong.txt", OutputData.Text.ToString());
                }
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Thread.Sleep(1000);
            Environment.Exit(1);
        }
    }
}
