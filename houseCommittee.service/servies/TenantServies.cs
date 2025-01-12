using houseCommittee.core.IService;
using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;

namespace houseCommittee.service.servies
{
    public class TenantServies : ITenantService
    {
        private readonly ITenantRepository _tenantRepository;
        public TenantServies(ITenantRepository tenantRepository)
        {
            _tenantRepository = tenantRepository;
        }
        public Tenant GetTenantByid(string id)//שליפת דייר עפ"י קוד
        {
            //Tenant t = tenantsList.Where(te => te.CodeTenant == id).FirstOrDefault();
            //if (t == null)
            //    return null;

            //return t;
            return _tenantRepository.GetTenantByid(id);
        }
        public void AddTenant(Tenant tenant)//הוספת דייר
        {
            //tenantsList.Add(tenant);
            _tenantRepository.AddTenant(tenant);
        }

        public void DeleteTenant(string id)//מחיקת דייר
        {
            //tenantsList.RemoveAll(te => te.CodeTenant == id);
            _tenantRepository.DeleteTenant(id);
        }
        public void UpDateTenant(Tenant newTen, string id)//עדכון פרטי דייר
        {
            _tenantRepository.UpDateTenant(newTen, id);
            //foreach (var t in tenantsList)
            //{
            //    if (t.CodeTenant == id)
            //    {
            //        tenantsList.Add(t);
            //    }
            //}
        }

        public List<Tenant> GetAllTenant()
        {
            throw new NotImplementedException();
        }
    }
}