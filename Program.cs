using System;

class Program
{
    static void Main(string[] args)
    {

    }
}

class Item
{
    public string Name { get; }
    private int Quantity { get; set; }

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
}


class Store {
    private List<Item> items =new List<Item>();

    public void AddItem(){

    }
    public void DeleteItem(){

    }

}