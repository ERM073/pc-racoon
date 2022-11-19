using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace Cleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process test = new Process();
            test.StartInfo.FileName = "cmd";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "/c del /q/f/s %TEMP%\\*";
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            textBox1.Text = test.StandardOutput.ReadToEnd();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process test = new Process();
            test.StartInfo.FileName = "cmd";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "/c cleanmgr.exe /cDrive";
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            textBox1.Text = test.StandardOutput.ReadToEnd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process test = new Process();
            test.StartInfo.FileName = "cmd";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "/c MpCmdRun.exe -Scan -ScanType 1";
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            textBox1.Text = test.StandardOutput.ReadToEnd();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process test = new Process();
            test.StartInfo.FileName = "cmd";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "/c MpCmdRun.exe -Scan -ScanType 2";
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            textBox1.Text = test.StandardOutput.ReadToEnd();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process test = new Process();
            test.StartInfo.FileName = "curl";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "httpbin.org/ip";
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            textBox1.Text = test.StandardOutput.ReadToEnd();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process test = new Process();
            test.StartInfo.FileName = "ipconfig";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "/all";
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            textBox1.Text = test.StandardOutput.ReadToEnd();
        }
    }
}
