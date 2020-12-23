using System.Collections.Generic;

namespace MenuClassLib.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<MenuItem> Choices { get; set; } = new List<MenuItem>();
    }
}