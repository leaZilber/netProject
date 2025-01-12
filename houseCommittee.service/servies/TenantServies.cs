using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;

namespace houseCommittee.servies
{
    public class TenantServies
    {
        private readonly ITenantService _tenantService;
        public TenantServies(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }
        public Tenant GetTenantByid(string id)//שליפת דייר עפ"י קוד
        {
            //Tenant t = tenantsList.Where(te => te.CodeTenant == id).FirstOrDefault();
            //if (t == null)
            //    return null;

            //return t;
            return _tenantService.GetTenantByid(id);
        }
        public void AddTenant(Tenant tenant)//הוספת דייר
        {
            //tenantsList.Add(tenant);
            _tenantService.AddTenant(tenant);
        }

        public void DeleteTenant(string id)//מחיקת דייר
        {
            //tenantsList.RemoveAll(te => te.CodeTenant == id);
            _tenantService.DeleteTenant(id);
        }
        public void UpDateTenant(Tenant newTen, string id)//עדכון פרטי דייר
        {
            _tenantService.UpDateTenant(newTen, id);
            //foreach (var t in tenantsList)
            //{
            //    if (t.CodeTenant == id)
            //    {
            //        tenantsList.Add(t);
            //    }
            //}
        }
    }
}