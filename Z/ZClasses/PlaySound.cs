using System.Media;

namespace Z.ZClasses
{
    internal class PlaySound
    {
        // The z, x, c and v keys at the beginning of the PlaySound method are
        // positioned close to the left shift key, which I use for naming the methods.

        // Methods
        public async Task zPlaySound()
        {
            await Task.Run(() =>
            {
                using (SoundPlayer soundPlayer = new SoundPlayer("ZSound.wav"))
                {
                    soundPlayer.Play();
                }
            });
        }

        public async Task xPlaySound()
        {
            await Task.Run(() =>
            {
                using (SoundPlayer soundPlayer = new SoundPlayer("ZSound2.wav"))
                {
                    soundPlayer.Play();
                }
            });
        }

        public async Task cPlaySound()
        {
            string[] sounds = {
                "Zed_PsyOps_Move_0.wav", "Zed_PsyOps_Move_1.wav", "Zed_PsyOps_Move_2.wav",
                "Zed_PsyOps_Move_3.wav", "Zed_PsyOps_Move_4.wav", "Zed_PsyOps_Move_5.wav",
                "Zed_PsyOps_Move_6.wav", "Zed_PsyOps_Move_7.wav", "Zed_PsyOps_Move_8.wav",
                "Zed_PsyOps_Move_9.wav"
            };

            Random random = new Random();
            string selectedSound = sounds[random.Next(sounds.Length)];

            await Task.Run(() =>
            {
                using (SoundPlayer soundPlayer = new SoundPlayer(selectedSound))
                {
                    soundPlayer.PlaySync();
                }
            });
        }

        public async Task vPlaySound()
        {
            await Task.Run(() =>
            {
                using (SoundPlayer soundPlayer = new SoundPlayer("JapaneseDrum.wav"))
                {
                    soundPlayer.Play();
                }
            });
        }
    }
}
