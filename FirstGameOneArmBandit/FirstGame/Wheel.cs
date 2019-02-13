using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    public class Wheel
    {
        static Random rand = new Random();

        public enum images { BMTH, FB, Mouse, OM_M, Snake, TTS, _7}

        private images[] theWheel = new images[7];

    }
}
