using System;

class Inventory{
    List<string> ProductList = new List<string>();
    List<int> ProductPrice = new List<int>();

    List<int> ProductQuantity= new List<int> ();
    
    List<bool> isProductAvailable = new List<bool> ();

    static void Main (string[] args)

    {
        Inventory inventory = new Inventory();
        while (true) 
        {

    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. View Product");
    Console.WriteLine("3. Update stock");
    Console.WriteLine("4. Check Product Availability");
    Console.WriteLine("4. Exit");
        

        string choice = Console.ReadLine();

        switch (choice)
        {       case "1":
                inventory.AddProduct();
                break;
                case "2":
                inventory.ViewProduct();
                break;
                case "3":
                inventory.UpdateStock();
                break;
                case "4":
                inventory.ProductAvailability();
                break;
            case "5":
                inventory.ProductSales();
                break;
                case "6":
                return;
            default:
                Console.WriteLine("Invalid choice, try again.");
                break;
        }
        }

    
    
    }
            public void AddProduct()
            {
                Console.WriteLine("Enter Product Name:");
                string Product = Console.ReadLine();
                ProductList.Add(Product);
                Console.WriteLine("Enter Product Price:");
                int Price = int.Parse(Console.ReadLine());
                ProductPrice.Add(Price);
                Console.WriteLine("Enter Product Quantity:");
                int Quantity = int.Parse(Console.ReadLine());
                ProductQuantity.Add(Quantity);
                isProductAvailable.Add(true);
                Console.WriteLine("Product added successfully.");
            }

            public void ViewProduct(){
                Console.WriteLine("Product List");
                for (int i = 0; i < ProductList.Count; i++)
                {
                    Console.WriteLine(i+1 + ". " + ProductList[i] + " - " + ProductPrice[i] + " - " + ProductQuantity[i] + " - " + (isProductAvailable[i] ? "Available" : "Not Available"));
                }

            }

            public void UpdateStock(){
                Console.WriteLine("Enter Product Number to update stock:");
                int ProductNumber = int.Parse(Console.ReadLine());

                if (ProductNumber < 0 || ProductNumber >= ProductList.Count)
                {
                    Console.WriteLine("Invalid Product Number.");
                    return;
                }

                Console.WriteLine("Enter new stock quantity:");
                int newQuantity = int.Parse(Console.ReadLine());
                if (newQuantity < 0)
                {
                    Console.WriteLine("Invalid Quantity.");
                    return;
                }
                ProductQuantity[ProductNumber-1] = newQuantity;
                Console.WriteLine("Stock updated successfully.");
            }

            public void ProductAvailability(){
                Console.WriteLine("Enter Product number to check availability:");
                if (int.TryParse(Console.ReadLine(), out int productNumber))
                {
                    if (productNumber < 0 || productNumber >= ProductList.Count)
                    {
                        Console.WriteLine("Invalid Product Number.");
                        return;
                    }

                    if (isProductAvailable[productNumber - 1])
                    {
                        Console.WriteLine("Product is available.");
                    }
                    else
                    {
                        Console.WriteLine("Product is not available.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Product Number.");
                }

            
            }

                    
                
                public void ProductSales(){
                Console.WriteLine("Enter product number to be sold:");
                int ProductNumber = int.Parse(Console.ReadLine());
                 if (ProductNumber < 0 || ProductNumber >= ProductList.Count) 
                 {
                    Console.WriteLine("Invalid Product Number.");
                    return;
                 }
                    
                Console.WriteLine("Enter quantity to be sold:");
                int Quantity = int.Parse(Console.ReadLine());
                if (Quantity < 0 || Quantity > ProductQuantity[ProductNumber - 1])
                {
                    Console.WriteLine("Invalid Quantity.");
                    return;
                }
                ProductQuantity[ProductNumber - 1] -= Quantity;
                Console.WriteLine("Product sold successfully.");


                    }

}

