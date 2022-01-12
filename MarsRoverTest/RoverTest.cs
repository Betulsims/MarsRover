using Mars_Rover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTest
{
    [TestClass]
    public class RoverTest
    {
        [TestMethod]
        public void It_Tests_Rovers_Direction_By_Given_Coordinates()
        {
            var rover = new Rover(new Position { CurrentDirection = "N", DirectionInput = "LMLMLMLMM", FirstCoordinate = 1, SecondCoordinate = 2 });
            var finalDirection = rover.RotateMoveSettle();
            Assert.AreEqual("1 3 N", finalDirection);
        }
    }
}
