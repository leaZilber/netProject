//using System.Linq;
//using WebApplication1.classes;
//namespace WebApplication1.servies
//{
//    public class ServiceProviderServies
//    {
//        static List<ServiceProvider> ServiceList = new List<ServiceProvider>();
//        public ServiceProvider GetProviderServiesByid(string phone)//שליפת נותן שירות עפ"י טלפון
//        {
//            ServiceProvider s = ServiceList.Where(s1 => s1.PhoneProvider == phone).FirstOrDefault();
//            if (s == null)
//                return null;
//            return s;
//        }
//        public void AddService(ServiceProvider serv)//הוספת נותן שירות
//        {
//            ServiceList.Add(serv);
//        }

//        public void DeleteService(string code)//מחיקת נותן שירות
//        {
//            ServiceList.RemoveAll(item => item.PhoneProvider == code);
//        }
//        public void UpDateServiceProvider(ServiceProvider newSer, string id)//עדכון פרטי נותן שירות
//        {
//            foreach (ServiceProvider item in ServiceList)
//            {
//                if (item.PhoneProvider == id)
//                {
//                    ServiceList.Add(newSer);
//                }
//            }
//        }
//    }
//}
