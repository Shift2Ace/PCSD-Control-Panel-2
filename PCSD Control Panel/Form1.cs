using OpenHardwareMonitor.Hardware;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace PCSD_Control_Panel_2._0
{
    public partial class Form1 : Form
    {
        // Declare some variables to store the mouse position and the dragging state
        bool dragging = false;
        Point offset;
        Point original;


        // Declare computer object for accessing hardware sensors
        private Computer myComputer;

        // Declare variables for CPU and GPU temperature
        private int cpuTemp;
        private int gpuTemp;
        private int cpuUsage;
        private int gpuUsage;


        public Form1()
        {
            InitializeComponent();

            // Initialize computer object and enable CPU and GPU sensors
            myComputer = new OpenHardwareMonitor.Hardware.Computer();
            myComputer.Open();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelSystem.Visible = true;
            panelSetting.Visible = false;
            panelUSBDisplay.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            // Set the dragging flag to true and capture the mouse
            dragging = true;
            panelTopBar.Capture = true;

            // Store the current mouse position and the original form location
            offset = MousePosition;
            original = this.Location;
        }

        // Handle the MouseMove event of panel2
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

        // Handle the MouseUp event of panel2
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            // Set the dragging flag to false and release the mouse
            dragging = false;
            panelTopBar.Capture = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Get the current values of CPU and GPU temperature
            cpuTemp = GetCPUTemp();
            gpuTemp = GetGPUTemp();
            cpuUsage = GetCPUUsage();
            gpuUsage = GetGPUUsage();

            label5.Text = cpuTemp.ToString() + " ¢XC";
            label6.Text = gpuTemp.ToString() + " ¢XC";
            label8.Text = cpuUsage.ToString() + " %";
            label7.Text = gpuUsage.ToString() + " %";
        }
        private int GetCPUTemp()
        {
            foreach (var hardwareItem in myComputer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    hardwareItem.Update();
                    foreach (IHardware subHardware in hardwareItem.SubHardware)
                        subHardware.Update();
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            return ((int)sensor.Value.Value);
                        }
                    }
                }
            }
            return 0;
        }
        private int GetGPUTemp()
        {
            return 0;
        }
        private int GetCPUUsage()
        {
            return 0;
        }
        private int GetGPUUsage()
        {
            return 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelSystem.Visible = false;
            panelSetting.Visible = false;
            panelUSBDisplay.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelSystem.Visible = false;
            panelSetting.Visible = true;
            panelUSBDisplay.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSystem.Visible = true;
            panelSetting.Visible = false;
            panelUSBDisplay.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("Console.exe");
        }
    }
}
