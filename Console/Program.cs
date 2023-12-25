using OpenHardwareMonitor.Hardware;

internal class Program
{
    //menu and input
    private static void Main(string[] args)
    {
        string choice;
        string[] choices = { "Show index", "Check value", "Exit" };

        Computer computer = new Computer();
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("Loading...(0/7)");
        computer.Open();
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("Loading...(1/7)");
        computer.CPUEnabled = true;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("Loading...(2/7)");
        computer.GPUEnabled = true;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("Loading...(3/7)");
        computer.RAMEnabled = true;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("Loading...(4/7)");
        computer.HDDEnabled = true;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("Loading...(5/7)");
        computer.MainboardEnabled = true;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("Loading...(6/7)");
        computer.FanControllerEnabled = true;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("Loading...(7/7)");
        Console.WriteLine();

        Console.Clear();


        do
        {
            //show menu
            for (var i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"{i+1} ) {choices[i]} ");
            }
            //input number
            do
            {
                Console.Write($"Enter number (1-{choices.Length}) : ");
                choice = Console.ReadLine();
            } 
            while (!checkInput(choice,choices.Length));
            if (choices[Convert.ToInt32(choice) - 1] == "Show index")
            {
                showIndex(computer);
            }
            if (choices[Convert.ToInt32(choice) - 1] == "Check value")
            {
                checkValue(computer);
            }
            if (choices[Convert.ToInt32(choice)-1] != "Exit")
            {
                Console.WriteLine("Press <Enter> to Continue");
                Console.ReadLine();
                Console.Clear();
            }
        }
        while (choices[Convert.ToInt32(choice) - 1] != "Exit");
    }

    private static void checkValue(Computer computer)
    {
        string hardwareChoice;
        string sensorChoice;
        List<string> hardwareChoices = new List<string>();
        List<string> sensorName = new List<string>();
        List<string> sensorType = new List<string>();
        Console.Clear();
        // show hardwares
        Console.WriteLine("Hardware : ");
        foreach (var hardware in computer.Hardware)
        {
            hardwareChoices.Add(hardware.Name);
            Console.WriteLine($"{hardwareChoices.Count} ) {hardware.Name}");
            
        }
        hardwareChoices.Add("Exit");
        Console.WriteLine($"{hardwareChoices.Count} ) Exit");
        // choose hardware
        do
        {
            Console.Write($"Enter number (1-{hardwareChoices.Count}) : ");
            hardwareChoice = Console.ReadLine();
        }
        while (!checkInput(hardwareChoice, hardwareChoices.Count));
        if  (Convert.ToInt32(hardwareChoice) != hardwareChoices.Count)
        {
            // show sensors
            Console.Clear();
            Console.WriteLine("Sensor :");
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.Name == hardwareChoices[Convert.ToInt32(hardwareChoice) - 1])
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        sensorName.Add(sensor.Name);
                        sensorType.Add(sensor.SensorType.ToString());
                        Console.WriteLine($"{sensorName.Count} ) {sensor.Name} - {sensor.SensorType}");
                    }
                    sensorName.Add("Exit");
                    Console.WriteLine($"{sensorName.Count} ) Exit");
                    // choose sensor
                    do
                    {
                        Console.Write($"Enter number (1-{sensorName.Count}) : ");
                        sensorChoice = Console.ReadLine();
                    }
                    while (!checkInput(sensorChoice, sensorName.Count));
                    if (Convert.ToInt32(sensorChoice) != sensorName.Count)
                    {
                        foreach(var sensor in hardware.Sensors)
                        {
                            if (sensor.Name == sensorName[Convert.ToInt32(sensorChoice) - 1] && sensor.SensorType.ToString() == sensorType[Convert.ToInt32(sensorChoice) - 1])
                            {
                                bool running = true;
                                Console.Clear();
                                Console.WriteLine($"Hardware : {hardware.Name}");
                                Console.WriteLine($"Sensor : {sensor.Name} - {sensor.SensorType}");
                                Console.SetCursorPosition(0, 5);
                                Console.WriteLine("Press <Enter> to STOP");
                                Thread displayStatus = new Thread(delegate ()
                                {
                                    while (running)
                                    {
                                        hardware.Update();
                                        Console.SetCursorPosition(0, 3);
                                        Console.Write(new string(' ', Console.BufferWidth));
                                        Console.SetCursorPosition(0, 3);
                                        Console.Write($"Value : {sensor.Value} (MAX : {sensor.Max} MIN : {sensor.Min})");
                                        Thread.Sleep(1000);
                                    }
                                });
                                displayStatus.IsBackground = true;
                                displayStatus.Start();
                                Console.ReadLine();
                                running = false;
                                Console.SetCursorPosition(0, 6);
                            }
                        }
                        
                    }
                }
            }
        }
    }
    private static bool checkInput(string input, int choicesNum)
    {
        List<string> choices = new List<string>();
        for (int i = 0; i < choicesNum; i++)
        {
            choices.Add((i+1).ToString());
        }
        if (choices.Contains(input))
        {
            return true;
        }
        return false;
    }

    private static void showIndex(Computer computer)
    {
        Console.Clear();
        foreach (var hardware in computer.Hardware)
        {
            if (hardware.HardwareType != null)
            {
                Console.Write(hardware.HardwareType.ToString());
            }
            if (hardware.Name != null)
            {
                Console.Write(" : " + hardware.Name.ToString());
            }
            Console.WriteLine();
            foreach (var sensor  in hardware.Sensors)
            {
                if (sensor.Name != null)
                {
                    Console.Write("   | "+sensor.Name.ToString());
                }
                if (sensor.SensorType != null)
                {
                    Console.Write(" [" + sensor.SensorType.ToString() + "]");
                }
                Console.WriteLine();
            }       
        }
    }
}