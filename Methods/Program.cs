﻿class Product
{

    static void Main(string[] args)
    {

        Product product1 = new Product();
        product1.Adi = "Elma";
        product1.Fiyati = 15;
        product1.Aciklama = "Amasya Elması";


        Product product2 = new Product();
        product2.Adi = "Karpuz";
        product2.Fiyati = 80;
        product2.Aciklama = "Diyarbakır";

        Product[] products = new Product[] { product1, product2 };

        foreach (Product product in products)
        {
            Console.WriteLine(product.Adi);
  
        }


    }

}