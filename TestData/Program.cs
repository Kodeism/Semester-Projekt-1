using DataAccess.Repositories;
using Models;

namespace TestData
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Rubens specielle connection string som han skal bruge fordi hans SSMS er en ælling
            DataRepository testDR = new DataRepository();

            // Connection string for normale mennesker
            //DataRepository testDR = new DataRepository("Server = localhost; Database = Semester projekt gruppe 1; User ID = sa; Password = 1234; Trusted_Connection = True; TrustServerCertificate = True;");


            Køber testKøber = new Køber("Fløde", "Bolle", "22222222", "test@example.com", 70000000, "Danmark", "Villa", "12345678-1234", "hejsaalee");
            testDR.CreateKøber(testKøber);


            //testDR.CreateBolig(new Bolig(
            //    100000,
            //    "Example Street 11",
            //    5000,
            //    "Odense",
            //    "Lejlighed",
            //    72,
            //    2,
            //    DateTime.Now,
            //    187,
            //    1,
            //    3,
            //    "C",
            //    "Til salg")
            //    );

            //testDR.UpdatePris(3, 999999);
        }


    }
}
