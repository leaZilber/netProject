using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;


namespace houseCommittee.data.repositories
{
    public class HouseCommitteeRepository : IHouseCommitteeRepository
    {
        private readonly DataContext _house;
        public HouseCommitteeRepository(DataContext house)
        {
            _house = house;
        }

        public HouseCommittee GetHouseComByid(string code)//שליפת וועד בית עפ"י טלפון
        {
            HouseCommittee h = _house.HouseCommitteeList.Where(te => te.PhoneHouseCommittee == code).FirstOrDefault();
            if (h == null)
                return null;
            return h;
        }
        public List<HouseCommittee> GetAllHouseCom()
        {
            return _house.HouseCommitteeList;
        }

        public void AddHouseCom(HouseCommittee newHouseCom)
        {
            _house.HouseCommitteeList.Add(newHouseCom);
        }

        public void UpDateHouseCom(HouseCommittee newHouseCom, string id)//עדכון פרטי וועד בית
        {
            foreach (HouseCommittee item in _house.HouseCommitteeList)
            {
                if (item.PhoneHouseCommittee == id)
                {
                    _house.HouseCommitteeList.Add(newHouseCom);
                }
            }
        }
        public void DeleteHouseCom(string phone)//מחיקת וועד בית
        {
            _house.HouseCommitteeList.RemoveAll(item => item.PhoneHouseCommittee == phone);
        }
    }
}
