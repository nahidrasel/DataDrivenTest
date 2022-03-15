using NUnit.Framework;

namespace DataDrivenTest
{
    public class ParameterizingTests
    {
        private readonly object adminPage;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddRoom([Values("9","999")]string roomNumber,
            [Values("9","999")]string Price, [Values]bool accessible, [Values] RoomType roomType)
        {
            var originalRoomsCount = adminPage.GetRooms().Count;
            var room = new Room();
            {
                roomNumber=roomNumber,
                    Type= RoomType.Family,
                    Price=Price,
                    Accessible=true,
                    HasWifi=true,
                    HasView=true
            };
        }

        public class RoomType
        {
        }

        private class Room
        {
            public Room()
            {
            }
        }
    }
}