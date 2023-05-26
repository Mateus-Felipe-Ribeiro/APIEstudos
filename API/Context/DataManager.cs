using API.Contexto;
using API.Contracts;

namespace API.Context
{
    public class DataManager : IContextManager
    {
        private DataContext _dataContext;
        private ICompanyRepository? _companyRepository;

        public DataManager(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyContext(_dataContext);

                return _companyRepository;
            }
        }

        public void Save() => _dataContext.SaveChanges();
    }
}
