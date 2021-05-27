using System;
using System.Collections.Generic;
using Ecommerce.Domains;

namespace Ecommerce.Seed
{
    public class OrderSeed
    {
        public static void getOrderList()
        {
            var list = new List<Order>();
            
            list.Add(new Order(){Address= "Order adress test 01", CreateAt = DateTime.Now, DeliveredAt = DateTime.Now.AddHours(1), Number = 1, TeamId = 1});
            list.Add(new Order(){Address= "Order adress test 02", CreateAt = DateTime.Now, DeliveredAt = DateTime.Now.AddHours(1), Number = 2, TeamId = 1});
            list.Add(new Order(){Address= "Order adress test 03", CreateAt = DateTime.Now, DeliveredAt = DateTime.Now.AddHours(1), Number = 3, TeamId = 1});
            list.Add(new Order(){Address= "Order adress test 04", CreateAt = DateTime.Now, DeliveredAt = DateTime.Now.AddHours(1), Number = 4, TeamId = 2});
            list.Add(new Order(){Address= "Order adress test 05", CreateAt = DateTime.Now, DeliveredAt = DateTime.Now.AddHours(2), Number = 5, TeamId = 2});
            list.Add(new Order(){Address= "Order adress test 06", CreateAt = DateTime.Now, DeliveredAt = DateTime.Now.AddHours(2), Number = 6, TeamId = 3});
            list.Add(new Order(){Address= "Order adress test 07", CreateAt = DateTime.Now, DeliveredAt = DateTime.Now.AddHours(2), Number = 7, TeamId = 3});
            list.Add(new Order(){Address= "Order adress test 08", CreateAt = DateTime.Now, DeliveredAt = DateTime.Now.AddHours(2), Number = 8, TeamId = 3});
            list.Add(new Order(){Address= "Order adress test 09", CreateAt = DateTime.Now, DeliveredAt = DateTime.Now.AddHours(2), Number = 9, TeamId = 3});
            list.Add(new Order(){Address= "Order adress test 10", CreateAt = DateTime.Now, DeliveredAt = DateTime.Now.AddHours(2), Number = 10, TeamId = 3});
        }

        public static void getTeamList()
        {
            var list = new List<Team>();
            
            list.Add(new Team(){Description = "Team test 01", Id = 1, Name = "Team 01", VehiclePlate = "XXX1111"});
            list.Add(new Team(){Description = "Team test 02", Id = 2, Name = "Team 02", VehiclePlate = "XXX2222"});
            list.Add(new Team(){Description = "Team test 03", Id = 3, Name = "Team 03", VehiclePlate = "XXX3333"});
        }

        public static void GetItemList()
        {
            var list = new List<Item>();
            list.Add(new Item(){Description = "item teste 01 order 01", Id = 1, Name = "Item 01", Value = 1, OrderNumber = 1});
            list.Add(new Item(){Description = "item teste 02 order 01", Id = 2, Name = "Item 02", Value = 1, OrderNumber = 1});
            list.Add(new Item(){Description = "item teste 03 order 01", Id = 3, Name = "Item 03", Value = 1, OrderNumber = 1});
            
            list.Add(new Item(){Description = "item teste 01 order 02", Id = 4, Name = "Item 01", Value = 1, OrderNumber = 2});
            list.Add(new Item(){Description = "item teste 02 order 02", Id = 5, Name = "Item 02", Value = 1, OrderNumber = 2});
            list.Add(new Item(){Description = "item teste 03 order 02", Id = 6, Name = "Item 03", Value = 1, OrderNumber = 2});
            
            list.Add(new Item(){Description = "item teste 01 order 03", Id = 7, Name = "Item 01", Value = 1, OrderNumber = 3});
            list.Add(new Item(){Description = "item teste 02 order 03", Id = 8, Name = "Item 02", Value = 1, OrderNumber = 3});
            list.Add(new Item(){Description = "item teste 03 order 03", Id = 9, Name = "Item 03", Value = 1, OrderNumber = 3});
            
            list.Add(new Item(){Description = "item teste 01 order 04", Id = 10, Name = "Item 01", Value = 1, OrderNumber = 4});
            list.Add(new Item(){Description = "item teste 02 order 04", Id = 11, Name = "Item 02", Value = 1, OrderNumber = 4});
            list.Add(new Item(){Description = "item teste 03 order 04", Id = 12, Name = "Item 03", Value = 1, OrderNumber = 4});
            
            list.Add(new Item(){Description = "item teste 01 order 05", Id = 13, Name = "Item 01", Value = 1, OrderNumber = 5});
            list.Add(new Item(){Description = "item teste 02 order 05", Id = 14, Name = "Item 02", Value = 1, OrderNumber = 5});
            list.Add(new Item(){Description = "item teste 03 order 05", Id = 15, Name = "Item 03", Value = 1, OrderNumber = 5});
            
            list.Add(new Item(){Description = "item teste 01 order 06", Id = 16, Name = "Item 01", Value = 1, OrderNumber = 6});
            list.Add(new Item(){Description = "item teste 02 order 06", Id = 17, Name = "Item 02", Value = 1, OrderNumber = 6});

            list.Add(new Item(){Description = "item teste 01 order 07", Id = 18, Name = "Item 01", Value = 1, OrderNumber = 7});
            list.Add(new Item(){Description = "item teste 02 order 07", Id = 19, Name = "Item 02", Value = 1, OrderNumber = 7});
            list.Add(new Item(){Description = "item teste 03 order 07", Id = 20, Name = "Item 03", Value = 1, OrderNumber = 7});
            
            list.Add(new Item(){Description = "item teste 01 order 08", Id = 21, Name = "Item 01", Value = 1, OrderNumber = 8});
            list.Add(new Item(){Description = "item teste 02 order 08", Id = 22, Name = "Item 02", Value = 1, OrderNumber = 8});

            list.Add(new Item(){Description = "item teste 01 order 09", Id = 23, Name = "Item 01", Value = 1, OrderNumber = 9});
            list.Add(new Item(){Description = "item teste 02 order 09", Id = 24, Name = "Item 02", Value = 1, OrderNumber = 9});
            list.Add(new Item(){Description = "item teste 03 order 09", Id = 25, Name = "Item 03", Value = 1, OrderNumber = 9});
            
            list.Add(new Item(){Description = "item teste 01 order 10", Id = 26, Name = "Item 01", Value = 1, OrderNumber = 10});
            list.Add(new Item(){Description = "item teste 02 order 10", Id = 27, Name = "Item 02", Value = 1, OrderNumber = 10});
        }
    }
}