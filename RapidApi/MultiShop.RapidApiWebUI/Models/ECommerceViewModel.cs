namespace MultiShop.RapidApiWebUI.Models
{
    public class ECommerceViewModel
    {
        public class RootObject
        {
            public string status { get; set; }
            public string request_id { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public List<Product> products { get; set; }
        }

        public class Product
        {
            public string product_id { get; set; }
            public string product_title { get; set; }
            public string product_description { get; set; }
            public string[] product_photos { get; set; }
            public float product_rating { get; set; }
            public string product_page_url { get; set; }
            public Offer offer { get; set; }
        }

        public class Offer
        {
            public string offer_id { get; set; }
            public string price { get; set; }
            public string store_name { get; set; }
        }
    }
}
