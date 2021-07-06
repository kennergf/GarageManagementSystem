namespace GarageManagementSystem.Services
{
    public interface IDataBase
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="T"></param>
        void Add(dynamic T);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int Commit();
    }
}