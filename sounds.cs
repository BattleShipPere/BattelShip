using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelShip
{
    public static class sounds
    {     
        public static System.Media.SoundPlayer Hundido = new System.Media.SoundPlayer(@"..\..\sounds\hundido.wav");
        public static System.Media.SoundPlayer Disparo = new System.Media.SoundPlayer(@"..\..\sounds\fire_shot.wav");
        public static System.Media.SoundPlayer Agua = new System.Media.SoundPlayer(@"..\..\sounds\shot_miss.wav");
        public static System.Media.SoundPlayer Tocado = new System.Media.SoundPlayer(@"..\..\sounds\shot_hit.wav");
    }
}
