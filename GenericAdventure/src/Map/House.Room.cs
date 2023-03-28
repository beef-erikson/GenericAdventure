namespace GenericAdventure.Map;
using Text;

public partial class House
{
    private int CalculateRoomIndex(int column, int row)
    {
        return Math.Clamp(column, -1, Width) + Math.Clamp(row, -1, Height) * Width;
    }

    public void CreateRooms(int width, int height)
    {
        Width = Math.Clamp(width, 2, 10);
        Height = Math.Clamp(height, 2, 10);

        var totalRooms = Width * Height;

        Rooms = new Room[totalRooms];

        for (var i = 0; i < totalRooms; i++)
        {
            var tempRoom = new Room();

            var column = i % Width;
            var row = i / Width;

            tempRoom.Name = string.Format(Text.Language.DefaultRoomName, i, column, row);

            if (column < Width - 1)
            {
                tempRoom.Neighbors[Directions.East] = CalculateRoomIndex(column + 1, row);
            }

            if (column > 0)
            {
                tempRoom.Neighbors[Directions.West] = CalculateRoomIndex(column - 1, row);
            }

            if (row < Height - 1)
            {
                tempRoom.Neighbors[Directions.South] = CalculateRoomIndex(column, row + 1);
            }

            if (row > 0)
            {
                tempRoom.Neighbors[Directions.North] = CalculateRoomIndex(column, row - 1);
            }

            Rooms[i] = tempRoom;
        }
    }
}