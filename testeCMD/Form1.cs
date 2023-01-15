using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace testeCMD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pro = new ProcessStartInfo();

            pro.FileName = "C:\\WINDOWS\\system32\\cmd.exe";
            pro.RedirectStandardInput = true;
            pro.UseShellExecute = false;

            Process p = new Process();

            p.StartInfo = pro;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("IPCONFIG");
                    sw.WriteLine("D:");
                }
            }
            p.WaitForExit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();

            //Oculta cmd
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            //Chama CMD
            startInfo.FileName = "C:\\WINDOWS\\system32\\cmd.exe";

            //seu comando
            startInfo.Arguments = "/C shutdown /r /t 1000 /c 'O seu PC irá reiniciar em 1 minuto'";

            process.StartInfo = startInfo;
            process.Start();
        }
    }
}