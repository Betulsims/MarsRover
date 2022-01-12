using System;
using System.Linq;
using static Mars_Rover.CommonTypes;

namespace Mars_Rover
{
    public class Rover : IRover
    {
        Position _position;

        #region Constructors
        public Rover(Position position)
        {
            _position = position;
        }

        public Rover()
        {
            
        }
        #endregion

        #region Public Methods
        public string RotateMoveSettle()
        {
            char[] directions = _position.DirectionInput.ToCharArray();

            directions.ToList().ForEach(x =>
            {
                switch (x)
                {
                    case Rotation.Left:
                        _position.GetNextDirectionForLeft(_position.CurrentDirection);
                        break;
                    case Rotation.Right:
                        _position.GetNextDirectionForRight(_position.CurrentDirection);
                        break;
                    case Rotation.Move:
                        _position.GetNextPositionForMovement(_position.FirstCoordinate, _position.SecondCoordinate, _position.CurrentDirection);
                        break;
                    default:
                        throw new ArgumentException($"Invalid Rotation Type: {x}");
                }
            });

            return $"{_position.FirstCoordinate} {_position.SecondCoordinate} {_position.CurrentDirection}";
        }
        #endregion
    }
}
