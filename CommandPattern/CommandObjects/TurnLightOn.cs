using CommandPattern.Appliances;

namespace CommandPattern.CommandObjects
{
    //Command
    public class TurnLightOn : ICommand
    {
        private readonly Light _light;

        public TurnLightOn(Light light)
        {
            _light = light;
        }
        
        public void Execute()
        {
            _light.On();
        }

        public void Undo()
        {
            _light.Off();
        }
    }
}