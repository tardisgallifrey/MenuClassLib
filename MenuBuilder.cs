using System;
using System.Linq;
using MenuClassLib.Data;
using MenuClassLib.Models;

namespace MenuClassLib
{
    public class MenuBuilder
    {
        int id = 1;

        public MenuBuilder(string Menu_name)
        {
            using var db = new MenuContext();
            {
                if(db.Menu.Count() > 0)
                {
                    var max_record = db.Menu.Last();
                    id = max_record.Id + 1;
                }

                var menu = new Menu()
                {
                    Id = id,
                    Name = Menu_name
                };

                db.Menu.Add(menu);
            }

        }

    }
}