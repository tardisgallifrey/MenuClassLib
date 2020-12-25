using System;
using System.Linq;
using MenuClassLib.Data;
using MenuClassLib.Models;

namespace MenuClassLib
{
    public class MenuBuilder
    {
        int id = 1;
        Menu menu = new Menu();
        MenuContext db = new MenuContext();

        public MenuBuilder(string Menu_name)
        {
            if(db.Menu.Count() > 0)
            {
                var max_record = db.Menu.Last();
                id = max_record.Id + 1;
            }

            menu.Id = id;
            menu.Name = Menu_name;

            db.Menu.Add(menu);
        }

        public void Show()
        {
            Console.Clear();
            Console.WriteLine(menu.Id);

        }
    }
}