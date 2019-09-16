using CommandPattern.Appliances;

namespace CommandPattern.CommandObjects
{
    //Command
    public class TurnFanOff : ICommand
    {
        private readonly Fan _fan;

        public TurnFanOff(Fan fan)
        {
            _fan = fan;
        }
        
        public void Execute()
        {
            _fan.Off();
        }

        public void Undo()
        {
            _fan.On();
        }
    }
}