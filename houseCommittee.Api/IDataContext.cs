using houseCommittee.core.models;

namespace houseCommittee.Api
{
    public class IDataContext
    {
        public List<Message> MessageList { get; set; }
        public List<Building> BuildingList { get; set; }
        public List<Tenant> TenantList { get; set; }
        public List<HouseCommittee> HouseCommitteeList { get; set; }
    }
}
