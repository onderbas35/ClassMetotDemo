using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine("Tebikler! " + customer.Adi + " Müşteri eklendi");
        }

        public void Listele(Customer customer)
        {
            Console.WriteLine("Tebikler! " + customer.Adi + " Müşteri listelendi");
        }

        public void Sil(Customer customer)
        {
            Console.WriteLine("Tebikler! " + customer.Adi + " Müşteri silindi");
        }

        public void Duzenle(Customer customer)
        {
            Console.WriteLine("Tebikler! " + customer.Adi + " Müşteri düzenlendi");
        }
    }
}
