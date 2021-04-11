using UnityEngine.Audio;
using UnityEngine;
using System;

namespace GameBooster.Managers.Audio
{
    public class SimpleAudioManager : MonoBehaviour
    {
        public Sound[] sounds;
        public static SimpleAudioManager instance;

        /// <summary>
        /// On Awake load the sounds.
        /// </summary>
        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }

            DontDestroyOnLoad(gameObject);

            foreach (Sound s in sounds)
            {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;
                s.source.volume = s.volume;
                s.source.pitch = s.pitch;
                s.source.loop = s.loop;
                s.source.mute = s.mute;
            }
        }

        /// <summary>
        /// Play a sound by name.
        /// </summary>
        /// <param name="name">The sound to play</param>
        public void Play(string name)
        {
            Sound s = Array.Find(sounds, sound => sound.name == name);

            if (s == null)
            {
                Debug.LogError("Sound: " + name + " was not found");
                return;
            }

            s.source.Play();
        }
    }
}