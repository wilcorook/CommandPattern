using CommandPattern.Appliances;

namespace CommandPattern.CommandObjects
{
    //Command
    public class TurnFanOn : ICommand
    {
        private readonly Fan _fan;

        public TurnFanOn(Fan fan)
        {
            _fan = fan;
        }
        
        public void Execute()
        {
            _fan.On();
        }

        public void Undo()
        {
            _fan.Off();
        }
    }
}