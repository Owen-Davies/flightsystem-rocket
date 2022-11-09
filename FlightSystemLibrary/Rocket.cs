using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystemLibrary
{
    public class Rocket
    {
        public Rocket()
        {
            TemperatureGauge = 0;
        }

        public bool HasLaunched { get; set; }
        public bool IsOnFire { get; set; }
        public decimal? TemperatureGauge { get; set; }

        public void Fire()
        {
            this.IsOnFire = true;
        }
    }
}
