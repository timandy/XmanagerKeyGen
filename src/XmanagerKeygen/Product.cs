using System;

namespace XmanagerKeygen
{
    public class Product
    {
        public ProductCode Code { get; private set; }
        public int Version { get; private set; }
        public DateTime PublishDate { get; private set; }

        public Product(ProductCode code, int version, DateTime publishDate)
        {
            this.Code = code;
            this.Version = version;
            this.PublishDate = publishDate;
        }
    }
}
