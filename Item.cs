namespace ItemSpace;

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