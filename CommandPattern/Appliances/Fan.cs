namespace CommandPattern.Appliances
{
    //Receiver
    public class Fan
    {
        private bool State { get; set; }
        
        public Fan()
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