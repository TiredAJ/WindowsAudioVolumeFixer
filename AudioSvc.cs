using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAudioVolumeFixer
{
    //look at https://stackoverflow.com/questions/14306048/controlling-volume-mixer for mixer volume access

    public sealed class AudioSVC
    {
        bool FirstRun;
        Dictionary<string, float> AppVolumes = new Dictionary<string, float>();

        public AudioSVC()
        {FirstRun = true;}

        public void DoStuff()
        {
            if (FirstRun)
            {
                FirstRun = false;


            }
            else
            {

            }
        }

        private void LoadDefaults()
        {

        }
    }

    public static class DefaultSettings
    {
        public static float Volume = 25;
    }
}
