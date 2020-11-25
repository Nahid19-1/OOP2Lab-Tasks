using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_T3
{
    class Nokia : MusicFile,IMusicPlayer,IRadioPlayer
    {
        public Nokia()
        {

        }
        public Nokia(string title, string artist, int yearOfRelease, int durationInSeconds): base( title, artist, yearOfRelease, durationInSeconds)
        {

        }



         public void Play(bool on)
         {
            Console.WriteLine("The devision is : " );
        }

         public void PlayNext()
         {
            Console.WriteLine("The devision is : ");
        }

         public void PlayPrevious()
         {
            Console.WriteLine("The devision is : ");
        }

         public void SetVolume(int loudness)
         {
            Console.WriteLine("The devision is : ");
        }

         public void Switch(bool on)
         {
            Console.WriteLine("The devision is : ");
        }
        public void ChangeChannel()
        {
            Console.WriteLine("The devision is : ");
            //throw new NotImplementedException();
        }

        public void Retune(double frequency)
        {
            Console.WriteLine("The devision is : ");
            //throw new NotImplementedException();
        }

        
    }
}
