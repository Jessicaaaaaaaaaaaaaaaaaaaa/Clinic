using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIJames.Models
{
    public class MenuItemViewModel
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public double Price { get; set; }
        public List<MenuItem> MenuItems { set; get; }
    }
}
