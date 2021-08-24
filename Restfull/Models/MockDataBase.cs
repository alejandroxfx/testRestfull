using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restfull.Models
{
    public class MockDataBase : IMockDataBase<Hobbie>
    {
        public List<Hobbie> GetTop10Hobbies()
        {

            List<Hobbie> data = new List<Hobbie>();
            data.Add(new Hobbie { Name = "Reading", Place = 1, Description = "Reading books, newspapers, and articles is one of the most common hobbies in every part of the world. Not only does reading inform and educate people, but it also allows them to experience life from the perspectives of other people." });
            data.Add(new Hobbie { Name = "Television", Place = 2, Description = "Television is much more than a box that shows moving images. It’s a doorway into a world of talk shows, dramas, mystery thrillers, and much more. In short, it’s an excellent way to spend your time while at home. I seem to recall it was one of our favorite hobbies as a student too!" });
            data.Add(new Hobbie { Name = "Collecting", Place = 3, Description = "There’s no end to the range of objects people collect: coins, pokemon cards, car parts and accessories, decoration items, books, and a lot more. Seeing your collection grow and include rare items is an incredibly satisfying and exciting experience." });
            data.Add(new Hobbie { Name = "Music", Place = 4, Description = "Whether it’s playing music or listening to it, there is no doubt that people all over the world regularly engage with music as a hobby. You could pick up a guitar and try to learn how to play it, or curate an album of your favorite songs and listen to them on repeat." });
            data.Add(new Hobbie { Name = "Gardening", Place = 5, Description = "You could try out gardening for several reasons: to produce your own food, beautify your lawn, spend time productively, or just relish the freshness of greenery every day. Gardening brings a deep sense of achievement, and this is why it’s one of the most common hobbies in the world." });
            data.Add(new Hobbie { Name = "Video Games", Place = 6, Description = "With exciting adventure-filled video games coming out every year, it is not surprising why this hobby is so common among children and adults alike. You could either play through an RPG by yourself or join an online community of PUBG players to compete against each other." });
            data.Add(new Hobbie { Name = "Fishing", Place = 7, Description = "Fishing is one of those hobbies that are ideal if you want to take a break from the grind of daily routine and give your mind a much-needed rest. Head over to a nearby lake or a calm river, and spend time basking in the beauty and peace of nature." });
            data.Add(new Hobbie { Name = "Walking", Place = 8, Description = "Walking is an excellent joint-friendly alternative to running which burns calories and improves your cardiovascular health. The best part is that you don’t need a designated place for it – just get out of your home and start walking." });
            data.Add(new Hobbie { Name = "Team Sports", Place = 9, Description = "Team sports like football, cricket, basketball, baseball, and hockey provide an excellent way for people to improve their physical health while having loads of fun at the same time." });
            data.Add(new Hobbie { Name = "Shopping", Place = 10, Description = "Thousands of people regularly flock over to malls for shopping. Some buy clothes and footwear, while others are on the lookout for watches and digital gadgets. Whatever your taste, you can make this a hobby for you and your family." });

            return data;

        }
        public Boolean Add(Hobbie model)
        {
            List<Hobbie> items = new List<Hobbie>();
            items.Add(model);
            return true;
        }

        public Boolean Delete(int place)
        {
            List<Hobbie> items = new List<Hobbie>();
            items.Remove(items.FirstOrDefault(m => m.Place == place));
            return true;
        }

        

        public Boolean Update(Hobbie model)
        {
            List<Hobbie> items = new List<Hobbie>();
            var item = items.FirstOrDefault(m => m.Place == model.Place);
            item.Description = model.Description;
            item.Name = model.Name;
            return true;
        }
    }
}
