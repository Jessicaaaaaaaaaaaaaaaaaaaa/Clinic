using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI_DTO
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public IEnumerable<MenuItemDTO> MenuItemsDTO { set; get; }  
    }
}
