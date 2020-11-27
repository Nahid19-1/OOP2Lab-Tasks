using System;

namespace Interface_T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia n1 = new Nokia();
           
            MusicFile m1 = new MusicFile("Bangla", "Miles", 2002, 250);
            MusicFile m2 = new MusicFile("Bangla", "Habib", 2002, 300);
            MusicFile m3 = new MusicFile("Bangla", "Sakib", 2002, 400);
            MusicFile m4 = new MusicFile("Bangla", "Nahid", 2002, 200);

            n1.AddMusic(m1, m2, m3, m4);
            n1.ShowNokiaInfo();
            n1.SetVolume(5);

            n1.Switch(true);

            n1.Play(true);
        }
    }
}
