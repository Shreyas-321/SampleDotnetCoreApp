using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDotnetCoreApp.PatientRecordManagement
{
    internal class PatientData
    {
        public void insertpatient()
        {
            var context = new PatientContext();
            var patient = new PatientComponent
            {
                Name = ConsoleUtil.GetString("Name: "),
                DateOfBirth = ConsoleUtil.GetString("Date of Birth: "),
                Age = ConsoleUtil.GetInteger("Age: "),
                BloodGroup = ConsoleUtil.GetString("Blood Group: ")
            };
            context.Patients.Add(patient);
            context.SaveChanges();
            Console.WriteLine("Patient added successfully");
        }

        internal void detetepatient()
        {
            int id = ConsoleUtil.GetInteger("Enter the id of the patient to delete: ");
            var context = new PatientContext();
            var patient = context.Patients.Find(id);
            if (patient != null)
            {
                context.Patients.Remove(patient);
                context.SaveChanges();
                Console.WriteLine("Patient deleted successfully");
            }
            else
            {
                Console.WriteLine("Patient not found");
            }
        }
        public void getallpatient()
        {
            var context = new PatientContext();
            var patients = context.Patients.ToList();
            foreach (var patient in patients)
            {
                Console.WriteLine($"Id: {patient.Id}, Name: {patient.Name}, DateOfBirth: {patient.DateOfBirth}, Age: {patient.Age}, BloodGroup: {patient.BloodGroup}");
            }
        }

        public  void getpatient()
        {
            int id = ConsoleUtil.GetInteger("Enter the id of the patient to fetch: ");
            var context = new PatientContext();
            var patient = context.Patients.Find(id);
            if (patient != null)
            {
                Console.WriteLine($"Id: {patient.Id}, Name: {patient.Name}, DateOfBirth: {patient.DateOfBirth}, Age: {patient.Age}, BloodGroup: {patient.BloodGroup}");
            }
            else
            {
                Console.WriteLine("Patient not found");
            }
        }

        internal void updatepatient()
        {
            int id = ConsoleUtil.GetInteger("Enter the id of the patient to update: ");
            var context = new PatientContext();
            var patient = context.Patients.Find(id);
            if (patient != null)
            {
                Console.WriteLine("Enter new details for the patient:");
                patient.Name = ConsoleUtil.GetString("Name: ");
                patient.DateOfBirth = ConsoleUtil.GetString("Date of Birth: ");
                patient.Age = ConsoleUtil.GetInteger("Age: ");
                patient.BloodGroup = ConsoleUtil.GetString("Blood Group: ");
                context.SaveChanges();
                Console.WriteLine("Patient updated successfully");
            }
            else
            {
                Console.WriteLine("Patient not found");
            }
        }
    }
}
