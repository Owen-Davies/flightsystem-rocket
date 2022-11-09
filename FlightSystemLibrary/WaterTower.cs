namespace FlightSystemLibrary
{
    public class WaterTower
    {
        private LaunchPad launchPad;

        public WaterTower(LaunchPad launchPad)
        {
            this.launchPad = launchPad;
            this.launchPad.RocketOnFire += (sender, args) => { this.WaterSystemsActivated = true; };
        }

        public bool WaterSystemsActivated { get; set; }
    }
}
