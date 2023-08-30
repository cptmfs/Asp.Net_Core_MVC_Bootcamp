using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ShoppingListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CartItem>? Products { get; set; } 
        public CartItem Product { get; set; } 
    }
}
