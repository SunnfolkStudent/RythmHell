using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Menu_World
{
    public class MuteButton : MonoBehaviour
    {
        public bool isMuted;
        public Button muteButton;
        public Sprite muteSprite;
        public Sprite unMuteSprite;
        public AudioMixer Music;

        public void MutePress()
        {
            if (isMuted)
            {
                UnMute();
            }
            else
            {
                Mute();
            }
        }

        public void Mute()
        {
            muteButton.GetComponent<Image>().sprite = muteSprite;
            isMuted = true;
            Music.SetFloat("MenuVol", -80f);
            Music.SetFloat("MusicVol",20f);
        }
        public void UnMute()
        {
            muteButton.GetComponent<Image>().sprite = unMuteSprite;
            isMuted = false;
            Music.SetFloat("MusicVol",-10f);
            Music.SetFloat("MenuVol", -10f);
        }
    }
}
