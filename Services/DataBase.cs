using GarageManagementSystem.Data;

namespace GarageManagementSystem.Services
{
    public class DataBase : IDataBase
    {
        private ApplicationDbContext _db;

        public DataBase(ApplicationDbContext db) => _db = db;

        public void Add(dynamic T)
        {
            _db.Add(T);
        }

        public int Commit()
        {
            throw new System.NotImplementedException();
        }
    }
}