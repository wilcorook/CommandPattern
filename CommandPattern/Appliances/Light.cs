namespace CommandPattern.Appliances
{
    //Receiver
    public class Light
    {
        private bool State { get; set; }
        
        public Light()
        {
            State = false;
        }

        public void On()
        {
            State = true;
        }

        public void Off()
        {
            State = false;
        }

        public override string ToString()
        {
            return State ? "On" : "Off";
        }
    }
}