using Microsoft.AspNetCore.Mvc;
using Moq;
using WEB_API_PROJ.Controllers;
using WEB_API_PROJ.Entities;
using WEB_API_PROJ.Services;

namespace TestProject
{
    [TestClass]
    public class HeroControllerTest
    {
        [TestMethod]
        public void GetAllReturnsAllHeroes()
        {
            // Arrange
            var heroData = new Mock<IHeroData>();

            
            heroData.Setup(d => d.GetAll()).Returns(new List<Hero>
            {
              new Hero
                 {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 30,
                    Race = Race.Humans,
                    Specialication = Specialication.Warrior
                 },
                new Hero
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Age = 25,
                    Race = Race.Dwarfs,
                    Specialication = Specialication.Priest
                },
                new Hero
                {
                    Id = 3,
                    FirstName = "Peter",
                    LastName = "Smith",
                    Age = 40,
                    Race = Race.Orcs,
                    Specialication = Specialication.Hunter
                },
                new Hero
                {
                    Id = 4,
                    FirstName = "Mary",
                    LastName = "Jones",
                    Age = 35,
                    Race = Race.Elfs,
                    Specialication = Specialication.Shaman
                },
                new Hero
                {
                    Id = 5,
                    FirstName = "Bill",
                    LastName = "Johnson",
                    Age = 20,
                    Race = Race.Trols,
                    Specialication = Specialication.Warrior
                },
                new Hero
                {
                    Id = 6,
                    FirstName = "Susan",
                    LastName = "Williams",
                    Age = 18,
                    Race = Race.Humans,
                    Specialication = Specialication.Priest
                },
                new Hero
                {
                    Id = 7,
                    FirstName = "David",
                    LastName = "Brown",
                    Age = 50,
                    Race = Race.Humans,
                    Specialication = Specialication.Shaman
                }
            });

            var controller = new HeroesController(heroData.Object);

            
            var result = controller.GetAll();
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var heroes = (result as OkObjectResult).Value as IEnumerable<Hero>;


            Assert.AreEqual(7, heroes.Count()); 
        }


        
        [TestMethod]
        public void GetReturnsHeroById_number1()
        {
            // Arrange
            var heroData = new Mock<IHeroData>();   
            var controller = new HeroesController(heroData.Object);

            
            var existingHero = new Hero
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                Race = Race.Humans,
                Specialication = Specialication.Warrior
            };
            heroData.Setup(d => d.Get(1)).Returns(existingHero);

            // Act
            var result = controller.Get(1);

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            var hero = (result as OkObjectResult).Value as Hero;
            Assert.AreEqual(1, hero.Id);
        }


        [TestMethod]
        public void GetReturnsHeroById()
        {// Arrange
            var heroData = new Mock<IHeroData>();
            var controller = new HeroesController(heroData.Object);


            


        


    }
}