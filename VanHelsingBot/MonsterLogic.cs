using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanHelsingBot
{
    internal class MonsterLogic: IMonsterLogic

    {
        private List<Monster>? _monsters;
        private Dictionary<string, Monster>? _monster;

        public MonsterLogic()
        {
            _monsters = new List<Monster>
            {
                new Monster
                {
                    Name ="Dracula.",
                    Description ="Vampire.",
                    Weakness= "Sunlight, Wooden stakes, Crosses, Holy Water, Garlic.",
                    Location="Transylvania, London."
                },
                new Monster
                {
                    Name="Wolfman",
                    Description="WereWolf",
                    Weakness="Silver Bullets",
                    Location="Transylvania",
                },
                new Monster
                {
                    Name="Frankenstein",
                    Description="Monster",
                    Weakness="Fire",
                    Location="Transylvania",
                },
                new Monster
                {
                    Name="Mummy",
                    Description="Undead Gaurdian",
                    Weakness="Fire",
                    Location="Egypt",
                }
            };
            _monsters = new List<Monster>();
            _monster = new Dictionary<string, Monster>();
        }

        public void AddMonster(Monster monster) 
        {
            if (monster is Monster)
            {
                _monster?.Add(monster.Name, monster as Monster);
            }
            _monsters.Add(monster);
        }

        public List<Monster> GetMonster() 
        {
            return _monsters;
        }

        public List<Monster> GetAllMonsters()
        {
            return _monsters;
        }

        public Monster? GetMonster(string name)
        {
            try
            {
                return _monster[name];
            }
            catch(Exception) 
            {
                
                return null;
            }
        }
    }

}
