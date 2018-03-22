using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Mython_IDE
{
    class FileHandler
    {
        static string serverPath = Environment.CurrentDirectory + @"\Mython\\Minecraft Tools\server\server.properties";

        public void Cmd(string arg)
        {
            Process ps = new Process();
            try
            {
                ps.StartInfo.FileName = "CMD.exe";
                ps.StartInfo.RedirectStandardInput = true;
                ps.StartInfo.RedirectStandardOutput = true;
                ps.StartInfo.CreateNoWindow = true;
                ps.StartInfo.UseShellExecute = false;
                ps.Start();
                ps.StandardInput.WriteLine(arg);
                ps.StandardInput.Close();
                ps.WaitForExit();
            }
            catch (Win32Exception win32)
            {
                MessageBox.Show(win32.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Mython 폴더를 지우고 다시 실행해 주세요", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void findText(string key, string value)
        {
            string[] textValue = File.ReadAllLines(serverPath);
            string temp = "";
            foreach (string s in textValue)
            {
                string t = s;
                if (t.Contains(key))
                {
                    t = key + value;
                }
                temp += t + Environment.NewLine;
            }
            File.WriteAllText(serverPath, temp, Encoding.Default);
        }
    }
}
