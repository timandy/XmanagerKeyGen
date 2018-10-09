using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace XmanagerKeygen
{
    public class ProductCollection
    {
        public static readonly ReadOnlyCollection<Product> Default;

        static ProductCollection()
        {
            List<Product> products = new List<Product>
            {
                new Product(ProductCode.Xmanager,2,new DateTime(2003,1,1)),
                new Product(ProductCode.Xshell,2,new DateTime(2004,10,1)),

                new Product(ProductCode.Xmanager, 3,new DateTime(2007, 1, 1)),
                new Product(ProductCode.Xshell, 3,new DateTime(2007, 1, 1)),
                new Product(ProductCode.Xlpd, 3,new DateTime(2007, 1, 1)),
                new Product(ProductCode.Xftp, 3,new DateTime(2007, 1, 1)),
                new Product(ProductCode.Xmanager_Enterprise, 3,new DateTime(2007, 1, 1)),

                new Product(ProductCode.Xmanager, 4,new DateTime(2010, 8, 1)),
                new Product(ProductCode.Xshell, 4,new DateTime(2010, 8, 1)),
                new Product(ProductCode.Xlpd, 4,new DateTime(2010, 8, 1)),
                new Product(ProductCode.Xftp, 4,new DateTime(2010, 8, 1)),
                new Product(ProductCode.Xmanager_Enterprise, 4,new DateTime(2010, 8, 1)),

                new Product(ProductCode.Xmanager, 5,new DateTime(2014, 4, 28)),
                new Product(ProductCode.Xshell, 5,new DateTime(2014, 4, 28)),
                new Product(ProductCode.Xlpd, 5,new DateTime(2014, 4, 28)),
                new Product(ProductCode.Xftp, 5,new DateTime(2014, 4, 28)),
                new Product(ProductCode.Xmanager_Enterprise, 5,new DateTime(2014, 4, 28)),

                new Product(ProductCode.Xmanager, 6,new DateTime(2018, 4, 29)),
                new Product(ProductCode.Xshell, 6,new DateTime(2018, 4, 29)),
                new Product(ProductCode.Xshell_Plus, 6,new DateTime(2018, 4, 29)),
                new Product(ProductCode.Xlpd, 6,new DateTime(2018, 4, 29)),
                new Product(ProductCode.Xftp, 6,new DateTime(2018, 4, 29)),
                new Product(ProductCode.Xmanager_Enterprise, 6,new DateTime(2018, 4, 29))
            };
            Default = new ReadOnlyCollection<Product>(products);
        }
    }
}
