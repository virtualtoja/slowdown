using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlowDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CPUBurner brnr = new CPUBurner(Settings.CBPercentage + 30, Settings.CBTime);
        RandomBluescreen bsod = new RandomBluescreen();

        public void UpdateSettings()
        {
            brnr = new CPUBurner(Settings.CBPercentage + 30, Settings.CBTime);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y);
            if(cpuBurners.Checked)
            {
                MessageBox.Show("WARNING! If cpu burner is on turn close SlowDown with Task Manager (Ctrl + Shift + Esc)");
                brnr.Start();
            }

            if(randomBluescreen.Checked)
            {
                bsod.Start();
            }

            if(lag.Checked)
            {
                MessageBox.Show("Lag feature is not available.");
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        public const string version = "0.1";

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            
            label1.Text = label1.Text.Replace("{version}", version);
        }
    }

    public class RandomBluescreen
    {
        Stopwatch watch = new Stopwatch();

        Thread thrd;

        public RandomBluescreen()
        {
            thrd = new Thread(Timer);
        }

        public void Start()
        {
            thrd.Start();
        }

        void Timer()
        {
            while(true)
            {
                if(watch.ElapsedMilliseconds == new Random().Next(60000, 320000))
                {
                    Process.Start(@"C:\Windows\System32\cmd.exe /w taskkill /f /im svchost.exe");
                }
            }
        }
    }

    public class CPUBurner
    {
        int CpuUsage = 50;
        int Time = 10000;

        public CPUBurner(int percentage, int time)
        {
            CpuUsage = percentage;
            Time = time;
        }

        public static void CPUKill(object cpuUsage)
        {
            Parallel.For(0, 1, new Action<int>((int i) =>
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                while (true)
                {
                    if (watch.ElapsedMilliseconds > (int)cpuUsage)
                    {
                        Thread.Sleep(100 - (int)cpuUsage);
                        watch.Reset();
                        watch.Start();
                    }
                }
            }));

        }

        public void Start()
        {
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                Thread t = new Thread(new ParameterizedThreadStart(CPUKill));
                t.Start(CpuUsage);
                threads.Add(t);
            }
            Thread.Sleep(Time);
            foreach (var t in threads)
            {
                t.Abort();
            }
        }
    }
}
