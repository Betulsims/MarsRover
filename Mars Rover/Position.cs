using System;
using static Mars_Rover.CommonTypes;

namespace Mars_Rover
{
    public class Position : IPosition
    {
        #region Private Methods
        private int firstCoordinate;

        private int secondCoordinate;

        private string currentDirection;

        private string directionInput;
        #endregion

        #region Public Methods
        public int FirstCoordinate
        {
            get { return firstCoordinate; }
            set
            {
                if (firstCoordinate != value)
                {
                    if (firstCoordinate < 0) throw new Exception("Coordinates can not be negative.");
                    firstCoordinate = value;
                }
            }
        }

        public int SecondCoordinate
        {
            get { return secondCoordinate; }
            set
            {
                if (secondCoordinate != value)
                {
                    if (secondCoordinate < 0) throw new Exception("Coordinates can not be negative.");
                    secondCoordinate = value;
                }
            }
        }

        public string CurrentDirection
        {
            get { return currentDirection; }
            set
            {
                if (currentDirection != value)
                {
                    currentDirection = value;
                }
            }
        }

        public string DirectionInput
        {
            get { return directionInput; }
            set
            {
                if (directionInput != value)
                {
                    directionInput = value;
                }
            }
        }

        public void GetNextDirectionForLeft(string currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.North:
                    CurrentDirection = Direction.West;
                    break;
                case Direction.West:
                    CurrentDirection = Direction.South;
                    break;
                case Direction.South:
                    CurrentDirection = Direction.East;
                    break;
                case Direction.East:
                    CurrentDirection = Direction.North;
                    break;
                default:
                    throw new ArgumentException($"Invalid Coordinate: {currentDirection}");
            }
        }

        public void GetNextDirectionForRight(string currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.North:
                    CurrentDirection = Direction.East;
                    break;
                case Direction.East:
                    CurrentDirection = Direction.South;
                    break;
                case Direction.South:
                    CurrentDirection = Direction.West;
                    break;
                case Direction.West:
                    CurrentDirection = Direction.North;
                    break;
                default:
                    throw new ArgumentException($"Invalid Coordinate: {currentDirection}");
            }
        }

        public void GetNextPositionForMovement(int currentXAxisCoordinate, int currentYAxisCoordinate, string currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.North:
                    {
                        FirstCoordinate = currentXAxisCoordinate;
                        SecondCoordinate = currentYAxisCoordinate + 1;
                    }
                    break;
                case Direction.East:
                    {
                        FirstCoordinate = currentXAxisCoordinate + 1;
                        SecondCoordinate = currentYAxisCoordinate;
                    }
                    break;
                case Direction.South:
                    {
                        FirstCoordinate = currentXAxisCoordinate;
                        SecondCoordinate = currentYAxisCoordinate - 1;
                    }
                    break;
                case Direction.West:
                    {
                        FirstCoordinate = currentXAxisCoordinate - 1;
                        SecondCoordinate = currentYAxisCoordinate;
                    }
                    break;
                default:
                    throw new ArgumentException($"Invalid Coordinate: {currentDirection}");
            }
        }
        #endregion
    }
}
