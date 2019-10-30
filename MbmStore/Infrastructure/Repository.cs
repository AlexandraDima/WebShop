using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Models;

namespace MbmStore.Models
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Customer> Customers = new List<Customer>();

        //generate ALL objects and put into lists
        static Repository()
        {
        //Create objects


            //Books
            Book b1 = new Book(1, "Bob Dylan Chronicles", "James Stone", 20.50m, "Books(2015)", "2332323", "ChroniclesBobDilan.png");
            b1.Category = "Book";
            Book b2 = new Book(2, "Miles Autobiography", "Miles Arthur", 30.30m, "Books(2018)", "445667", "MilesAutobiography.png");
            b2.Category = "Book";

            ///////CDs
            //CD1
            MusicCD cd1 = new MusicCD(4, "Bob Dylan - The collection", "Bob Dylan", "EMI (2009)", 160.50m, "BobDilanCD.png");
            cd1.addTrack(new Track("Blowin' in the Wind", "Don Hunstein", new TimeSpan(0, 2, 48)));
            cd1.addTrack(new Track("Girl from the North Country", "Don Hunstein", new TimeSpan(0, 2, 38)));
            cd1.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));
            cd1.addTrack(new Track("Blowin' in the Wind", "Don Hunstein", new TimeSpan(0, 2, 48)));
            cd1.addTrack(new Track("Girl from the North Country", "Don Hunstein", new TimeSpan(0, 2, 38)));
            cd1.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));
            cd1.Category = "MusicCD";


            //CD3
            MusicCD cd3 = new MusicCD(6, "The real Miles Davis", "Miles Davis", "EMI (2009)", 160.50m, "MilesDavisCD.png");
            cd3.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));
            cd3.addTrack(new Track("I Will", "Richard Rodgers", new TimeSpan(0, 2, 20)));
            cd3.addTrack(new Track("Blue Moon", "Richard Rodgers", new TimeSpan(0, 2, 52)));
            cd3.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));
            cd3.addTrack(new Track("I Will", "Richard Rodgers", new TimeSpan(0, 2, 20)));
            cd3.addTrack(new Track("Blue Moon", "Richard Rodgers", new TimeSpan(0, 2, 52)));
            cd3.Category = "MusicCD";

            ///Movie objects
            Movie becomingAstrid = new Movie(8, "Becoming Astrid", 200.10m, "becomingAstrid.png", "Ridley Scott");
            becomingAstrid.Category = "Movie";
            Movie starBorn = new Movie(9, "A star is born", 180.10m, "starBorn.png", "Ridley Scott");
            starBorn.Category = "Movie";
            Products.Add(b1);
            Products.Add(b2);


            Products.Add(cd1);
            Products.Add(cd3);

            Products.Add(becomingAstrid);
            Products.Add(starBorn);
        
        

        /// Create objects for Customer class

     
            ///Customers
            Customer customer1 = new Customer("Sune", "Nielsen", "Jernbanegade 24", "7100", "Vejle");
            customer1.addPhone("3232323");
            customer1.addPhone("7572547");
            customer1.BirthDate = new DateTime(1996, 03, 03);
            customer1.CustomerId = 1;


            Customer customer2 = new Customer("Maria", "Jensen", "Jernbanegade 30", "7100", "Vejle");
            customer2.addPhone("3232323");
            customer2.addPhone("7572547");
            customer1.CustomerId = 2;


            Customers.Add(customer1);
            Customers.Add(customer2);

            Invoice invoice1 = new Invoice(1, new DateTime(2019, 03, 20), customer1);
            Invoice invoice2 = new Invoice(2, new DateTime(2019, 03, 20), customer2);
    
            invoice1.addOrderItem(new OrderItem(b1, 2));
            invoice2.addOrderItem(new OrderItem(cd1, 1));

          
            Invoices.Add(invoice1);
            Invoices.Add(invoice2);
          
            ///create order items objects





        }
      

    }
}
