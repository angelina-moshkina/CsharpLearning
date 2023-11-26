using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    internal class Program
    {
        static bool CheckIfStringContainsText(string inputValue, string compareValue)
        {
            bool result = inputValue.StartsWith(compareValue);
            return result;
        }
        static void Main(string[] args)
        {
            Order order1 = new Order ("Whyskas", 13.50f, 3753361728362, "Gagarina 150 / 250");
            Order order2 = new Order("Whiskas", 15.70f, 3752961728361, "Voronicha 26/140");
            Order order3 = new Order("Kiteket", 99.90f, 5441234599, "Mira 10/132");
            Order order4 = new Order("Purina", 20.90f, 5441234599, "Mira 10/132");

            Order[] orders = { order1, order2, order3, order4 };

            order1.ProductPrice = 10001f;
            order1.BuyerPhoneNumber = 012345678901234;
            order3.BuyerPhoneNumber = 3753361728361;

            //TASK_1.2 вывести в цикле на экран полную информацию о всех заказах в массиве
            foreach (Order item in orders)
            { 
                    Console.WriteLine("TASK_1.2 " + item.GetFullOrderInfo());
            }

            //TASK_2.4 Вывести на экран полную информацию о заказах, телефонный номер заказчика которых начинается на 375.
            foreach (Order item in orders)
            {
                if (CheckIfStringContainsText(item.BuyerPhoneNumber.ToString(), "375") == true)
                {
                    Console.WriteLine("TASK_2.4 " + item.GetFullOrderInfo());
                }
            }

            //TASK_2.5 Вывести на экран полную информацию о заказах, стоимость которых не превышает 20 и имя товара начинается на "Whys".
            foreach (Order item in orders)
            {
                if (item.ProductPrice < 20 && CheckIfStringContainsText(item.ProductName, "Whys") == true)
                {
                    Console.WriteLine("TASK_2.5 " + item.GetFullOrderInfo());
                }
            }
            
        }
    }
}