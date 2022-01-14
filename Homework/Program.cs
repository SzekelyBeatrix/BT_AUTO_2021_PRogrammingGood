﻿
using Homework.BuildingFolder;
using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        private static readonly int MAX_CAPACITY = 300;
        static void Main(string[] args)
        {
            try
            {
                var building = new Building { Floors = GetFloors() };
                Console.WriteLine(building.GetNumberOfFloors());
                var capacity = building.TotalCapacity();
                if (capacity > MAX_CAPACITY)
                    throw new Exception("Max capacity exeeded");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static List<Floor> GetFloors()
        {
            var floors = new List<Floor>();
            floors.Add(new Floor
            {
                FloorNumber = 0,
                Rooms = GetRooms()
            });

            floors.Add(new Floor
            {
                FloorNumber = 1,
                Rooms = GetRooms()
            });

            floors.Add(new Floor
            {
                FloorNumber = 2,
                Rooms = GetRooms()
            });

            floors.Add(new Floor
            {
                FloorNumber = 3,
                Rooms = GetRooms()
            });

            floors.Add(new Floor
            {
                FloorNumber = 4,
                Rooms = GetRooms()
            });

            return floors;
        }
        public static List<Room> GetRooms()
        {
            var rooms = new List<Room>();
            rooms.Add(new Room
            {
                RoomType = RoomType.DepositSpace,
                Accessories = new List<string> { "chairs", "wardrobe" },
                Capacity = 10,
                RoomArea = 15.2
            });

            rooms.Add(new Room
            {
                RoomType = RoomType.Kitchen,
                Accessories = new List<string> { "forks", "plates" },
                Capacity = 20,
                RoomArea = 34
            });

            rooms.Add(new Room
            {
                RoomType = RoomType.WorkingSpace,
                Accessories = new List<string> { "laptops", "desks" },
                Capacity = 200,
                RoomArea = 100
            });

            rooms.Add(new Room
            {
                RoomType = RoomType.MeetingRoom,
                Accessories = new List<string> { "video projector", "bean bag" },
                Capacity = 10,
                RoomArea = 20
            });

            return rooms;
        }
    }
}