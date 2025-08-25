using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDotnetCoreApp.PatientRecordManagement
{
    internal class PatientEntity
    {
        static PatientData pd = new PatientData();
        

        public static void GetAllPatients()
        {
            
            try
            {
                pd.getallpatient();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            }

        public static void InsertPatient()
        {
            
            try
            {
                pd.insertpatient();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }   
        }

        public static void GetPatient()
        {
            
            try
            {
                pd.getpatient();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public static void DeletePatient()
        {
            
           
            try
            {
                pd.detetepatient();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public static void UpdatePatient()
        {


           
            try
            {
                pd.updatepatient();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
