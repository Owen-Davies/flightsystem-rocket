using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightSystemLibrary;

namespace FlightSystemTests
{
    public class FlightSystems
    {

        public Rocket CreateANewRocket()
        {
            Rocket rocket = new Rocket();

            return rocket;
        }

        [Fact]
        public void FlightSystem_CanCreateRocket_True()
        {
            // Arrange
            var rocket = CreateANewRocket();

            //Act
            //Assert
            Assert.NotNull(rocket);
        }

        [Fact]
        public void FlightSystem_CanLaunchRocket_True()
        {
            // Arrange
            Rocket rocket = new Rocket();
            LaunchPad launchPad = new LaunchPad(rocket);


            // Act
            launchPad.Launch();

            // Assert
            Assert.True(rocket.HasLaunched);
        }

        [Fact]
        public void FlightSystem_RocketFire_CanLaunchRocket_False()
        {
            // Arrange
            Rocket rocket = new Rocket();
            LaunchPad launchPad = new LaunchPad(rocket);


            // Act
            rocket.Fire();

            // Assert
            Assert.Throws<FireException>(() => launchPad.Launch());
            Assert.False(rocket.HasLaunched);
            Assert.True(rocket.IsOnFire);
        }

        [Fact]
        public void FlightSystems_RocketFire_PutOutWithWater()
        {
            // Arrange
            Rocket rocket = new Rocket();
            LaunchPad launchPad = new LaunchPad(rocket);
            WaterTower waterTower = new WaterTower(launchPad);

            // Act
            rocket.Fire();
            Assert.Throws<FireException>(() => launchPad.Launch());

            // Assert
            Assert.True(waterTower.WaterSystemsActivated);
        }

        [Fact]
        public void FlightSystems_RocketFire_RocketFireException()
        {
            // Arrange
            Rocket rocket = new Rocket();
            LaunchPad launchPad = new LaunchPad(rocket);


            // Act
            //Assert
            rocket.Fire();
            Assert.Throws<FireException>(() => launchPad.Launch());
        }

        [Fact]
        public void FlightSystems_RocketTemperatureNull_False()
        {
            // Arrange
            Rocket rocket = new Rocket();
            LaunchPad launchPad = new LaunchPad(rocket);

            // Act

            // Assert

            Assert.NotNull(rocket.TemperatureGauge);
        }
    }

}

