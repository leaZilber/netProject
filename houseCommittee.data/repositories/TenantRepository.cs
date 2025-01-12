using houseCommittee.core.models;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplication1;
using WebApplication1.data;
namespace houseCommittee.data.repositories
{
    public class TenantRepository
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
            return _tenant.TenantList;
        }

        public void AddTenant(Tenant newTenant)
        {
            _tenant.TenantList.Add(newTenant);
        }

        public void UpDateTenant(Tenant newTenant, string code)//עדכון פרטי נותן שירות
        {
            foreach (Tenant item in _tenant.TenantList)
            {
                if (item.CodeTenant == code)
                {
                    _tenant.TenantList.Add(item);
                }
            }
        }
        public void DeleteTenant(string code)//מחיקת דייר
        {
            _tenant.TenantList.RemoveAll(te => te.CodeTenant == code);
        }
    }
}
