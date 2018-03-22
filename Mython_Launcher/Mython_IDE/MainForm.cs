using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.ComponentModel;
using System.IO;

namespace Mython_IDE
{
    public partial class MainForm : Form
    {
        string vscPath = Environment.CurrentDirectory + @"\Mython\src\VSCodePortable\VSCodePortable.exe";
        string pyInterPath = Environment.CurrentDirectory + @"\Mython\src\VSCodePortable\Python\WinPython Interpreter.exe";

        string url = "https://www.dropbox.com/s/2dh44hq153wqok1/Mython.zip?dl=1";
        string filename = Environment.CurrentDirectory + @"\Mython.zip";

        string[] cb1 = { "true", "false" };
        string[] cb2 = { "DEFAULT", "FLAT", "LARGEBIOMES", "AMPLIFIED" };
        string[] cb3 = { "peaceful", "easy", "normal", "difficult" };

        public MainForm()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(cb1);
            comboBox2.Items.AddRange(cb2);
            comboBox3.Items.AddRange(cb3);
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 0;

            if (!Directory.Exists(Environment.CurrentDirectory + @"\Mython"))
            {
                if (MessageBox.Show("파일이 존재 하지 않습니다.\n 다시 다운 받겠습니까?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    fileDownload(url, filename);
                }
            }
        }

        private void btn_Launch_Click(object sender, EventArgs e)
        {
            FileHandler f = new FileHandler();
            Process p = new Process();
            MessageBox.Show("※주의※ Mython 실행 시 서버를 종료하면 안됩니다.", "서버 실행 중", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f.Cmd(@"cd Mython\Minecraft Tools\server && start start.bat");
            Thread.Sleep(1000);
            MessageBox.Show("Minecraft 실행 중", "안내", MessageBoxButtons.OK, MessageBoxIcon.Information);
            f.Cmd(@"cd Mython && start run.bat");
            Thread.Sleep(1000);
            if (checkBox1.Checked == true)
            {
                p.StartInfo.FileName = vscPath;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.Start();
            }
            else
            {
                p.StartInfo.FileName = pyInterPath;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                p.Start();
            }
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

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(283, 132);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(292, 277);
        }

        private void btn_editServer_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo.FileName = Environment.CurrentDirectory + @"\Mython\Minecraft Tools\server\server.properties";
            p.Start();
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
            if (zipH.ExtractFile(Environment.CurrentDirectory + @"\Mython.zip",
                Environment.CurrentDirectory + @"\Mython") == true)
                tabControl1.Enabled = true;
            else
            {
                if (MessageBox.Show("압축 풀기에 실패했습니다. \n 다시 시도 하시겠습니까?",
                    "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    if (zipH.ExtractFile(Environment.CurrentDirectory + @"\Mython.zip",
                        Environment.CurrentDirectory + @"\Mython") == true)
                            tabControl1.Enabled = true;
                    else
                    {
                        MessageBox.Show("압축 풀기 실패", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabControl1.Enabled = true;
                    }
                }
            }
            FileInfo f = new FileInfo(Environment.CurrentDirectory + @"\Mython.zip");
            f.Delete();
        }

        private void btn_reInstall_Click(object sender, EventArgs e)
        {
            // Mython 파일 삭제
            fileDownload(url, filename);
        }
    }
}
