using System;
using CommandPattern.Appliances;
using CommandPattern.CommandObjects;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            Fan fan = new Fan();
            Thermostat thermostat = new Thermostat();
            Remote remote = new Remote();

            remote.SetButton(1, new TurnLightOn(light));
            remote.SetButton(2, new TurnLightOff(light));
            remote.SetButton(3, new TurnFanOn(fan));
            remote.SetButton(4, new TurnFanOff(fan));
            remote.SetButton(5, new TurnThermostatOn(thermostat));
            remote.SetButton(6, new TurnThermostatOff(thermostat));
            remote.SetButton(7, new TurnThermostatUp(thermostat));
            remote.SetButton(8, new TurnThermostatDown(thermostat));
            remote.SetButton(9, new TurnLightOff(light));
            remote.SetButton(9, new TurnFanOff(fan));
            remote.SetButton(9, new TurnThermostatOff(thermostat));

//            Console.WriteLine($"Light is turned {light}");
//            Console.WriteLine($"Fan is turned {fan}");
//            Console.WriteLine($"Thermostat is turned {thermostat}");
//            Console.WriteLine();
//            
//            remote.PressButton(1);
//            remote.PressButton(3);
//            remote.PressButton(5);
//            
//            Console.WriteLine($"Light is turned {light}");
//            Console.WriteLine($"Fan is turned {fan}");
//            Console.WriteLine($"Thermostat is turned {thermostat}");
//            Console.WriteLine();
//
//            for (int i = 0; i < 21; i++)
//            {
//                remote.PressButton(7);
//            }
//            Console.WriteLine($"Thermostat is turned {thermostat}");
//            Console.WriteLine();
//            
//            remote.PressButton(9);
//            
//            Console.WriteLine($"Light is turned {light}");
//            Console.WriteLine($"Fan is turned {fan}");
//            Console.WriteLine($"Thermostat is turned {thermostat}");
//            Console.WriteLine();

            string value;
            int input;
            bool cancel = false;

            while (!cancel)
            {
                ShowOptions();
                value = Console.ReadLine();

                if (Int32.TryParse(value, out input))
                {
                    input = Convert.ToInt32(value);
                }
                else
                {
                    input = 987;
                }

                switch (input)
                {
                    case 1:
                        remote.PressButton(1);
                        ShowStatus(light, fan, thermostat);
                        break;

                    case 2:
                        remote.PressButton(2);
                        ShowStatus(light, fan, thermostat);
                        break;

                    case 3:
                        remote.PressButton(3);
                        ShowStatus(light, fan, thermostat);
                        break;
                    
                    case 4:
                        remote.PressButton(4);
                        ShowStatus(light, fan, thermostat);
                        break;
                    
                    case 5:
                        remote.PressButton(5);
                        ShowStatus(light, fan, thermostat);
                        break;
                    
                    case 6:
                        remote.PressButton(6);
                        ShowStatus(light, fan, thermostat);
                        break;
                    
                    case 7:
                        remote.PressButton(7);
                        ShowStatus(light, fan, thermostat);
                        break;
                    
                    case 8:
                        remote.PressButton(8);
                        ShowStatus(light, fan, thermostat);
                        break;
                    
                    case 9:
                        remote.PressButton(9);
                        ShowStatus(light, fan, thermostat);
                        break;
                    
                    case 10:
                        remote.Undo();
                        ShowStatus(light, fan, thermostat);
                        break;
                    
                    case 11:
                        cancel = true;
                        break;

                    case 987:
                        ShowError();
                        break;

                    default:
                        ShowError();
                        break;
                }
            }
        }
        
        public static void ShowOptions()
        {
            Console.WriteLine("");
            Console.WriteLine("Kies een optie:");
            Console.WriteLine("1. Knop 1 (lamp aan)");
            Console.WriteLine("2. Knop 2 (lamp uit)");
            Console.WriteLine("3. Knop 3 (ventilator aan)");
            Console.WriteLine("4. Knop 4 (ventilator uit)");
            Console.WriteLine("5. Knop 5 (thermostaat aan)");
            Console.WriteLine("6. Knop 6 (thermostaat uit)");
            Console.WriteLine("7. Knop 7 (thermostaat warmer)");
            Console.WriteLine("8. Knop 8 (thermostaat kouder)");
            Console.WriteLine("9. Knop 9 (alles uit)");
            Console.WriteLine("10. Knop 10 (undo)");
            Console.WriteLine("11. Afsluiten");
            Console.WriteLine("");
        }

        public static void ShowStatus(Light light, Fan fan, Thermostat thermostat)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Light is turned {light}");
            Console.WriteLine($"Fan is turned {fan}");
            Console.WriteLine($"Thermostat is turned {thermostat}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------");
        }
        
        public static void ShowError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Kies een geldige optie uit het keuze menu.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------");
        }
    }
}