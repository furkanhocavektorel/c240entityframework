
namespace DBConnectProject.service
{
    internal interface ICustomerService
    {
        void save(string id,string companyName, string customerName);
        bool update(string id, string contactName);
    }
}
