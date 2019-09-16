using CommandPattern.Appliances;

namespace CommandPattern.CommandObjects
{
    //Command
    public class TurnThermostatOff : ICommand
    {
        private readonly Thermostat _thermostat;

        public TurnThermostatOff(Thermostat thermostat)
        {
            _thermostat = thermostat;
        }
        
        public void Execute()
        {
            _thermostat.Off();
        }

        public void Undo()
        {
            _thermostat.On();
        }
    }
}