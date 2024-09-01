using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{

    public class AppSoundPlayer
    {
        public SoundPlayer ThemeMusic { get; set; }
        public SoundPlayer FightMusic { get; set; }
        public SoundPlayer CoinsSpent { get; set; }
        public SoundPlayer Death { get; set; }
        public SoundPlayer GameBonus { get; set; }
        public SoundPlayer MagicShop { get; set; }
        public SoundPlayer ShopEnter { get; set; }
        public SoundPlayer SwordHit1 { get; set; }
        public SoundPlayer SwordHit2 { get; set; }

        public SoundPlayer CurrentSoundPlayer { get; set; }
        public AppSoundPlayer() 
        {
            ThemeMusic = new SoundPlayer("sound/The-Elder-Scrolls-IV-Oblivion-Soundtrack-04-Harvest-Dawn.wav");
            ThemeMusic.PlayLooping();



            FightMusic = new SoundPlayer("sound/fightMusic.wav");


            CoinsSpent = new SoundPlayer("sound/coinsSpent.wav");
            Death = new SoundPlayer("sound/death.wav");
            GameBonus = new SoundPlayer("sound/gameBonus.wav");
            MagicShop = new SoundPlayer("sound/magicShop.wav");
            ShopEnter = new SoundPlayer("sound/shopEnter.wav");
            SwordHit1 = new SoundPlayer("sound/swordHit1.wav");
            SwordHit2 = new SoundPlayer("sound/swordHit2.wav");


        }

        public void StopAll()
        {
            CoinsSpent.Stop();
            Death.Stop();
            GameBonus.Stop();
            MagicShop.Stop();
            ShopEnter.Stop();
            SwordHit1.Stop();
            SwordHit2.Stop();
        }
        public void PlayThemeSong ()
        {
            if (CurrentSoundPlayer == ThemeMusic)
            {
                return;
            }
            FightMusic.Stop();
            CurrentSoundPlayer = ThemeMusic;
            ThemeMusic.PlayLooping();
        }

        public void PlayFightMusic ()
        {
            if (CurrentSoundPlayer == FightMusic)
            {
                return;
            }
            ThemeMusic.Stop();
            CurrentSoundPlayer = FightMusic;
            FightMusic.PlayLooping();   
        }

        public void PlayCoinsSpent()
        {
            new Thread(() =>
            {
                CurrentSoundPlayer.Stop();
                CoinsSpent.PlaySync();
                CurrentSoundPlayer.PlayLooping();
            }).Start();
        }

        public void PlayDeath()
        {
            new Thread(() =>
            {
                CurrentSoundPlayer.Stop();
                Death.PlaySync();
                CurrentSoundPlayer.PlayLooping();
            }).Start();
        }

        public void PlayGameBonus()
        {
            new Thread(() =>
            {
                CurrentSoundPlayer.Stop();
                GameBonus.PlaySync();
                CurrentSoundPlayer.PlayLooping();
            }).Start();
        }

        public void PlayMagicShop()
        {
            new Thread(() =>
            {
                CurrentSoundPlayer.Stop();
                MagicShop.PlaySync();
                CurrentSoundPlayer.PlayLooping();
            }).Start();
        }

        public void PlayShopEnter()
        {
            new Thread(() =>
            {
                CurrentSoundPlayer.Stop();
                ShopEnter.PlaySync();
                CurrentSoundPlayer.PlayLooping();
            }).Start();
        }

        public void PlaySwordHit()
        {
            StopAll();
            new Thread( () =>
            {
                SoundPlayer soundToPlay;
                double x = new Random().Next();
                if (x > 0.5)
                {
                    soundToPlay = SwordHit1;
                }
                else
                {
                    soundToPlay = SwordHit2;
                }
                CurrentSoundPlayer.Stop();
                soundToPlay.PlaySync();
                CurrentSoundPlayer.PlayLooping();
            }).Start();

        }



    }
}
