using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRestaurantDTO.Information
{
    public static class Queues
    {
        public const string DrinkOrderTaken = "DrinkOrderTaken";
        public const string FoodOrderTaken = "FoodOrderTaken";
        public const string FoodReady = "FoodOrderReady";
        public const string DrinkReady = "DrinkOrderReady";
        public const string GetCheckPaid = "GetCheckPaid";
        public const string TableReady = "TableReady";
        public const string GetSeatedTable = "GetSeatedTable";
        public const string FulfillReservation = "FillReservation";
    }
}