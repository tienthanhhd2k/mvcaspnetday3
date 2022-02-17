using dotnetcoremvc2.Interface;
using dotnetcoremvc2.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcoremvc2.Implements
{
    public class PeopleImplement : IPeople
    {   
        public static List<PersonModel> people = new List<PersonModel>(){ 
            new PersonModel{
                Id = 1,
                FirstName = "Do",
                LastName = "Thanh",
                Address = "Hai Duong",
                Gender = "Male"
            },

            new PersonModel{
                Id = 2,
                FirstName = "Nguyen",
                LastName  = "Binh",
                Address = "Ha Noi",
                Gender = "Male"
            },

            new PersonModel{
                Id = 3,
                FirstName = "Tran",
                LastName = "Nam",
                Address = "Hai Phong",
                Gender = "Male"
            }
            };
        
        public List<PersonModel> List()
        {
            return people.OrderBy(p => p.Id).ToList();
        }

        public void Create(PersonModel model)
        {
            people.Add(model);
        }

        public void Update(PersonModel person)
        {
            var person1 = people.Where(x => x.Id == person.Id).FirstOrDefault();
            if(person1 != null)
            {
            person1.FirstName = person.FirstName;
            person1.LastName = person.LastName;
            person1.Address = person.Address;
            person1.Gender = person.Gender;
            }
        }

        public PersonModel Detail(int ID)
        {
            var person = people.Where(p => p.Id == ID).FirstOrDefault();
            return person;
        }

        public PersonModel Delete(int id)
        {
            var person = people.Where(person => person.Id == id).FirstOrDefault();
            if(person != null)
            {
                people.Remove(person);
            }
            return person;
        }
        
    }
}
