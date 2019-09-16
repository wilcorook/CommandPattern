using CommandPattern.Appliances;

namespace CommandPattern.CommandObjects
{
    //Command
    public class TurnThermostatUp : ICommand
    {
        private readonly Thermostat _thermostat;

        public TurnThermostatUp(Thermostat thermostat)
        {
            _thermostat = thermostat;
        }

        public void Execute()
        {
            _thermostat.tempUp();
        }

        public void Undo()
        {
            _thermostat.tempDown();
        }
    }
}