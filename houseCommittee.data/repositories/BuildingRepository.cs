using houseCommittee.core.models;
using houseCommittee.core.IRepositories;


namespace houseCommittee.data.repositories {

    public class BuildingRepository : IBuildingRepository
    {
        private readonly DataContext _dataContext;
        public BuildingRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Building GetBuildingByid(int code)//שליפת בנין עפ"י קוד
        {
            Building b = _dataContext.BuildingList.Where(te => te.NumBuilding == code).FirstOrDefault();
            if (b == null)
                return null;
            return b;
        }
        public List<Building> GetAllBuildings()
        {
            return _dataContext.BuildingList;
        }

        public void AddBuilding(Building newBuild)
        {
            _dataContext.BuildingList.Add(newBuild);
        }

        public void UpDateBuild(Building newBuild, int id)//עדכון פרטי בנין
        {
            foreach (Building item in _dataContext.BuildingList)
            {
                if (item.NumBuilding == id)
                {
                    _dataContext.BuildingList.Add(newBuild);
                }
            }
        }
        public void DeleteBuilding(int id)//מחיקת בנין
        {
            _dataContext.BuildingList.RemoveAll(item => item.NumBuilding == id);
        }
    }
}
