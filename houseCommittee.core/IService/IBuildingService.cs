using houseCommittee.core.models;


namespace houseCommittee.core.IService
{
    public interface IBuildingService
    {
        public Building GetBuildingByid(int code);//שליפת בנין עפ"י קוד

        public List<Building> GetAllBuildings();

        public void AddBuilding(Building newBuild);

        public void UpDateBuild(Building newBuild, int id);//עדכון פרטי בנין

        public void DeleteBuilding(int id);//מחיקת בנין

    }
}
