using System;

namespace Container_4_1_
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine(
              "1.Add custumer\n" +
              "2.Add product cost \n" +
              "3.Avverage of costs\n" +
              "4.Search custumer\n" +
              "5.Show all info about custumers\n" +
              "6.Exit\n");
        }
        static void Main(string[] args)
        {
            bool pointer = true;
            int menuAnswer, newCost;
            string fam;


            Markt contProd = new Markt("Market");

            while (pointer)
            {
                menu();
                menuAnswer = Convert.ToInt32(Console.ReadLine());
                switch (menuAnswer)
                {
                    case 1:
                        Console.WriteLine("Input Surname custumer");
                        fam = Console.ReadLine();
                        Custumer CustumerFam = new Custumer(fam);
                        contProd.addCustumer(CustumerFam);
                        break;
                    case 2:
                        Console.WriteLine("Input second name");
                        fam = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Input new cost");
                        newCost = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(contProd.findCustumer(fam).addPrCost(newCost));
                        break;
                    case 3:
                        Console.WriteLine("Input second name");
                        fam = Convert.ToString(Console.ReadLine());
                        Console.WriteLine(contProd.findCustumer(fam).averageCs());
                        break;
                    case 4:
                        Console.WriteLine("Input second name");
                        fam = Convert.ToString(Console.ReadLine());
                        Console.WriteLine(contProd.findCustumer(fam).getData(), " ");
                        break;
                    case 5:
                        Console.WriteLine(contProd.GetAllData());
                        break;
                    case 6:
                        pointer = false;
                        break;
                }
            }

            }
    }
}
