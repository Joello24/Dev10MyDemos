using RoomCalculator.Services;
using RoomCalculator.Views;
using RoomCalculator.Model;

namespace RoomCalculator.Workflows
{
    class Workflow
    {
        public ConsoleIO _ui;
        public WallpaperService _service;

        public Workflow(ConsoleIO ui, WallpaperService service)
        {
            _ui = ui;
            _service = service;
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                RectangularRoom room = CreateRoom();
                WallpaperRoll roll = CreateWallpaperRoll();
                int rollsRequired = _service.RollsOfWallpaperForRoom(room, roll);
                decimal costOfRoom = _service.CostOfRoom(room, roll);

                DisplayResults(room, roll, rollsRequired, costOfRoom);
                // Go again?
                string response = _ui.GetString("Again?  (Y/n)");
                if (response.ToUpper() == "Y")
                {
                    isRunning = true;
                } else
                {
                    isRunning = false;
                }
            }
        }

        private RectangularRoom CreateRoom()
        {
            _ui.Display("Enter dimensions of wall 1: ");
            Wall wallOne = CreateWall();
            _ui.Display("Enter dimensions of wall 2: ");
            Wall wallTwo = CreateWall();

            RectangularRoom result = new RectangularRoom();
            result.LongWall = wallOne;
            result.ShortWall = wallTwo;
            return result;
        }

        private Wall CreateWall()
        {
            decimal len = _ui.GetDecimal("Length");
            decimal height = _ui.GetDecimal("Height");
            return new Wall(len, height);
        }

        private WallpaperRoll CreateWallpaperRoll()
        {
            decimal size = _ui.GetDecimal("Enter square footage of wallpaper roll");
            decimal cost = _ui.GetDecimal("Enter cost per wallpaper roll");

            return new WallpaperRoll(size, cost);
        }

        private void DisplayResults(
            RectangularRoom room, 
            WallpaperRoll roll, 
            int numberOfRolls, 
            decimal costOfRoom)
        {
            // ui display calls
            _ui.Display("=========================");
            _ui.Display("For a room with walls of the following dimensions: ");
            _ui.Display($"{room.LongWall.Height} x {room.LongWall.Width}");
            _ui.Display($"{room.ShortWall.Height} x {room.ShortWall.Width}");
            _ui.Display($"The room has a total wall area of {room.WallSquareFootage} sq. feet");
            _ui.Display("");
            _ui.Display($"Wallpaper is {roll.Cost:c} per roll of {roll.Size} sq feet and you will need {numberOfRolls}.");
            _ui.Display($"Total cost: {costOfRoom:c}");
            _ui.Display("=========================");
        }
    }
}
