namespace InventorySpace
{
    public enum SortOrder
    {
        ASC,
        DESC
    }

    class Store
    {
        private List<Item> items = new List<Item>();

        public int MaximumCapacity { get; set; }
        // Contructor 
        public Store(int capacity)
        {
            MaximumCapacity = capacity;
        }

        public void AddItem(Item item)
        {
            if (items.Count < MaximumCapacity)
            {
                bool isItemExist = items.Any((newItem) => newItem.Name == item.Name);
                if (isItemExist)
                {
                    Console.WriteLine("Item with the same name already exists in the store.");
                    return;
                }
                items.Add(item);
            }
            else
            {
                Console.WriteLine("Store is at maximum capacity. Cannot add more items.");
            }
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

        public List<Item> SortByDate(SortOrder order)
        {
            if (order == SortOrder.ASC)
            {
                return items.OrderBy(item => item.CreatedDate).ToList();
            }
            else
            {
                return items.OrderByDescending(item => item.CreatedDate).ToList();
            }
        }

    }
}

