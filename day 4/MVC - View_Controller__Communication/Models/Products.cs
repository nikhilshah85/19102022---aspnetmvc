namespace MVC___View_Controller__Communication.Models
{
    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new Products(){ pId=102, pName="IPhone", pCategory="Electronics", pIsInStock=false, pPrice=150000},
        };

        public List<Products> GetAllProducts()
        {
            return pList;
        }

        public string AddProduct(Products newProduct)
        {
            //you can do validation of values coming from user and throw exception if value is not as per requirement
            //you can also push the value back to database
            pList.Add(newProduct);
            return "Product Added Successfully";
        }
    }
}
