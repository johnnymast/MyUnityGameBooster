using UnityEngine.Audio;
using UnityEngine;

namespace GameBooster.Managers.Audio
{
    [System.Serializable]
    public class Sound
    {
        public string name;

        public AudioClip clip;

        [Range(0f, 1f)] public float volume = 0.78f;

        [Range(.1f, 3f)] public float pitch = 1f;

        public bool loop = false;

        public bool mute = false;

        [HideInInspector] public AudioSource source;
    }
}