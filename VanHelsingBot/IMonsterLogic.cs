using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanHelsingBot
{
    internal interface IMonsterLogic
    {
        public void AddMonster (Monster monster);
        public List<Monster> GetMonster();

        public List<Monster> GetAllMonsters();


    }
}
