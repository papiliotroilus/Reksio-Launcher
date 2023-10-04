using System;
using System.Diagnostics;

namespace ReksioLauncher
{
    public partial class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pirati_Click(object sender, EventArgs e)
        {
            var info = new ProcessStartInfo();
            info.FileName = @".\Reksio si Comoara Piratilor\ReksioPiraci.exe";
            info.WorkingDirectory = @".\Reksio si Comoara Piratilor";
            Process.Start(info);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var info = new ProcessStartInfo();
            info.FileName = @".\Reksio si OZN-ul\ReksioUfo.exe";
            info.WorkingDirectory = @".\Reksio si OZN-ul";
            Process.Start(info);
        }

        private void magic_Click(object sender, EventArgs e)
        {
            var info = new ProcessStartInfo();
            info.FileName = @".\Reksio si Magicienii\Czarodzieje.exe";
            info.WorkingDirectory = @".\Reksio si Magicienii";
            Process.Start(info);
        }

        private void timp_Click(object sender, EventArgs e)
        {
            var info = new ProcessStartInfo();
            info.FileName = @".\Reksio si Masina Timpului\Wehikul.exe";
            info.WorkingDirectory = @".\Reksio si Masina Timpului";
            Process.Start(info);
        }

        private void nemo_Click(object sender, EventArgs e)
        {
            var info = new ProcessStartInfo();
            info.FileName = @".\Reksio si Capitanul Nemo\nemo.exe";
            info.WorkingDirectory = @".\Reksio si Capitanul Nemo";
            Process.Start(info);
        }

        private void actiune_Click(object sender, EventArgs e)
        {
            var info = new ProcessStartInfo();
            info.FileName = @".\Reksio si Kretes in Actiune\rex5.exe";
            info.WorkingDirectory = @".\Reksio si Kretes in Actiune";
            Process.Start(info);
        }
    }
}