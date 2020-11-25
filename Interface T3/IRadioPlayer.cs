using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_T3
{
    interface IRadioPlayer
    {
        void Switch(Boolean on);
        void Retune(double frequency);
        void SetVolume(int loudness);
        void ChangeChannel();
    }
}
