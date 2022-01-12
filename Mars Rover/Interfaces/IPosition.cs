namespace Mars_Rover
{
    public interface IPosition
    {
        void GetNextDirectionForLeft(string currentDirection);
        void GetNextDirectionForRight(string currentDirection);
        void GetNextPositionForMovement(int currentXAxisCoordinate, int currentYAxisCoordinate, string currentDirection);
    }
}
