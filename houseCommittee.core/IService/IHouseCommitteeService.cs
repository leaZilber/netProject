using houseCommittee.core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace houseCommittee.core.repositoriesI
{
    public interface IHouseCommitteeService
    {
        public HouseCommittee GetHouseComByid(string code);//שליפת וועד בית עפ"י טלפון

        public List<HouseCommittee> GetAllHouseCom();

        public void AddHouseCom(HouseCommittee newHouseCom);

        public void UpDateHouseCom(HouseCommittee newHouseCom, string id);//עדכון פרטי וועד בית

        public void DeleteHouseCom(string phone);//מחיקת וועד בית

    }
}
