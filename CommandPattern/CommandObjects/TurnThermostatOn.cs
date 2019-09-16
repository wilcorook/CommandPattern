using CommandPattern.Appliances;

namespace CommandPattern.CommandObjects
{
    //Command
    public class TurnThermostatOn : ICommand
    {
        private readonly Thermostat _thermostat;

        public TurnThermostatOn(Thermostat thermostat)
        {
            _thermostat = thermostat;
        }
        
        public void Execute()
        {
            _thermostat.On();
        }

        public void Undo()
        {
            _thermostat.Off();
        }
    }
}