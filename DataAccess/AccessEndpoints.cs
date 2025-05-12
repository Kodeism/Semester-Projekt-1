using DataAccess.Repositories;

namespace DataAccess
{
    public class AccessEndpoints
    {
        private readonly DataRepository repository;
        string connectionString = "Server = localhost; Database = Semester projekt gruppe 1; User ID = sa; Password = 1234; Trusted_Connection = True;";

        public AccessEndpoints()
        {
            repository = new DataRepository(connectionString);
        }
    }
}
