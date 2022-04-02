using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModdingHub;

namespace OcuMods
{
    public partial class Form1 : Form
    {

        private const Int16 CurrentVersion = 1;

        public Form1()
        {
            InitializeComponent();
            var attribute = DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE;
            var preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
            DwmSetWindowAttribute(this.Handle, attribute, ref preference, sizeof(uint));
        }

        private void UpdateStatus(string status)
        {
            string formattedText = string.Format(status);
            this.Invoke((MethodInvoker)(() =>
            { //Invoke so we can call from any thread
                statuslabel.Text = formattedText;
            }));
        }

        private void DisableButton(string modname)
        {
            string formattedText = string.Format(modname);
            this.Invoke((MethodInvoker)(() =>
            {
                if (formattedText == "PlatformMonke")
                {
                    PMonkePCDownloadbtn.Enabled = false;
                    PMonkePCDownloadbtn.Text = "Requires SteamVR";
                }
                if (formattedText == "Utilla")
                {
                    UtillaPCDownloadbtn.Enabled = false;
                    UtillaPCDownloadbtn.Text = "Requires SteamVR";
                }
                if (formattedText == "UnityExplorer")
                {
                    UExplorerPCDownloadbtn.Enabled = false;
                    UExplorerPCDownloadbtn.Text = "Requires SteamVR";
                }
                if (formattedText == "GCosmetics")
                {
                    CosmeticPCDownloadbtn.Enabled = false;
                    CosmeticPCDownloadbtn.Text = "Requires SteamVR";
                }
            }));
        }

        // The enum flag for DwmSetWindowAttribute's second parameter, which tells the function what attribute to set.
        public enum DWMWINDOWATTRIBUTE
        {
            DWMWA_WINDOW_CORNER_PREFERENCE = 33
        }

        // The DWM_WINDOW_CORNER_PREFERENCE enum for DwmSetWindowAttribute's third parameter, which tells the function
        // what value of the enum to set.
        public enum DWM_WINDOW_CORNER_PREFERENCE
        {
            DWMWCP_DEFAULT = 0,
            DWMWCP_DONOTROUND = 1,
            DWMWCP_ROUND = 2,
            DWMWCP_ROUNDSMALL = 3
        }

        // Import dwmapi.dll and define DwmSetWindowAttribute in C# corresponding to the native function.
        [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern long DwmSetWindowAttribute(IntPtr hwnd,
                                                         DWMWINDOWATTRIBUTE attribute,
                                                         ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
                                                         uint cbAttribute);
        private void Form1_Load(object sender, EventArgs e)
        {
            

            string oculuspath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Settings\\QuestVRQmod");
            string steampath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Settings\\SteamVRdll");
            if (File.Exists(steampath))
            {
                siticoneButton9.Checked = true;
                FileExtensionthing.Text = ".dll (PC Mod)";
            }
            else if (File.Exists(oculuspath))
            {
                siticoneButton8.Checked = true;
                FileExtensionthing.Text = ".qmod (Quest Mod)";
                DisableButton("PlatformMonke");
                DisableButton("Utilla");
                DisableButton("UnityExplorer");
                DisableButton("GCosmetics");
            }
            else
            {
                VrHeadset.BringToFront();
                MessageBox.Show("Select your VR Type then restart the application");
            }
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
           
            VrHeadset.BringToFront();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Mods.BringToFront();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            FileManager.BringToFront();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Settings.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            if (siticoneComboBox1.SelectedIndex == 0)
            {
                if (siticoneComboBox1.SelectedIndex == 0)
                {
                    FolderBrowserDialog folderPicker = new FolderBrowserDialog();
                    folderPicker.Description = "Select the plugins folder in BepInEx";
                    if (folderPicker.ShowDialog() == DialogResult.OK)
                    {

                        listView1.Items.Clear();

                        string[] files = Directory.GetFileSystemEntries(folderPicker.SelectedPath);
                        foreach (string file in files)
                        {

                            string fileName = Path.GetFileName(file);
                            ListViewItem item = new ListViewItem(fileName);
                            item.Tag = file;

                            listView1.Items.Add(item);

                        }

                    }
                    UpdateStatus("Refreshed list for gorilla tag modding");
                }
            }
            else if (siticoneComboBox1.SelectedIndex == 1)
            {
                UpdateStatus("Beat Saber and other mods are coming soon!");
            }
        }

        private void siticoneComboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (siticoneComboBox2.SelectedIndex == 0)
            {
                gtagmodmarket.Visible = true;
                UpdateStatus("Opened to Gorilla tag's Modding Marketplace");
            }
            else if (siticoneComboBox2.SelectedIndex == 1)
            {
                UpdateStatus("Beat Saber and other mods are coming soon!");
            }
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            UpdateStatus("Downloading Platform Monke");
            System.Diagnostics.Process.Start("https://cdn.discordapp.com/attachments/953830146442420237/954103722961682542/PlatformMonke.dll");
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Quest, click ok to apply changes and restart the app");
            Directory.CreateDirectory("Settings");
            File.Create("Settings\\QuestVRQmod");
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Settings\\SteamVRdll");
            if (File.Exists(path))
            {
                File.Delete("Settings\\SteamVRdll");
            }
            else
            {

            }
            Application.Restart();
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selected SteamVR, click ok to apply changes and restart the app");
            Directory.CreateDirectory("Settings");
            File.Create("Settings\\SteamVRdll");
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Settings\\QuestVRQmod");
            if (File.Exists(path))
            {
                File.Delete("Settings\\QuestVRQmod");
            }
            else
            {
               
            }
            Application.Restart();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gtagmodmarket_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            
            string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Settings\\SteamVRdll");
            if (File.Exists(path))
            {
                System.Diagnostics.Process.Start("https://github.com/ToniMacaroni/ComputerInterface/releases/download/1.4.10/ComputerInterface.zip");
            }
            else
            {
                System.Diagnostics.Process.Start("https://cdn.discordapp.com/attachments/904923234691076148/926926740243218492/MonkeComputer_1.1.4.qmod");
            }
        }

        private void siticoneButton6_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/legoandmars/GorillaCosmetics/releases/download/v3.0.1/GorillaCosmetics-3.0.1.zip");
        }

        private void UtillaPCDownloadbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/legoandmars/Utilla/releases/download/v1.6.3/Utilla-1.6.3.zip");
        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/8mnV4MmXUq");
        }

        private void siticoneButton12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/Kmsu8z474g");
        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/monkemod");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var flags = new ModdingHub.Flags();
            flags.ShowDialog();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ContextMenu.Visible = true;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ContextMenu.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Foreverably/Modding-Hub/releases");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneButton6_Click_2(object sender, EventArgs e)
        {
            var flags = new ModdingHub.Launcher();
            flags.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
