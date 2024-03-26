using System;
using System.Collections.Generic;



namespace InventorySpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Items
            var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
            var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
            var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
            var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));

            // Maximum capacity is 3
            var store = new Store(3);

            // adding Item
            store.AddItem(waterBottle);
            store.AddItem(chocolateBar);
            store.AddItem(notebook);
            store.AddItem(pen);

            // Delete Item
            store.DeleteItem("Water Bottle 1");

            // print Current Volume
            Console.WriteLine($"Current Volume: {store.GetCurrentVolume()}");

            // Find Item By Name
            Console.WriteLine($"{store.FindItemByName("Pen")}");

            // Print sorted collection by name in ascending order
            var collections = store.SortByNameAscto();
            Console.WriteLine("The sorted collection by name in ascending order: ");
            foreach (var item in collections)
            {
                Console.WriteLine($"{item}");
            }

            // Print sorted collection by date in descending order
            var collectionSortedByDate = store.SortByDate(SortOrder.DESC);
            Console.WriteLine("The sorted collection by date in descending order: ");
            foreach (var item in collectionSortedByDate)
            {
                Console.WriteLine($"{item}");
            }

            // Print New Arrival and Old items. 
            var groupByDate = store.GroupByDate();
            foreach (var group in groupByDate)
            {
                Console.WriteLine($"{group.Key} Items:");
                foreach (var item in group.Value)
                {
                    Console.WriteLine($" - {item.Name}, Created: {item.CreatedDate.ToShortDateString()}");
                }
            }
        }
    }
}

