using CommandPattern;
using CommandPattern.Appliances;
using CommandPattern.CommandObjects;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Should_TurnOnLight_When_AssignedButtonIsPressed()
        {
            //Arrange
            Light light = new Light();
            Remote remote = new Remote();
            remote.SetButton(1, new TurnLightOn(light));
            string expected = "On";
            
            //Act
            remote.PressButton(1);
            
            //Assert
            Assert.AreEqual(expected, light.ToString());
        }
        
        [Test]
        public void Should_TurnOffLight_When_AssignedButtonIsPressed()
        {
            //Arrange
            Light light = new Light();
            Remote remote = new Remote();
            remote.SetButton(1, new TurnLightOff(light));
            string expected = "Off";
            
            //Act
            remote.PressButton(1);
            
            //Assert
            Assert.AreEqual(expected, light.ToString());
        }

        [Test]
        public void Should_TurnOnFan_When_AssignedButtonIsPressed()
        {
            //Arrange
            Fan fan = new Fan();
            Remote remote = new Remote();
            remote.SetButton(1, new TurnFanOn(fan));
            string expected = "On";
            
            //Act
            remote.PressButton(1);
            
            //Assert
            Assert.AreEqual(expected, fan.ToString());
        }
        
        [Test]
        public void Should_TurnOffFan_When_AssignedButtonIsPressed()
        {
            //Arrange
            Fan fan = new Fan();
            Remote remote = new Remote();
            remote.SetButton(1, new TurnFanOff(fan));
            string expected = "Off";
            
            //Act
            remote.PressButton(1);
            
            //Assert
            Assert.AreEqual(expected, fan.ToString());
        }
        
        [Test]
        public void Should_TurnOnThermostat_When_AssignedButtonIsPressed()
        {
            //Arrange
            Thermostat thermostat = new Thermostat();
            Remote remote = new Remote();
            remote.SetButton(1, new TurnThermostatOn(thermostat));
            string expected = "On, temperature is set to 0";
            
            //Act
            remote.PressButton(1);
            
            //Assert
            Assert.AreEqual(expected, thermostat.ToString());
        }
        
        [Test]
        public void Should_TurnOffThermostat_When_AssignedButtonIsPressed()
        {
            //Arrange
            Thermostat thermostat = new Thermostat();
            Remote remote = new Remote();
            remote.SetButton(1, new TurnThermostatOff(thermostat));
            string expected = "Off";
            
            //Act
            remote.PressButton(1);
            
            //Assert
            Assert.AreEqual(expected, thermostat.ToString());
        }
        
        [Test]
        public void Should_TurnUpThermostat_When_AssignedButtonIsPressed()
        {
            //Arrange
            Thermostat thermostat = new Thermostat();
            Remote remote = new Remote();
            remote.SetButton(1, new TurnThermostatOn(thermostat));
            remote.SetButton(1, new TurnThermostatUp(thermostat));
            remote.SetButton(1, new TurnThermostatUp(thermostat));
            string expected = "On, temperature is set to 2";
            
            //Act
            remote.PressButton(1);
            
            //Assert
            Assert.AreEqual(expected, thermostat.ToString());
        }
        
        [Test]
        public void Should_TurnDownThermostat_When_AssignedButtonIsPressed()
        {
            //Arrange
            Thermostat thermostat = new Thermostat();
            Remote remote = new Remote();
            remote.SetButton(1, new TurnThermostatOn(thermostat));
            remote.SetButton(1, new TurnThermostatUp(thermostat));
            remote.SetButton(1, new TurnThermostatUp(thermostat));
            remote.SetButton(1, new TurnThermostatDown(thermostat));
            string expected = "On, temperature is set to 1";
            
            //Act
            remote.PressButton(1);
            
            //Assert
            Assert.AreEqual(expected, thermostat.ToString());
        }

        [Test]
        public void Should_UndoLastAction_When_AssignedButtonIsPressed()
        {
            //Arrange
            Light light = new Light();
            Fan fan = new Fan();
            Remote remote = new Remote();
            remote.SetButton(1, new TurnLightOn(light));
            remote.SetButton(2, new TurnFanOn(fan));
            bool outcome1 = false;
            bool outcome2 = false;
            
            //Act
            remote.PressButton(1);
            remote.PressButton(2);
            remote.Undo();

            if (light.ToString() == "On" && fan.ToString() == "Off")
                outcome1 = true;
            
            remote.Undo();
            
            if (light.ToString() == "Off" && fan.ToString() == "Off")
                outcome2 = true;
            
            //Assert
            Assert.True(outcome1 && outcome2);
        }
    }
}