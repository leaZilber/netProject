using houseCommittee.Api;
using houseCommittee.core.models;

namespace houseCommittee
{
    public class FakeContext:IDataContext
    {
        public List<Message> MessageList { get; set; }
        public List<Building> BuildingList { get; set; }
        public List<Tenant> TenantList { get; set; }
        public List<HouseCommittee> HouseCommitteeList { get; set; }
        //public List<ServiceProvider> ServiceProviderList { get; set; }
        public FakeContext()
        {
            DateTime now = DateTime.Now;
            MessageList = new List<Message> {
                new Message{Title="Notification regarding late payment",Body = "A debt has been registered for you, please come and settle it as soon as possible.", DateTimeMessage = now,target="lea4177942gmail.com"},
                new Message{Title="reception",Body="Attached is the receipt for the last month",DateTimeMessage=now,target="lea0548417794@gmail.com"},
                new Message{Title="Notice about a meeting of neighbors",Body="Tomorrow there will be a meeting of neighbors at the Cohen family home",DateTimeMessage=now,target="lea417794@gmail.com"}
            };

            BuildingList = new List<Building>
            {
                new Building{ NameStreet="rabbi-akiva", NameCity="bnei brak",NumBuilding=50,NumTenants=16,MonthlyPayment=150 },
                new Building{NameStreet="harotem",NameCity="ashdod",NumBuilding=10,NumTenants=8,MonthlyPayment=250},
                new Building{NameStreet="shaul hamelech",NameCity="yerushlaim",NumBuilding=22,NumTenants=25,MonthlyPayment=120}
            };

            TenantList = new List<Tenant>
            {
                new Tenant{FamilyName="levison",FirstName="racheli",ApartmentNumber=13,AmounPayments=2,MailTenant="rachelil@gmail.com",PhoneTenant="0548456666" },
                new Tenant{FamilyName="choen",FirstName="ruth",ApartmentNumber=10,AmounPayments=1,MailTenant="choenRuth@gmail.com",PhoneTenant="035701111"},
                new Tenant{FamilyName="goldberg",FirstName="lea",ApartmentNumber=3,AmounPayments=3,MailTenant="gold@lea.co.il",PhoneTenant="0583265548"}
            };

            HouseCommitteeList = new List<HouseCommittee>
            {
                new HouseCommittee{FamilyHouseCommittee="levi",FirstHouseCommittee="avraham",MailHouseCommittee="leviAv@gmail.com",PhoneHouseCommittee="0583269985" },
                new HouseCommittee{FamilyHouseCommittee="kazth",FirstHouseCommittee="rachel",MailHouseCommittee="katzhRachel@gmail.com",PhoneHouseCommittee="05987453624"},
                new HouseCommittee{FamilyHouseCommittee="lando",FirstHouseCommittee="sara",MailHouseCommittee="sara_lando@gmail.com",PhoneHouseCommittee="0534178566"}
            };
        }
    }
}
