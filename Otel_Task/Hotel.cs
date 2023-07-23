using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Otel_Task
{
    internal class Hotel
    {
        public int Id { get; set; }
        private static int _Id = 0;
        public string Hotelname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public byte HotelStar { get; set; }
        private int RoomCount { get; set; }
        public Room[] Rooms { get; set; }
        public int StandardRoomCount { get; set; }
        public int VipRoomCount { get; set; }

        public Hotel(string hotelName, string address, string phoneNumber, int roomCount, int standardRoomCount, int vipRoomCount, byte star)
        {
            Id = _Id++;
            Hotelname = hotelName;
            Address = address;
            PhoneNumber = phoneNumber;
            StandardRoomCount = standardRoomCount;
            VipRoomCount = vipRoomCount;
            RoomCount = StandardRoomCount + VipRoomCount;
            Rooms = new Room[RoomCount];
            HotelStar = star;
            CreatRoom();
        }
        public void CreatRoom()
        {
            int id = 1;
            for (int i = 0; i < StandardRoomCount; i++)
            {

                Room room = new Room
                {
                    Id = id,
                    RoomStatus = false,
                    RoomType = "Standart"
                };
                id++;
                Rooms[i] = room;
            }
            for (int i = StandardRoomCount; i < RoomCount; i++)
            {
                Room room = new Room
                {
                    Id = id,
                    RoomStatus = false,
                    RoomType = "VIP"
                };
                id++;
                Rooms[i] = room;
            }
        }
        public void ShowRoom()
        {
            string text = "";
            foreach (var item in Rooms)
            {
                text = item.RoomStatus == false ? "Boş" : "Dolu";
                Console.WriteLine($"Otaq nomresi: {item.Id} Otaq Tipi: {item.RoomType} Otaq statusu: {text}");
            }
        }

        public void SetCustomer(int Id)
        {
            Room tempRoom = null;

            for (int i = 0; i < Rooms.Length; i++)
            {
                if (Rooms[i].Id == Id)
                {
                    tempRoom = Rooms[i];

                    if (tempRoom.RoomStatus)
                    {
                        Console.WriteLine($"{tempRoom.Id} nömrəli otaq artıq doludur. Zəhmət olmasa başqa otaq seçin.");
                    }
                    else
                    {
                        tempRoom.RoomStatus = true;
                        Console.WriteLine($"Müştəri uğurla yerləşdirildi. Otaq nömrəsi: {tempRoom.Id}, Otaq Tipi: {tempRoom.RoomType}");
                    }
                    break;
                }
            }

            ShowRoom();
        }

    }
}
