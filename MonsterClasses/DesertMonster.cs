using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    public class DesertMonster : Monster
    {
        private string _homeDesert;
        private int _limbs;


        public int Limbs
        {
            get { return _limbs; }
            set { _limbs = value; }
        }


        public string HomeDesert
        {
            get { return _homeDesert; }
            set { _homeDesert = value; }
        }


        public override bool IsHappy()
        {
            return true;
        }

    }
}
