using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_T3
{
    class MusicFile
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int YearOfRelease { get; set; }
        public int DurationInSeconds { get; set; }

        public MusicFile()
        {

        }
        public MusicFile(string title,string artist,int yearOfRelease, int durationInSeconds)
        {
            Title = title;
            Artist = artist;
            YearOfRelease = yearOfRelease;
            DurationInSeconds = durationInSeconds;
        }
        public void ChangeTitle(string title)
        {
            Title = title;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Title is :" + Title);
            Console.WriteLine("Artist Name :" + Artist);
            Console.WriteLine("Year Of Release :" + YearOfRelease);
            Console.WriteLine("Duration In Seconds :" + DurationInSeconds);
            Console.WriteLine("---------------------");
        }
    }
}
