using CommandPattern.Appliances;

namespace CommandPattern.CommandObjects
{
    //Command
    public class TurnThermostatDown : ICommand
    {
        private readonly Thermostat _thermostat;

        public TurnThermostatDown(Thermostat thermostat)
        {
            _thermostat = thermostat;
        }

        public void Execute()
        {
            _thermostat.tempDown();
        }

        public void Undo()
        {
            _thermostat.tempUp();
        }
    }
}