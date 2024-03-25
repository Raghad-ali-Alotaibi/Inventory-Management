using ItemSpace;
namespace StoreSpace;

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