namespace API.Contracts
{
    public interface IContextManager
    {
        ICompanyRepository Company { get; }
        void Save();
    }
}
