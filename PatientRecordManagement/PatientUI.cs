using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDotnetCoreApp.PatientRecordManagement
{
    internal class PatientUI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your option for Patient Record Management ");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add the patient record\n2. Get all patient records\n3. Update a patient record\n4. Delete a patient record\n5. Get the patient record");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PatientEntity.InsertPatient();
                        break;
                    case 2:
                        PatientEntity.GetAllPatients();
                        break;
                    case 3:
                        PatientEntity.UpdatePatient();
                        break;
                    case 4:
                        PatientEntity.DeletePatient();
                        break;
                    case 5:
                       PatientEntity.GetPatient();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Do you want to continue? (y/n): ");
                string cont = Console.ReadLine();
                if (cont.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}
