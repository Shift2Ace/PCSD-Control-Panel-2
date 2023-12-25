using Microsoft.VisualBasic.Devices;
using OpenHardwareMonitor.Hardware;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;



namespace PCSD_Control_Panel_2._0
{
    public partial class Form1 : Form
    {
        // Declare some variables to store the mouse position and the dragging state
        bool dragging = false;
        Point offset;
        Point original;

        // Declare computer object for accessing hardware sensors
        private static OpenHardwareMonitor.Hardware.Computer myComputer;

        // Declare variables for CPU and GPU temperature
        private static int cpuTemp;
        private static int gpuTemp;
        private static int cpuUsage;
        private static int gpuUsage;

        private System.Windows.Forms.Timer timer;

        //init
        public Form1()
        {
            InitializeComponent();

            // Initialize computer object and enable CPU and GPU sensors
            myComputer = new OpenHardwareMonitor.Hardware.Computer();
            myComputer.Open();
            myComputer.CPUEnabled = true;
            myComputer.GPUEnabled = true;
            numericUpDown1.Value = Properties.Settings.Default.update_speed;
            displayStatus.IsBackground = true;
            displayStatus.Start();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 250;
            timer.Tick += new EventHandler(timer1_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelSystem.Visible = true;
            panelSetting.Visible = false;
            panelUSBDisplay.Visible = false;
            timer.Start();

        }
        // Close button
        private void button2_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        // Top bar
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            // Set the dragging flag to true and capture the mouse
            dragging = true;
            panelTopBar.Capture = true;

            // Store the current mouse position and the original form location
            offset = MousePosition;
            original = this.Location;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the dragging flag is true
            if (dragging)
            {
                // Calculate the new form location based on the mouse position and the offset
                int x = original.X + MousePosition.X - offset.X;
                int y = original.Y + MousePosition.Y - offset.Y;

                // Set the new form location
                this.Location = new Point(x, y);
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            // Set the dragging flag to false and release the mouse
            dragging = false;
            panelTopBar.Capture = false;
        }

        // Get status
        Thread displayStatus = new Thread(delegate ()
        {
            int cpuTempTmp, cpuUsageTmp, gpuTempTmp, gpuUsageTmp;
            while (true)
            {
                // Get the current values of CPU and GPU temperature and usage
                cpuTempTmp = GetCPUTemp();
                gpuTempTmp = GetGPUTemp();
                cpuUsageTmp = GetCPUUsage();
                gpuUsageTmp = GetGPUUsage();
                cpuTemp = cpuTempTmp;
                gpuTemp = gpuTempTmp;
                cpuUsage = cpuUsageTmp;
                gpuUsage = gpuUsageTmp;
                Thread.Sleep(Properties.Settings.Default.update_speed);
            }
        });

        private static int GetCPUTemp()
        {
            foreach (var hardware in myComputer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.Name == "CPU Package" && sensor.SensorType == SensorType.Temperature)
                        {
                            hardware.Update();
                            return ((int)sensor.Value);
                        }
                    }
                }
            }
            return 0;
        }
        private static int GetGPUTemp()
        {
            foreach (var hardware in myComputer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAti)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.Name == "GPU Core" && sensor.SensorType == SensorType.Temperature)
                        {
                            hardware.Update();
                            return ((int)sensor.Value);
                        }
                    }
                }
            }
            return 0;
        }
        private static int GetCPUUsage()
        {
            foreach (var hardware in myComputer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.Name == "CPU Total" && sensor.SensorType == SensorType.Load)
                        {
                            hardware.Update();
                            return ((int)sensor.Value);
                        }
                    }
                }
            }
            return 0;
        }
        private static int GetGPUUsage()
        {
            foreach (var hardware in myComputer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia || hardware.HardwareType == HardwareType.GpuAti)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.Name == "GPU Core" && sensor.SensorType == SensorType.Load)
                        {
                            hardware.Update();
                            return ((int)sensor.Value);
                        }
                    }
                }
            }
            return 0;
        }

        //menu button
        private void button3_Click(object sender, EventArgs e)
        {
            panelSystem.Visible = false;
            panelSetting.Visible = false;
            panelUSBDisplay.Visible = true;
            timer.Stop();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panelSystem.Visible = false;
            panelSetting.Visible = true;
            panelUSBDisplay.Visible = false;
            timer.Stop();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            panelSystem.Visible = true;
            panelSetting.Visible = false;
            panelUSBDisplay.Visible = false;
            timer.Start();
        }

        //console app button
        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("Console.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label5.Text = cpuTemp.ToString() + " ¢XC";
            label6.Text = gpuTemp.ToString() + " ¢XC";
            label8.Text = cpuUsage.ToString() + " %";
            label7.Text = gpuUsage.ToString() + " %";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.update_speed = Convert.ToInt32(numericUpDown1.Value);
            Properties.Settings.Default.Save();
        }
    }
}
