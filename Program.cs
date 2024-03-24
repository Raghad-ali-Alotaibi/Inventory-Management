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

    public Item(string name, int quantity, DateTime createdDate)
    {
        Name = name;
        Quantity = quantity;
        CreatedDate = createdDate;
    }


}