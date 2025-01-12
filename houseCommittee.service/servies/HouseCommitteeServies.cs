using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;
using System.Linq;
namespace houseCommittee.servies
{
    public class HouseCommitteeServies
    {
        private readonly IHouseCommittee _houseCommittee;
        public HouseCommitteeServies(IHouseCommittee houseCommittee)
        {
            _houseCommittee = houseCommittee;
        }
        public HouseCommittee GetHouseCommByid(string phone)//שליפת הודעה עפ"י כותרת
        {
            //HouseCommittee h = HouseCommitteeList.Where(te => te.PhoneHouseCommittee == phone).FirstOrDefault();
            //if (h == null)
            //    return null;
            //return h;
           return  _houseCommittee.GetHouseComByid(phone);
        }
        //public List<HouseCommittee> GetAllHouseCom()
        //{
        //    return HouseCommitteeList.get
        //}
        public void AddHouseCommittee(HouseCommittee House)//הוספת וועד בית
        {
            //HouseCommitteeList.Add(House);
            _houseCommittee.AddHouseCom(House);
        }
       
        public void UpDateHouse(string phone, HouseCommittee newHouse)//עדכון וועד בית
        {
            //foreach (HouseCommittee item in HouseCommitteeList)
            //{
            //    if (!HouseCommitteeList.Contains(newHouse) && item.PhoneHouseCommittee == phone)
            //    {
            //        HouseCommitteeList.Add(newHouse);
            //    }
            //}
            _houseCommittee.UpDateHouseCom(newHouse,phone);
        }
        public void DeleteHouse(string phone)//מחיקת וועד בית
        {
            //HouseCommitteeList.RemoveAll(match => match.PhoneHouseCommittee == phone);
            _houseCommittee.DeleteHouseCom(phone);
        }
    }
}
