using API.Contexto;
using API.Contracts;
using API.Entities.Models;

namespace API.Context
{
    public class CompanyContext : DataBase<Company>, ICompanyRepository
    {
        public CompanyContext(DataContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
           FindAll(trackChanges)
           .OrderBy(c => c.Name)
           .ToList();
    }
}
