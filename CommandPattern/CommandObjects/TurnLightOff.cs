using CommandPattern.Appliances;

namespace CommandPattern.CommandObjects
{
    //Command
    public class TurnLightOff : ICommand
    {
        private readonly Light _light;

        public TurnLightOff(Light light)
        {
            _light = light;
        }
        
        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}