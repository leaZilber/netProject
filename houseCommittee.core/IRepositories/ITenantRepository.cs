using houseCommittee.core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace houseCommittee.core.repositoriesI
{
    public interface ITenantRepository
    {
        public Tenant GetTenantByid(string code);//קבלת דייר עפ"י קוד

        public List<Tenant> GetAllTenant();

        public void AddTenant(Tenant newTenant);

        public void UpDateTenant(Tenant newTenant, string code);//עדכון פרטי נותן שירות


        public void DeleteTenant(string code);//מחיקת דייר

    }
}
