//using houseCommittee.core.models;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using WebApplication1;

//namespace houseCommittee.data.repositories
//{
//    public class ServiceProviderRepository
//    {
//        private readonly DataContext _serviceProv;
//        public ServiceProviderRepository(DataContext serviceProv)
//        {
//            _serviceProv = serviceProv;
//        }

//        public ServiceProvider GetServiceProvByid(string code)//קבלת נותן שירות עפ"י קוד
//        {
//            ServiceProvider s = _serviceProv.ServiceProviderList.Where(te => te.PhoneProvider == code).FirstOrDefault();
//            if (s == null)
//                return null;
//            return s;
//        }
//        public List<ServiceProvider> GetAllServiceProv()
//        {
//            return _serviceProv.ServiceProviderList;
//        }

//        public void AddServiceProv(ServiceProvider newServiceProv)
//        {
//            _serviceProv.ServiceProviderList.Add(newServiceProv);
//        }

//        public void UpDateServiceProv(ServiceProvider newServiceProv, string phone)//עדכון פרטי נותן שירות
//        {
//            foreach (ServiceProvider item in _serviceProv.ServiceProviderList)
//            {
//                if (item.PhoneProvider == phone)
//                {
//                    _serviceProv.ServiceProviderList.Add(item);
//                }
//            }
//        }
//        public void DeleteServiceProv(string phone)//מחיקת נותן שירות
//        {
//            _serviceProv.ServiceProviderList.RemoveAll(te=>te.PhoneProvider == phone);
//        }
//    }
//}
