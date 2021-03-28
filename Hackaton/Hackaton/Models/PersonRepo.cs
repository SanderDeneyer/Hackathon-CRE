using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackaton.Models
{
    public class PersonRepo
    {
        public static List<Person> People;
        public static List<RiskStatus> Risks;
        public static List<RiskStatus> Risks2;

        public PersonRepo()
        {
            if(People== null)
            {
                Initialize();
            }
        }

        private void Initialize()
        {
            Risks = new List<RiskStatus>
            {
                //new RiskStatus{ID = 3, Date = DateTime.Now, RiskNumber = 2}
            };

            Risks2 = new List<RiskStatus>
            {
                new RiskStatus{pID = 2, ID = 1, Description="Visisting grand ma", Date = DateTime.Now, RiskNumber = 90},
                new RiskStatus{pID = 2, ID=2, Description="Going to the skatepark with the bros and a face mask", Date = DateTime.Now, RiskNumber = 34}
            };

            People = new List<Person>
            {
                new Person{ID = 1, FirstName= "Jhon", LastName = "Doe", RiskStatus = Risks },
                new Person{ID = 2, FirstName= "Natasha", LastName = "Romanof", RiskStatus = Risks2 }
            };       

        }

        public Person GetPersonById(int id) { 
            return People.Find(x => x.ID == id);
        }

        public List<RiskStatus> GetAllRisksByPerson(int id)
        {
            Person p = People.Find(x => x.ID == id);
            return p.RiskStatus;
        }

        public void AddRiskStatusToPerson(RiskStatus rs, int id)
        {
            Person p = People.Find(x => x.ID == id);
            RiskStatus riskStatus = p.RiskStatus.LastOrDefault();
            if(riskStatus == null)
            {
                rs.ID = 1;
            }
            else
            {
                rs.ID = riskStatus.ID + 1;
            }
            rs.pID = id;
            p.RiskStatus.Add(rs);
        }

        public void CreatePerson(Person person)
        {
            Person p = People.LastOrDefault();
            if(p == null)
            {
                person.ID = 1;
            }
            else
            {
                person.ID = p.ID + 1;
            }
            person.RiskStatus = new List<RiskStatus>();
            People.Add(person);
        }

        public List<Person> GetAllPeople()
        {
            return People;
        } 

        public void DeletePerson(int id)
        {

            People.Remove(People.Find(x => x.ID == id));
        }

        public void DeleteRiskStatusOfPerson ( int pId, int rId)
        {
            Person p = People.Find(x => x.ID == pId);

            p.RiskStatus.Remove(p.RiskStatus.Find(x => x.ID == rId));
        }

        public RiskStatus GetRiskStatusByIdAndPId (int pId, int rId)
        {
            Person p = People.Find(x => x.ID == pId);
            return p.RiskStatus.Find(x => x.ID == rId);
        }

    }
}
