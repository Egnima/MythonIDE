using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Mython_IDE
{
    public partial class MainForm : Form
    {
        string vscPath = Environment.CurrentDirectory + @"\Mython\src\VSCodePortable\VSCodePortable.exe";
        string winpyPath = Environment.CurrentDirectory + @"\Mython\src\VSCodePortable\Python";
        string myPath = Environment.CurrentDirectory + @"\Mython";

        string zipUrl = "https://www.dropbox.com/s/lca0ytb29z1asrt/7-Zip.zip?dl=1";
        string zipFN = Environment.CurrentDirectory + @"\7-Zip.zip";

        string mythonUrl = "https://www.dropbox.com/s/b0nql9d3jr8grcq/Mython.zip?dl=1";
        string mythonFN = Environment.CurrentDirectory + @"\Mython.zip";

        string[] cb1 = { "true", "false" };
        string[] cb2 = { "DEFAULT", "FLAT", "LARGEBIOMES", "AMPLIFIED" };
        string[] cb3 = { "peaceful", "easy", "normal", "difficult" };

        bool hasZip = false;

        public MainForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(cb1);
            comboBox2.Items.AddRange(cb2);
            comboBox3.Items.AddRange(cb3);
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 0;
            tsLbl_Status.Text = "준비";

            if (!Directory.Exists(myPath))
            {
                if (MessageBox.Show("파일이 존재 하지 않습니다.\n다운 받겠습니까?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    fileDownload(zipUrl, zipFN);
                    fileDownload(mythonUrl, mythonFN);
                }
            }
        }

        private void btn_Launch_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox2.Checked == true)
                    this.WindowState = FormWindowState.Minimized;

                FileHandler f = new FileHandler();
                Process p = new Process();
                if (checkBox1.Checked == true)
                {
                    p.StartInfo.FileName = vscPath;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    p.Start();
                }
                else
                {
                    p.StartInfo.FileName = winpyPath + @"\WinPython Interpreter.exe";
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    p.Start();
                }
                Thread.Sleep(1000);
                //MessageBox.Show("※주의※ Mython 실행 시 서버를 종료하면 안됩니다.", "서버 실행 중", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.Cmd(@"cd Mython\Minecraft Tools\server && start start.bat");
                Thread.Sleep(1000);
                //MessageBox.Show("Minecraft 실행 중", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.Cmd(@"cd Mython && start run.bat");  
            }
            catch (Win32Exception win32)
            {
                MessageBox.Show("파일 재설치 후 다시 시도해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_reInstall_Click(object sender, EventArgs e)
        {
            tabControl1.Enabled = false;
            DirectoryInfo dir = new DirectoryInfo(myPath);

            if (Directory.Exists(myPath))
            {
                tsLbl_Status.Text = "파일 삭제 중";
                // Directory.Delete(myPath, true);
                foreach(FileInfo files in dir.GetFiles())
                {
                    files.Delete();
                }
                foreach(DirectoryInfo dirs in dir.GetDirectories())
                {
                    dirs.Delete(true);
                }
            }
                

            fileDownload(zipUrl, zipFN);
            fileDownload(mythonUrl, mythonFN);
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            FileHandler f = new FileHandler();
            f.Cmd(@"cd Mython\Minecraft Tools\server && start start.bat");
        }

        private void btn_mc_Click(object sender, EventArgs e)
        {
            FileHandler f = new FileHandler();
            f.Cmd(@"cd Mython && start run.bat");
        }

        private void btn_vsc_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = vscPath;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            p.Start();
        }

        private void btn_winpy_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = winpyPath + @"\WinPython Interpreter.exe";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            p.Start();
        }

        private void btn_WinPyFolder_Click(object sender, EventArgs e)
        {
            Process.Start(winpyPath);
        }

        private void btn_winpyCMD_Click(object sender, EventArgs e)
        {
            Process.Start(winpyPath + @"\WinPython Command Prompt.exe");
        }

        private void btn_CtrlPanel_Click(object sender, EventArgs e)
        {
            Process.Start(winpyPath + @"\WinPython Control Panel.exe");
        }

        private void btn_editServer_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = Environment.CurrentDirectory + @"\Mython\Minecraft Tools\server\server.properties";
            p.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FileHandler f = new FileHandler();
                f.findText("online-mode=", comboBox1.Text);
            }
            catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FileHandler f = new FileHandler();
                f.findText("level-type=", comboBox2.Text);
            }
            catch { }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FileHandler f = new FileHandler();
                if (comboBox3.Text == cb3[0])
                    f.findText("difficulty=", "0");
                else if (comboBox3.Text == cb3[1])
                    f.findText("difficulty=", "1");
                else if (comboBox3.Text == cb3[2])
                    f.findText("difficulty=", "2");
                else if (comboBox3.Text == cb3[3])
                    f.findText("difficulty=", "3");
            }
            catch { }
        }

        private void fileDownload(string URL, string filename)
        {
            WebClient wc = new WebClient();
            wc.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(Completed);
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Downloading);
            wc.DownloadFileAsync(new Uri(URL), filename);
        }

        private void Downloading(object sender, DownloadProgressChangedEventArgs e)
        {
            tabControl1.Enabled = false;
            tsPsBar.Value = e.ProgressPercentage;
            tsLbl_Status.ForeColor = System.Drawing.Color.Black;
            tsLbl_Status.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            sevenZip zipH = new sevenZip();
            if (hasZip == false)
            {
                if (zipH.ExtractFile(Environment.CurrentDirectory + @"\7-Zip.zip",
                    Environment.CurrentDirectory + @"\Mython\7-Zip") == true)
                { }
            }
            else if (hasZip == true)
            {
                FileInfo zipf = new FileInfo(Environment.CurrentDirectory + @"\7-Zip.zip");
                zipf.Delete();

                if (zipH.ExtractFile(Environment.CurrentDirectory + @"\Mython.zip",
                myPath) == true)
                {
                    tabControl1.Enabled = true;
                    FileInfo f = new FileInfo(Environment.CurrentDirectory + @"\Mython.zip");
                    f.Delete();
                }
            }
            else
            {
                MessageBox.Show("압축 풀기에 실패했습니다. \n 다시 시도 하시겠습니까?",
                    "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            hasZip = true;
            tsLbl_Status.Text = "다운로드 완료";
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(278, 189);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new System.Drawing.Size(278, 487);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(434, 190);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Egnima");
        }
    }
}
