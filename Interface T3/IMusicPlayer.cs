using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_T3
{
    interface IMusicPlayer
    {
        void Switch(Boolean on);
        void Play(Boolean on);
        void SetVolume(int loudness);
        void PlayNext();
        void PlayPrevious();

    }
}
