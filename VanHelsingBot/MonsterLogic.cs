using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanHelsingBot
{
    internal class MonsterLogic
    {
        private List<Monster>? _monsters;
        private Dictionary<string, Monster>? _monster;

        public MonsterLogic()
        {
            _monsters = new List<Monster>();
            _monster = new Dictionary<string, Monster>();
        }

        public void AddMonster(Monster monster) 
        {
            _monsters?.Add(monster);
        }

        public List<Monster> GetMonsters() 
        {
            return _monsters;
        }

        public Monster GetMonster(string name) 
        {
            return _monster[name];
        }
    }

}
