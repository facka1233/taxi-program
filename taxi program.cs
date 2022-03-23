namespace Taxiprogram
{
    public class Taxi
    {
        public string Drivename { get; set; }
        public bool Onduty { get; set; }
        public int Numpassenger { get; set; }

        public void Taxiinfo()
        {
            string duty;
            if(Onduty)
            {
                duty = "yes";
            }
            else
            {
                duty = "no";
            }
            Console.WriteLine("Driver name: {0}", Drivename);
            Console.WriteLine("On Duty: {0}", duty);
            Console.WriteLine("number of passenger: {0}", Numpassenger);
        }
        public void Pickup()
        {
            Console.WriteLine(Drivename + " sedang menjemput penumpang");
        }
        public void drop()
        {
            Console.WriteLine(Drivename + " Selesai mengantar penumpang");

        }
    }
    namespace Taxiprogram
    {
        class Program
        {
            static void Main(string[] args)
            {
                Taxi taxi = new Taxi ();

                taxi.Drivename = "Jono";
                taxi.Onduty = true;
                taxi.Numpassenger = 10;

                taxi.Taxiinfo();
                taxi.Pickup();
                taxi.drop();


                Console.ReadKey();
            }
        }
    }
}