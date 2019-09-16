namespace CommandPattern.Appliances
{
    //Receiver
    public class Thermostat
    {
        private bool State { get; set; }
        private int Temp { get; set; }
        
        public Thermostat()
        {
            State = false;
            Temp = 0;
        }

        public void On()
        {
            State = true;
        }

        public void Off()
        {
            State = false;
        }

        public void tempUp()
        {
            Temp++;
        }

        public void tempDown()
        {
            Temp--;
        }

        public override string ToString()
        {
            return State ? $"On, temperature is set to {Temp}" : "Off";
        }
    }
}