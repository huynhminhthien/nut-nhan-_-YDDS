using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace test_video
{
    class AutoIt
    {
        AutoItX3 auto = new AutoItX3();
        public void mclick(string clickside,int x, int y, int manyclick, int speed)
        {
            auto.MouseClick(clickside,x,y,manyclick,speed);
        }
    }
}
