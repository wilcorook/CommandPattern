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

            Console.WriteLine($"Light is turned {light}");
            Console.WriteLine($"Fan is turned {fan}");
            Console.WriteLine($"Thermostat is turned {thermostat}");
            Console.WriteLine();
            
            remote.PressButton(1);
            remote.PressButton(3);
            remote.PressButton(5);
            
            Console.WriteLine($"Light is turned {light}");
            Console.WriteLine($"Fan is turned {fan}");
            Console.WriteLine($"Thermostat is turned {thermostat}");
            Console.WriteLine();

            for (int i = 0; i < 21; i++)
            {
                remote.PressButton(7);
            }
            Console.WriteLine($"Thermostat is turned {thermostat}");
            Console.WriteLine();
            
            remote.PressButton(9);
            
            Console.WriteLine($"Light is turned {light}");
            Console.WriteLine($"Fan is turned {fan}");
            Console.WriteLine($"Thermostat is turned {thermostat}");
            Console.WriteLine();
        }
    }
}