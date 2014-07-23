using WithoutGenerics.Entities;

namespace WithoutGenerics
{
    public class CompanyRepository
    {
        private readonly DataBase _dataBase;

        public CompanyRepository()
        {
            _dataBase = new DataBase();
        }

        public int Save(Company entity)
        {
            return _dataBase.Save(entity);
        }

        public Company GetById(int id)
        {
            var company = _dataBase.GetById(id) as Company;
            return company;
        }
    }
}