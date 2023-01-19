using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanKiborgOsokin
{
    public class Human
    {        
            private int _head;
            private int _headpoint;
            public static int _headrad;
            private int _torso;
            private int _torsopoint1;
            private int _torsopoint2;
            public static int _torsoheight;
            public static int _torsowidth;
            private int _hands;
            private int _handcorner;
            private int _handheight;
            private int _legs;
            private int _legcorner;
            public static int _legheight;

            public  int Head
            {
                get { return _headrad; }
                set { _headrad = Convert.ToInt32(Console.ReadLine()); }
            }
            public int Torso
            {
                get { return _torsoheight; }
                set { _torsoheight = Convert.ToInt32(Console.ReadLine()); }
            }
            public int Leg
            {
                get { return _legheight; }
                set { _legheight = Convert.ToInt32(Console.ReadLine()); }
            }
            
            public class Kiborg : Human
            {

            }
        }
    }


