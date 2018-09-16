using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseHelpers.Helpers
{
    // esta es laforma de hacer binding in windows forms con el form TestCodeFirstBindingForms.cs
    // http://msdn.microsoft.com/en-us/data/jj682076
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }
        //public virtual Category Category { get; set; }
    }

    //public class Category
    //{
    //    private readonly ObservableListSource<Product> _products =
    //            new ObservableListSource<Product>();

    //    public int CategoryId { get; set; }
    //    public string Name { get; set; }
    //    public virtual ObservableListSource<Product> Products { get { return _products; } }
    //}

    //public class ObservableListSource<T> : ObservableCollection<T>, IListSource
    //    where T : class
    //{
    //    private IBindingList _bindingList;

    //    bool IListSource.ContainsListCollection { get { return false; } }

    //    IList IListSource.GetList()
    //    {
    //        return _bindingList ?? (_bindingList = this.ToBindingList());
    //    }
    //}

    //public class ProductContext : DbContext
    //{
    //    public DbSet<Category> Categories { get; set; }
    //    public DbSet<Product> Products { get; set; }
    //}

    // luego se a;adio un datasource de cada clase en este archivo
}
