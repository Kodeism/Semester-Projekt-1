using DataAccess.Repositories;

namespace TestData
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DataRepository testDR = new DataRepository("Server = localhost; Database = Semester projekt gruppe 1; User ID = sa; Password = 1234; Trusted_Connection = True; TrustServerCertificate = True;");
            testDR.CreateKøber();
        }
    }
}
