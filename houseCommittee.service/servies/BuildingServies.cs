using houseCommittee.core.IRepositories;
using houseCommittee.core.models;
using houseCommittee.core.repositoriesI;
using houseCommittee.core.repositories;
using System.ComponentModel;
namespace houseCommittee.servies.servies
{
    public class BuildingServies:IBuildingService
    {
        private readonly IBuildingRepository _buildingRepository;
        public BuildingServies(IBuildingRepository buildingRepository)
        {
            _buildingRepository = buildingRepository;
        }
        public Building GetBuildingByid(int code)//שליפת בנין עפ"י קוד
        {
            //Building b = _buildingRepository.Where(te => te.codeBuild == code).FirstOrDefault();
            //if (b == null)
            //    return null;
            //return b;
            return _buildingRepository.GetBuildingByid(code);
        }
        public List<Building> GetAllBuildings()
        {
            return _buildingRepository.GetAllBuildings();
        }
        public void AddBuilding(Building newBuild)//הוספת בנין
        {
            _buildingRepository.AddBuilding(newBuild);
        }

        public void DeleteBuilding(int id)//מחיקת בנין
        {
            //_buildingRepository.DeleteBuilding(item=>item.codeBuild == id);
            _buildingRepository.DeleteBuilding(id);
        }
        public void UpDateBuild(Building newBuild, int id)//עדכון פרטי בנין
        {
            _buildingRepository.UpDateBuild(newBuild, id);
            //foreach (Building item in BuildingList)
            //{
            //    if (item.c==id)
            //    {
            //        _buildingRepository.AddBuilding(newBuild);
            //    }
            //}
        }
    }
}
