using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;

namespace houseCommittee.data.repositories
{
    public class TenantRepository : ITenantRepository
    {
        private readonly DataContext _tenant;
        public TenantRepository(DataContext tenant)
        {
            _tenant = tenant;
        }

        public Tenant GetTenantByid(string code)//קבלת דייר עפ"י קוד
        {
            Tenant t = _tenant.TenantList.Where(te => te.CodeTenant == code).FirstOrDefault();
            if (t == null)
                return null;
            return t;
        }

        public List<Tenant> GetAllTenant()
        {
            return _tenant.TenantList.ToList();
        }

        public void AddTenant(Tenant newTenant)
        {
            _tenant.TenantList.Add(newTenant);
            _tenant.SaveChanges();
        }

        public void UpDateTenant(Tenant newTenant, string code)//עדכון פרטי נותן שירות
        {
            foreach (Tenant item in _tenant.TenantList)
            {
                if (item.CodeTenant == code)
                {
                    _tenant.TenantList.Add(item);
                    _tenant.SaveChanges();
                }
            }
        }
        public void DeleteTenant(string code)//מחיקת דייר
        {
            var tenant = _tenant.TenantList.FirstOrDefault(item => item.CodeTenant == code);
            if (tenant != null)
            {
                _tenant.TenantList.Remove(tenant);
                _tenant.SaveChanges();
            }
        }
    }
}
