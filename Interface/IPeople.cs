using System;
using System.Collections.Generic;
using dotnetcoremvc2.Models;

namespace dotnetcoremvc2.Interface
{
    public interface IPeople
    {
        public List<PersonModel> List();

        public void Create(PersonModel person);
        public PersonModel Detail(int ID);
        public void Update(PersonModel person);
        public PersonModel Delete(int id);
    }
}