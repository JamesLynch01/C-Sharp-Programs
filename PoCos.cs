using System;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {
            License Jill = new License("Jill", "Larry");
            Jill.LicenseNumber = 13;
            Jill.Gender = "female";
            
            Console.WriteLine("{0} is a {1} with this number {2}",
                Jill.FullName(), Jill.Gender, Jill.LicenseNumber
                );

            Book Ring = new Book("Tolkien", "Ring Dancing");
           
            Ring.PagesBook = 560;
            Ring.PriceBook = 8;
            Ring.SKU = 839230875;
            Ring.PublisherBook = "the Royal Library";
            Ring.BuyBook();




            Airplanes B3 = new Airplanes("Boeing", "B-17 Flying Fortress", "XB-38 flying fortress", 10, 4);
            
            B3.AirShow();
           
        }
    }

    public class License
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int LicenseNumber { get; set; }
       

        public License(string initialFirstName, string initialSecondName)
        {
            this.FirstName = initialFirstName;
            this.LastName = initialSecondName;
            
        }

        public string FullName()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }
    }

    public class Book
    {
        public string TitleBook;
        public string AuthorsBook;
        public int PagesBook;
        public int SKU;
        public string PublisherBook;
        public int PriceBook;

        public Book(string authorsBook, string titleBook)
        {
            this.AuthorsBook = authorsBook;
            this.TitleBook = titleBook;
        }

        public void BuyBook()
        {
            Console.WriteLine("{0} was written by {1} with {2} pages, it is currently been sold for {3} dollars by {4}. ISBN is {5}",
                TitleBook, AuthorsBook, PagesBook, PriceBook, PublisherBook, SKU
                );
        }
    }

    public class Airplanes
    {
        public string Manufacturer;
        public string Model;
        public string Variant;
        public int Capacity;
        public int Engines;

        public Airplanes(string manufacturer, string model, string variant, int capacity, int engines)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Variant = variant;
            this.Capacity = capacity;
            this.Engines = engines;
        }

        public void AirShow()
        {
            Console.WriteLine("{0} was built by {1} this is it's {2} number. It can hold {3} crew members and has {4} engines!", Model, Manufacturer, Variant, Capacity, Engines);
        }
    }

   
}

