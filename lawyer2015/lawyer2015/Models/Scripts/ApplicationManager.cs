using lawyer2015.Models.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lawyer2015.Models.Scripts
{
    public static class ApplicationManager
    {
        public static List<SelectListItem> GetDropDown<T>(DbSet<T> dbSet) where T : CoreTableName
        {
            var list = dbSet.ToList();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            foreach (var item in list)
            {
                SelectListItem i = new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                };
                selectListItems.Add(i);
            }
            return selectListItems;
        }
    }
}