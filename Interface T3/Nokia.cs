using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_T3
{
    class Nokia : MusicFile,IMusicPlayer,IRadioPlayer
    {

        MusicFile[] listofmusicfile;
        public Nokia()
        {
            listofmusicfile = new MusicFile[100];
        }
        public Nokia(string title, string artist, int yearOfRelease, int durationInSeconds): base( title, artist, yearOfRelease, durationInSeconds)
        {
            listofmusicfile = new MusicFile[100];
        }
        private int totalMusic;

        public int TotalMusic
        {
            get { return totalMusic; }
            set { totalMusic = value; }
        }



        public void Play(bool on)
         {
            if (on == true)
            {
                Console.WriteLine("Play the song : "+ Title);
            }
         }

         public void PlayNext()
         {
            Console.WriteLine("Play the NEXT song : ");
         }

         public void PlayPrevious()
         {
            Console.WriteLine("Play the PREVIOUS song : ");
         }

         public void SetVolume(int loudness)
         { 
            Console.WriteLine("Set volume : "+loudness);
         }

         public void Switch(bool on)
         {
            Console.WriteLine("Switch to : "+on);
         }
        public void ChangeChannel()
        {
            
            Console.WriteLine("Change the channel : ");
            
        }

        public void Retune(double frequency)
        {
            Console.WriteLine("Return to previous Channel : "+frequency);
           
        }

        public void AddMusic(params MusicFile[] musics)
        {
            foreach(var music in musics)
            {
                if (totalMusic < 500)
                {
                    this.listofmusicfile[totalMusic++] = music;
                }
            }
        }

        public void ShowNokiaInfo()
        {
          for (int i =0; i< totalMusic; i++)
            {
                listofmusicfile[i].ShowMusicFileInfo();
            }
        }
    }
}
