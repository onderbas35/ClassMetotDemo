using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Adi = "Ahmet";
            customer1.Soyadi = "AYLAK";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Adi = "Behcet";
            customer2.Soyadi = "BAKIR";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Adi = "Cevdet";
            customer3.Soyadi = "CEYLAN";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Adi = "Davut";
            customer4.Soyadi = "DEMİR";

            Customer[] customers = new Customer[] {customer1, customer2, customer3, customer4 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Adi + " " + customer.Soyadi);
            }
            Console.WriteLine("foreach döngüsü Listeleme Bitti");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("-----------Metotlar------------");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(customer1);
            Console.WriteLine(" ");
            customerManager.Duzenle(customer2);
            Console.WriteLine(" ");
            customerManager.Listele(customer3);
            Console.WriteLine(" ");
            customerManager.Sil(customer4);


        }
    }
}
