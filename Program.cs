using System;
using System.Collections.Generic;

class Item
{
    public string Name { get; }
    private int quantity;
    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
    private DateTime CreatedDate { get; set; }

    // Contructor 
    public Item(string name, int quantity, DateTime createdDate = default)
    {
        if (quantity < 0)
        {
            throw new Exception("Quantity cannot be negative");
        }
        Name = name;
        Quantity = quantity;
        CreatedDate = createdDate == default ? DateTime.Now : createdDate;
    }
    public override string ToString()
    {
        return $"Item Name: {Name} ,Quantity: {Quantity} , CreatedDate: {CreatedDate} ";
    }
}


class Store
{
    private List<Item> items = new List<Item>();

    public void PrintItem()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"{item}");
        }
    }
    public void AddItem(Item item)
    {
        bool isItemExist = items.Any((newItem) => newItem.Name == item.Name);
        if (isItemExist)
        {
            Console.WriteLine("Item with the same name already exists in the store.");
            return;
        }
        items.Add(item);

    }
    public void DeleteItem(string itemName)
    {
        Item itemToDelete = items.FirstOrDefault(item => item.Name == itemName);
        if (itemToDelete != null)
        {
            items.Remove(itemToDelete);
            Console.WriteLine("Item was Deleted");
        }
        else
        {
            Console.WriteLine("Item not found in the store.");
        }
    }

    public int GetCurrentVolume()
    {
        return items.Sum(item => item.Quantity);
    }

    public Item FindItemByName(string itemName)
    {
        Item itemFind = items.FirstOrDefault(item => item.Name == itemName);
        return itemFind;
    }


    public List<Item> SortByNameAscto()
    {
        return items.OrderBy(item => item.Name).ToList();
    }

}


class Program
{
    static void Main(string[] args)
    {
        var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
        var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
        var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
        var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));


        var store = new Store();

        store.AddItem(waterBottle);
        store.AddItem(chocolateBar);
        store.AddItem(notebook);
        store.AddItem(pen);

        store.DeleteItem("Water Bottle 1");
        Console.WriteLine($"{store.GetCurrentVolume()}");

        Console.WriteLine($"{store.FindItemByName("Pen")}");

        var collections = store.SortByNameAscto();
        foreach (var item in collections)
        {
            Console.WriteLine($"{item}");
        }
    }
}