using System.Text;

namespace MarketListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int productCount = 0;
            float totalPrice=0;
            StringBuilder productList= new StringBuilder();

            while (true)
            {
                Console.WriteLine("Malin qiymetini daxil ediniz");
                float price = float.Parse(Console.ReadLine());

                if (price !=0) {

                    Console.WriteLine("Malin adini daxil ediniz");
                    string productName = Console.ReadLine();
                    productCount++;
                    totalPrice= totalPrice+price;
                    productList.Append(productName).Append("--").Append(price).Append("\n");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Gunluk satilan mallarin sayisi {productCount}");
            Console.WriteLine($"Gunluk satilan mallarin toplam degeri {totalPrice}");
            Console.WriteLine($"Gunluk satilan mallarin siyahisi");
            Console.WriteLine(productList);

        }
    }
}