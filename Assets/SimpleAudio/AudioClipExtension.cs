using UnityEngine;

namespace SimpleAudio
{
    public static class AudioClipExtension
    {
        public static AudioSource PlayAtPoint(this AudioClip audioClip, float volume, float pitch, bool looped, Vector3 position)
        {
            return Audio.PlaySoundAtPoint(audioClip, volume, pitch, looped, position);
        }

        public static AudioSource PlayAtPoint(this AudioClip audioClip, float volume, float pitch, Vector3 position)
        {
            return Audio.PlaySoundAtPoint(audioClip, volume, pitch, false, position);
        }

        public static AudioSource PlayAtPoint(this AudioClip audioClip, float volume, Vector3 position)
        {
            return Audio.PlaySoundAtPoint(audioClip, volume, 1, false, position);
        }

        public static AudioSource PlayAtPoint(this AudioClip audioClip, Vector3 position)
        {
            return Audio.PlaySoundAtPoint(audioClip, 1, 1, false, position);
        }

        public static AudioSource PlayAtPoint(this AudioClip audioClip, float volume, bool looped, Vector3 position)
        {
            return Audio.PlaySoundAtPoint(audioClip, volume, 1, looped, position);
        }

        public static AudioSource PlaySoundAttached(this AudioClip audioClip, Transform attachTo, float volume, float pitch, bool looped, Vector3 localPosition)
        {
            return Audio.PlaySoundAttached(attachTo, audioClip, volume, pitch, looped, localPosition);
        }

        public static AudioSource PlaySoundAttached(this AudioClip audioClip, Transform attachTo, float volume, float pitch, bool looped)
        {
            return Audio.PlaySoundAttached(attachTo, audioClip, volume, pitch, looped, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(this AudioClip audioClip, Transform attachTo, float volume, float pitch)
        {
            return Audio.PlaySoundAttached(attachTo, audioClip, volume, pitch, false, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(this AudioClip audioClip, Transform attachTo, float volume)
        {
            return Audio.PlaySoundAttached(attachTo, audioClip, volume, 1, false, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(this AudioClip audioClip, Transform attachTo)
        {
            return Audio.PlaySoundAttached(attachTo, audioClip, 1, 1, false, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(this AudioClip audioClip, Transform attachTo, float volume, bool looped, Vector3 localPosition)
        {
            return Audio.PlaySoundAttached(attachTo, audioClip, volume, 1, looped, localPosition);
        }

        public static AudioSource PlaySoundAttached(this AudioClip audioClip, Transform attachTo, float volume, bool looped)
        {
            return Audio.PlaySoundAttached(attachTo, audioClip, volume, 1, looped, Vector3.zero);
        }

        public static AudioSource Play(this AudioClip audioClip, float volume, float pitch, bool looped)
        {
            return Audio.PlaySound(audioClip, volume, pitch, looped);
        }

        public static AudioSource Play(this AudioClip audioClip, float volume, float pitch)
        {
            return Audio.PlaySound(audioClip, volume, pitch, false);
        }

        public static AudioSource Play(this AudioClip audioClip, float volume)
        {
            return Audio.PlaySound(audioClip, volume, 1, false);
        }

        public static AudioSource Play(this AudioClip audioClip)
        {
            return Audio.PlaySound(audioClip, 1, 1, false);
        }

        public static AudioSource Play(this AudioClip audioClip, float volume, bool looped)
        {
            return Audio.PlaySound(audioClip, volume, 1, looped);
        }
    }
}
