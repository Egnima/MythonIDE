using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mython_IDE
{
    class sevenZip
    {
        public bool ExtractFile(string source, string destination)
        {
            string zipPath = "";

            if (!Directory.Exists(destination))
                Directory.CreateDirectory(destination);

            if (source == Environment.CurrentDirectory + @"\7-Zip.zip" &&
                destination == Environment.CurrentDirectory + @"\Mython\7-Zip")
            {
                ZipFile.ExtractToDirectory(source, destination);
            }

            else
            {
                zipPath = Environment.CurrentDirectory + @"\Mython\7-Zip\7zG.exe";
                try
                {
                    ProcessStartInfo ps = new ProcessStartInfo();
                    ps.FileName = zipPath;
                    ps.Arguments = "x \"" + source + "\" -o" + destination;
                    Process p = Process.Start(ps);
                    p.WaitForExit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
    }
}
