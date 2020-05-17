using lv7.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv7
{
    public enum DVDType { SOFTWARE, MOVIE }
    class Program
    {
        static void Main()
        {
            //Zadatak1();
            //Zadatak2();
            //Zadatak3();
            //Zadatak4();
            //Zadatak5();
            //Zadatak6();
            Zadatak7();
        }

        static void Zadatak1()
        {
            double[] numbers = { 44.23, 33.2, 22.2, 11.56357, 55, 66.8, 77, 88, 99.9999 };
            NumberSequence sequence1 = new NumberSequence(numbers);
            SequentialSort sort1 = new SequentialSort();
            sequence1.SetSortStrategy(sort1);
            sequence1.Sort();
            Console.WriteLine("sequentialsort" + sequence1.ToString());

            NumberSequence sequence2 = new NumberSequence(numbers);
            BubbleSort sort2 = new BubbleSort();
            sequence2.SetSortStrategy(sort2);
            sequence2.Sort();
            Console.WriteLine("bubblesort" + sequence2.ToString());

            NumberSequence sequence3 = new NumberSequence(numbers);
            CombSort sort3 = new CombSort();
            sequence3.SetSortStrategy(sort3);
            sequence3.Sort();
            Console.WriteLine("combsort" + sequence3.ToString());
        }

        static void Zadatak2()
        {
            double[] numbers = { 44.23, 33.2, 22.22, 11.56357, 55, 66.8, 77, 88, 99.9999 };
            NumberSequence sequence = new NumberSequence(numbers);
            BubbleSort bubbleSort = new BubbleSort();
            BinarySearch search = new BinarySearch();
            sequence.SetSearchStrategy(search, 22.22);
            sequence.SetSortStrategy(bubbleSort);
            sequence.Sort();
            sequence.Search();
        }
        static void Zadatak3()
        {
            string path = "log.txt";
            SystemDataProvider resources = new SystemDataProvider();
            Logger fileLogger = new FileLogger(path);
            Logger consoleLogger = new ConsoleLogger();

            resources.Attach(fileLogger);
            resources.Attach(consoleLogger);
            while (true)
            {
                resources.GetCPULoad();
                resources.GetAvailableRAM();
                System.Threading.Thread.Sleep(1000);
            }
        }
        static void Zadatak4()
        {
            string path = "log.txt";
            SimpleSystemDataProvider resources = new SystemDataProvider();
            Logger fileLogger = new FileLogger(path);
            Logger consoleLogger = new ConsoleLogger();
            while (true)
            {
                fileLogger.Log(resources);
                consoleLogger.Log(resources);
                System.Threading.Thread.Sleep(1000);
            }
        }

        static void Zadatak5()
        {
            IItem dvd = new DVD("opis", DVDType.SOFTWARE, 12);
            IItem book = new Book("naslov", 15);
            IVisitor visitor = new BuyVisitor();
            Console.WriteLine(dvd.Accept(visitor));
            Console.WriteLine(book.Accept(visitor));
        }

        static void Zadatak6()
        {
            IItem dvd1 = new DVD("opis", DVDType.MOVIE, 12);
            IItem dvd2 = new DVD("opis", DVDType.SOFTWARE, 12);
            IVisitor visitor = new Visitor();
            Console.WriteLine(dvd1.Accept(visitor));
            Console.WriteLine(dvd2.Accept(visitor));
        }

        static void Zadatak7()
        {
            IItem dvd = new DVD("opis", DVDType.SOFTWARE, 12);
            IItem vhs = new VHS("title", 12);
            IItem book = new Book("naslov", 15);
            IVisitor visitor = new Visitor();
            Cart cart = new Cart();
            cart.AddToCart(dvd);
            cart.AddToCart(vhs);
            cart.AddToCart(book);
            Console.WriteLine(cart.Accept(visitor));

        }

    }
}
