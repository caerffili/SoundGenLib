using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundGenLib
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundGenerator sg = new SoundGenerator();

            List<ToneDef> tt = new List<ToneDef>();
            List<ushort> frequencies = new List<ushort>();
            int cycles = 0;
            int duration = 0;
            ushort volume = 0;

            // Bias Tones
            if (true) {
           //     frequencies.Add(200);
                frequencies.Add(400);
              /*  frequencies.Add(1000);
                frequencies.Add(2000);
                frequencies.Add(3000);
                frequencies.Add(4000);
                frequencies.Add(5000);
                frequencies.Add(6000);
                frequencies.Add(7000);
                frequencies.Add(8000);
                frequencies.Add(9000);
                frequencies.Add(10000);
                frequencies.Add(11000);
                frequencies.Add(12000);
                frequencies.Add(13000);
                frequencies.Add(14000);
                frequencies.Add(15000);

                frequencies.Add(16000);*/

                cycles = 100;
                duration = 10000;
                volume = 65535;
            }

            // Azimuth Tones
            if (!true)
            {
                frequencies.Add(1000);
                cycles = 1;
                duration = 120000;
                volume = 16000;
            }

            for (int i = 0; i < cycles; i++)
            {
                foreach (ushort f in frequencies)
                {
                    tt.Add(new ToneDef { frequency = f, msDuration = duration, volume = volume });
                }
            }

            sg.PlayBeep(tt);

            Console.ReadKey();
        }
    }
}
