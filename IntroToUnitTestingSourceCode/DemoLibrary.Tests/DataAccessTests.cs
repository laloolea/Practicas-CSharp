using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;
using DemoLibrary.Models;

namespace DemoLibrary.Tests
{
    public class DataAccessTests
    {
      [Fact]
      public void AddPersonToPeopleList()
        {
            PersonModel newPerson = new PersonModel { FirstName="Tim",LastName="Corey"};
            List<PersonModel> people = new List<PersonModel>();

            DataAccess.AddPersonToPeopleList(people,newPerson);

            Assert.True(people.Count == 1);

            Assert.Contains(newPerson, people);

        }

        [Theory]
        [InlineData("Tim","","LastName")]
        [InlineData("", "aaa", "LastName")]
        [InlineData("aaa", "aaa", "a")]
        public void AddPersonToPeopleList_ShouldFail(string firstName,string lastName,string param)
        {
            PersonModel newPerson = new PersonModel { FirstName = firstName, LastName = lastName };
            List<PersonModel> people = new List<PersonModel>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, newPerson));
        }
    }
}
