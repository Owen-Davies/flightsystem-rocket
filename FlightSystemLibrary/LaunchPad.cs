namespace FlightSystemLibrary
{

    public class LaunchPad
    {
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler RocketOnFire = delegate { };

        private Rocket rocket;

        public LaunchPad(Rocket rocket)
        {
            this.rocket = rocket;
        }

        public void Launch()
        {
            if (rocket.IsOnFire)
            {
                RocketOnFire(this, new EventArgs());
                throw new FireException(); 
            }

            this.rocket.HasLaunched = true;
        }
    }
}
