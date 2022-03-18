using System;

using RoomCalculator.Model;
using RoomCalculator.Services;

namespace RoomCalculator
{
    class TestCases
    {
        public bool Run()
        {
            bool result = true;

            if (result)
            {
                result = TestWallArea();
            }
            if (result)
            {
                result = TestRectangularRoom();
            }
            if (result)
            {
                result = TestRollsPerRoom();
            }
            if (result)
            {
                result = TestCostOfRoom();
            }

            return result;
        }

        public bool TestWallArea()
        {
            Wall testWall = new Wall(13, 10);
            decimal expectedArea = 130;

            Console.Write("TestWallArea: ");
            if (testWall.Area == expectedArea) {
                Console.WriteLine("Passed");
                return true;
            } else
            {
                Console.WriteLine($"Failed:  Expected {expectedArea}, got {testWall.Area}");
                return false;
            }
            
        }

        public bool TestRectangularRoom()
        {
            Wall wallA = new Wall(13, 10);
            Wall wallB = new Wall(10, 10);
            RectangularRoom testRoom = new RectangularRoom();
            testRoom.ShortWall = wallA;
            testRoom.LongWall = wallB;

            decimal expectedArea = 460;

            Console.Write("TestRectangularRoom: ");
            if (testRoom.WallSquareFootage == expectedArea)
            {
                Console.WriteLine("Passed");
                return true;
            }
            else
            {
                Console.WriteLine($"Failed:  Expected {expectedArea}, got {testRoom.WallSquareFootage}");
                return false;
            }

        }

        public bool TestRollsPerRoom()
        {
            // Setting up the test
            WallpaperRoll roll = new WallpaperRoll(45m, 10m);
            Wall w1 = new Wall(5, 2); // *2 = 20
            Wall w2 = new Wall(20, 2); // *2 = 80
            RectangularRoom r = new RectangularRoom();
            r.ShortWall = w1;
            r.LongWall = w2;

            WallpaperService service = new WallpaperService();

            // Executing the code
            int actualRollCount = service.RollsOfWallpaperForRoom(r, roll);
            int expected = 3;

            // Validating the results
            Console.Write("TestRollsPerRoom: ");
            if (actualRollCount == expected)
            {
                Console.WriteLine("Passed");
                return true;
            }
            else
            {
                Console.WriteLine($"Failed:  Expected {expected}, got {actualRollCount}");
                return false;
            }
        }

        public bool TestCostOfRoom()
        {
            // Setting up the test
            WallpaperRoll roll = new WallpaperRoll(45m, 10m);
            Wall w1 = new Wall(5, 2); // *2 = 20
            Wall w2 = new Wall(20, 2); // *2 = 80
            RectangularRoom r = new RectangularRoom();
            r.ShortWall = w1;
            r.LongWall = w2;

            WallpaperService service = new WallpaperService();

            // Executing the code
            decimal actualCost = service.CostOfRoom(r, roll);
            decimal expected = 30.00m;

            // Validating the results
            Console.Write("TestCostOfRoom: ");
            if (actualCost == expected)
            {
                Console.WriteLine("Passed");
                return true;
            }
            else
            {
                Console.WriteLine($"Failed:  Expected {expected}, got {actualCost}");
                return false;
            }
        }
    }
}
