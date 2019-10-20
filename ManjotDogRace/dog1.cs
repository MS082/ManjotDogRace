using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManjotDogRace
{
   public class dog1
    {
        int tm = 0;
        public int jump(int y) {
            DateTime now = DateTime.Now;

            tm = DateTime.Now.Second;
            Random rd = new Random();
            tm =rd.Next(1,30);
            tm = tm + y;
            return tm;
        }
        public Boolean winner()
        {
            if (tm > 700)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
