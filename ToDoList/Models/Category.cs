using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Category
    {
        public Category()
        {
            this.JoinEntities = new HashSet<CategoryItem>(); //Collection navigation property - contains a reference to many related Items. Without this property, we won't be able to access related Items in our controllers and views
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CategoryItem> JoinEntities { get; set; }
    }
}