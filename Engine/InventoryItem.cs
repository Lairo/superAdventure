using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Engine;

namespace Engine
{
    public class InventoryItem
    {
        public Item Details { get; set; }
        public int Quantity { set; get; }

        public InventoryItem(Item details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
