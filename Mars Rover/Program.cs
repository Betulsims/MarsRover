using System;

namespace Mars_Rover
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string firstRoverCoordinates, firstRoverdirectionInput, secondRoverCoordinates, secondRoverdirectionInput, plateauCoordinates = String.Empty;
                plateauCoordinates = Console.ReadLine();
                string[] plateauCoordinatesArr = plateauCoordinates.Split(' ');

                Plateau plateau = new Plateau { XAxis = Convert.ToInt32(plateauCoordinatesArr[0]), YAxis = Convert.ToInt32(plateauCoordinatesArr[1]) };
                plateau.ValidatePlateauCoordinates();

                firstRoverCoordinates = Console.ReadLine();
                string[] firstRoverCoordinatesArr = firstRoverCoordinates.Split(' ');
                firstRoverdirectionInput = Console.ReadLine();

                secondRoverCoordinates = Console.ReadLine();
                string[] secondRoverCoordinatesArr = secondRoverCoordinates.Split(' ');
                secondRoverdirectionInput = Console.ReadLine();

                Rover firstRover = new Rover(new Position
                {
                    DirectionInput = firstRoverdirectionInput.ToUpper(),
                    FirstCoordinate = Convert.ToInt32(firstRoverCoordinatesArr[0]),
                    SecondCoordinate = Convert.ToInt32(firstRoverCoordinatesArr[1]),
                    CurrentDirection = firstRoverCoordinatesArr[2].ToUpper()

                });

                var finalDirectionForFirstRover = firstRover.RotateMoveSettle();

                Rover secondRover = new Rover(new Position
                {
                    DirectionInput = secondRoverdirectionInput.ToUpper(),
                    FirstCoordinate = Convert.ToInt32(secondRoverCoordinatesArr[0]),
                    SecondCoordinate = Convert.ToInt32(secondRoverCoordinatesArr[1]),
                    CurrentDirection = secondRoverCoordinatesArr[2].ToUpper()

                });

                var finalDirectionForSecondRover = secondRover.RotateMoveSettle();

                Console.WriteLine(finalDirectionForFirstRover);
                Console.WriteLine(finalDirectionForSecondRover);
                Console.Read();
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch(NullReferenceException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
