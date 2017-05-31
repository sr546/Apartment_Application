using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appartment_reservation_app
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Apartment type:");
            String apartment_type = Console.ReadLine();

            Console.WriteLine("Enter Apartment number:");
            int apt_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of rooms:");
            int room_count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Applicant name:");
            String applicant_name = Console.ReadLine();

            Apartment a = new Apartment(apartment_type, apt_number, room_count, applicant_name);

            a.AptDetailsDisplay();

        }
    }

    class Apartment
    {
        String apartment_type, applicant_name;
        int apt_number, room_count;
        
        public Apartment(String apartment_type,int apt_number,int room_count,String applicant_name)
        {
            this.apartment_type = apartment_type;
            this.apt_number = apt_number;
            this.room_count = room_count;
            this.applicant_name = applicant_name;
        }

        public void AptDetailsDisplay()
        {
            Console.WriteLine("\n Apartment of type " + apartment_type +
                                " with apartment number as " + apt_number +
                                   " and number of rooms " + room_count +
                                   " reserved to " + applicant_name+". Congrats..!!!");
            Console.ReadKey();
        }
    }
}
