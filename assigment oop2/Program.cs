namespace assigment_oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  question 1
            // a) struc: value type, lightweight because it store in stack , the parmterless constractor not die when we creat one 
            //    class: refrence type , can creat in it arrays and large thing , the parmter less constracor die when we creat one 
            //b) because the class is refrence so it store in heap while struct value type so it store in stack 

            #endregion
            #region question 2
            //a) shipment 
            //b) express shipment
            // c) tracking code
            //d) usable and better performance 
            #endregion
            #region system
            delevarycenter delvarycenter = new delevarycenter();
            Console.WriteLine("enter the center name");
            delvarycenter.centername = Console.ReadLine();


            Console.WriteLine("enter tarckingcode");
            string trackingcode = Console.ReadLine();
            Console.WriteLine("enter description");
            string description = Console.ReadLine();
            Console.WriteLine("enter the weight");
            decimal weight = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter delevary fee");
            decimal delevaryfee = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter city");
            string city = Console.ReadLine();
            Console.WriteLine("enter the street");
            string street = Console.ReadLine();
            Console.WriteLine("enter the bulding number");
            int buldingnumber = int.Parse(Console.ReadLine());

            Delevaryadress destiontion = new Delevaryadress(city, street, buldingnumber);
            //Shipment shipment = new Shipment(trackingcode, description, weight, delevaryfee, destiontion);
            //bool aded = delvarycenter.addshipment(shipment);
            //if (aded)
            //{
            //    Console.WriteLine("succefull");
            //}
            //else
            //{
            //    Console.WriteLine("failed");
            //}
            standeredshipment standeredshipment = new standeredshipment(trackingcode, description, weight, delevaryfee, destiontion);
            bool aded = delvarycenter.addshipment(standeredshipment);
            if (aded)
            {
                Console.WriteLine("succefull");
            }
            else
            {
                Console.WriteLine("failed");
            }

            Console.WriteLine("enter express trackingcode");
            string expresstrackingcode = Console.ReadLine();

            Console.WriteLine("enter express description");
            string expressdescription = Console.ReadLine();

            Console.WriteLine("enter express weight");
            decimal expressweight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter express delevary fee");
            decimal expressdelevaryfee = decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter express city");
            string expresscity = Console.ReadLine();

            Console.WriteLine("enter express street");
            string expressstreet = Console.ReadLine();

            Console.WriteLine("enter express bulding number");
            int expressbuldingnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("enter extrafee");
            decimal extrafee = decimal.Parse(Console.ReadLine());
            Delevaryadress expressdestion = new Delevaryadress(expresscity, expressstreet, expressbuldingnumber);
            expressshipment expressshipment = new expressshipment(extrafee, expresstrackingcode, expressdescription, expressweight, expressdelevaryfee, expressdestion);
            bool addexpress = delvarycenter.addshipment(expressshipment);
            if (addexpress)
            {
                Console.WriteLine("succefull");
            }
            else
            {
                Console.WriteLine("failed");
            }
            Console.WriteLine("enter international trackingcode");
            string internationaltrackingcode = Console.ReadLine();

            Console.WriteLine("enter international description");
            string internationaldescription = Console.ReadLine();

            Console.WriteLine("enter international weight");
            decimal internationalweight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter international delevary fee");
            decimal internationaldelevaryfee = decimal.Parse(Console.ReadLine());

            Console.WriteLine("enter international city");
            string internationalcity = Console.ReadLine();

            Console.WriteLine("enter international street");
            string internationalstreet = Console.ReadLine();

            Console.WriteLine("enter international bulding number");
            int internationalbuldingnumber = int.Parse(Console.ReadLine());


            Console.WriteLine("enter your destion country");
            string destioncountry = Console.ReadLine();
            Console.WriteLine("enter customfee");
            decimal customfee = decimal.Parse(Console.ReadLine());
            Delevaryadress internationaldestiontion = new Delevaryadress(internationalcity, internationalstreet, internationalbuldingnumber);

            internationalshipment internationalshipment = new internationalshipment(destioncountry, customfee, internationaltrackingcode, internationaldescription, internationalweight, internationaldelevaryfee, internationaldestiontion);
            bool intranationaladd = delvarycenter.addshipment(internationalshipment);
            if (intranationaladd)
            {
                Console.WriteLine("succefull");
            }
            else
            {
                Console.WriteLine("failed");
            }
            delvarycenter.printallshipments();
            Console.WriteLine("enter tracking code for search");
            string searchcode = Console.ReadLine();
            Shipment foundshipment = delvarycenter[searchcode];
            if (foundshipment != null)
            {
                foundshipment.printshipment();
            }
            else
            {
                Console.WriteLine("not found ");
            }
            Console.WriteLine("enter trackingcode to remove");
            string removecode = Console.ReadLine();
            bool removed = delvarycenter.removeshipment(removecode);
            if (removed)
            {
                Console.WriteLine("succees");
            }
            else
            {
                Console.WriteLine("failed");
            }
            delvarycenter.printallshipments();
        }
    }
} 
#endregion
