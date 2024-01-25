using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volume
{
    internal class radio
    {
        public float volume { get; set; }


        public float aumentavolume(float volume)
        {
            volume = volume + (volume / 10);

            return volume;
        }

        public float abbassavolume(float volume)
        {
            volume = volume - (volume / 10);

            return volume;
        }
    }
}
