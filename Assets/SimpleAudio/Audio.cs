using System;
using System.IO;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Networking;

namespace SimpleAudio
{
    public static class Audio
    {
        public static AudioMixerGroup DefaultAudioMixerGroup { get; set; }

        public static AudioSource PlaySoundAtPoint(AudioClip audioClip, float volume, float pitch, bool looped, Vector3 position)
        {
            AudioSource audioSource = new GameObject($"{audioClip.name} Sound").AddComponent<AudioSource>();

            audioSource.transform.localPosition = position;
            audioSource.transform.localRotation = Quaternion.identity;

            audioSource.clip = audioClip;
            audioSource.spatialBlend = 1;
            audioSource.volume = volume;
            audioSource.pitch = pitch;
            audioSource.loop = looped;
            audioSource.playOnAwake = false;
            audioSource.outputAudioMixerGroup = DefaultAudioMixerGroup;

            audioSource.Play();

            if (!looped)
            {
                audioSource.gameObject.AddComponent<Sound>().SoundLength = audioClip.length;
            }

            return audioSource;
        }

        public static AudioSource PlaySoundAtPoint(AudioClip audioClip, float volume, float pitch, Vector3 position)
        {
            return PlaySoundAtPoint(audioClip, volume, pitch, false, position);
        }

        public static AudioSource PlaySoundAtPoint(AudioClip audioClip, float volume, Vector3 position)
        {
            return PlaySoundAtPoint(audioClip, volume, 1, false, position);
        }

        public static AudioSource PlaySoundAtPoint(AudioClip audioClip, Vector3 position)
        {
            return PlaySoundAtPoint(audioClip, 1, 1, false, position);
        }

        public static AudioSource PlaySoundAtPoint(AudioClip audioClip, float volume, bool looped, Vector3 position)
        {
            return PlaySoundAtPoint(audioClip, volume, 1, looped, position);
        }

        public static AudioSource PlaySoundAtPoint(string soundPath, float volume, float pitch, Vector3 position)
        {
            return PlaySoundAtPoint(LoadSound(soundPath), volume, pitch, false, position);
        }

        public static AudioSource PlaySoundAtPoint(string soundPath, float volume, Vector3 position)
        {
            return PlaySoundAtPoint(LoadSound(soundPath), volume, 1, false, position);
        }

        public static AudioSource PlaySoundAtPoint(string soundPath, Vector3 position)
        {
            return PlaySoundAtPoint(LoadSound(soundPath), 1, 1, false, position);
        }

        public static AudioSource PlaySoundAtPoint(string soundPath, float volume, bool looped, Vector3 position)
        {
            return PlaySoundAtPoint(LoadSound(soundPath), volume, 1, looped, position);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, AudioClip audioClip, float volume, float pitch, bool looped, Vector3 localPosition)
        {
            AudioSource audioSource = PlaySoundAtPoint(audioClip, volume, pitch, looped, localPosition);
            audioSource.transform.SetParent(attachTo);
            audioSource.transform.localPosition = localPosition;
            return audioSource;
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, AudioClip audioClip, float volume, float pitch, bool looped)
        {
            return PlaySoundAttached(attachTo, audioClip, volume, pitch, looped, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, AudioClip audioClip, float volume, float pitch)
        {
            return PlaySoundAttached(attachTo, audioClip, volume, pitch, false, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, AudioClip audioClip, float volume)
        {
            return PlaySoundAttached(attachTo, audioClip, volume, 1, false, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, AudioClip audioClip)
        {
            return PlaySoundAttached(attachTo, audioClip, 1, 1, false, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, AudioClip audioClip, float volume, bool looped, Vector3 localPosition)
        {
            return PlaySoundAttached(attachTo, audioClip, volume, 1, looped, localPosition);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, AudioClip audioClip, float volume, bool looped)
        {
            return PlaySoundAttached(attachTo, audioClip, volume, 1, looped, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, string soundPath, float volume, float pitch, bool looped, Vector3 localPosition)
        {
            return PlaySoundAttached(attachTo, LoadSound(soundPath), volume, pitch, looped, localPosition);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, string soundPath, float volume, float pitch, bool looped)
        {
            return PlaySoundAttached(attachTo, LoadSound(soundPath), volume, pitch, looped, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, string soundPath, float volume, float pitch)
        {
            return PlaySoundAttached(attachTo, LoadSound(soundPath), volume, pitch, false, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, string soundPath, float volume)
        {
            return PlaySoundAttached(attachTo, LoadSound(soundPath), volume, 1, false, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, string soundPath)
        {
            return PlaySoundAttached(attachTo, LoadSound(soundPath), 1, 1, false, Vector3.zero);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, string soundPath, float volume, bool looped, Vector3 localPosition)
        {
            return PlaySoundAttached(attachTo, LoadSound(soundPath), volume, 1, looped, localPosition);
        }

        public static AudioSource PlaySoundAttached(Transform attachTo, string soundPath, float volume, bool looped)
        {
            return PlaySoundAttached(attachTo, LoadSound(soundPath), volume, 1, looped, Vector3.zero);
        }

        public static AudioSource PlaySound(AudioClip audioClip, float volume, float pitch, bool looped)
        {
            AudioSource audioSource = PlaySoundAttached(Camera.main.transform, audioClip, volume, pitch, looped, Vector3.zero);
            audioSource.spatialBlend = 0;
            return audioSource;
        }

        public static AudioSource PlaySound(AudioClip audioClip, float volume, float pitch)
        {
            return PlaySound(audioClip, volume, pitch, false);
        }

        public static AudioSource PlaySound(AudioClip audioClip, float volume)
        {
            return PlaySound(audioClip, volume, 1, false);
        }

        public static AudioSource PlaySound(AudioClip audioClip)
        {
            return PlaySound(audioClip, 1, 1, false);
        }

        public static AudioSource PlaySound(AudioClip audioClip, float volume, bool looped)
        {
            return PlaySound(audioClip, volume, 1, looped);
        }

        public static AudioSource PlaySound(string soundPath, float volume, float pitch, bool looped)
        {
            return PlaySound(LoadSound(soundPath), volume, pitch, looped);
        }

        public static AudioSource PlaySound(string soundPath, float volume, float pitch)
        {
            return PlaySound(LoadSound(soundPath), volume, pitch, false);
        }

        public static AudioSource PlaySound(string soundPath, float volume)
        {
            return PlaySound(LoadSound(soundPath), volume, 1, false);
        }

        public static AudioSource PlaySound(string soundPath)
        {
            return PlaySound(LoadSound(soundPath), 1, 1, false);
        }

        public static AudioSource PlaySound(string soundPath, float volume, bool looped)
        {
            return PlaySound(LoadSound(soundPath), volume, 1, looped);
        }

        public static AudioClip LoadSound(string path)
        {
            AudioType audioType = AudioType.UNKNOWN;

            switch (Path.GetExtension(path))
            {
                case ".mp3":
                    audioType = AudioType.MPEG;
                    break;
                case ".mp2":
                    audioType = AudioType.MPEG;
                    break;
                case ".ogg":
                    audioType = AudioType.OGGVORBIS;
                    break;
                case ".wav":
                    audioType = AudioType.WAV;
                    break;
                case ".aiff":
                    audioType = AudioType.AIFF;
                    break;
                case ".aif":
                    audioType = AudioType.AIFF;
                    break;
                case ".mod":
                    audioType = AudioType.MOD;
                    break;
                case ".it":
                    audioType = AudioType.IT;
                    break;
                case ".s3m":
                    audioType = AudioType.S3M;
                    break;
                case ".xm":
                    audioType = AudioType.XM;
                    break;
                case ".vag":
                    audioType = AudioType.VAG;
                    break;
                case ".aac":
                    audioType = AudioType.ACC;
                    break;
                case ".acc":
                    audioType = AudioType.AUDIOQUEUE;
                    break;
                case ".m4a":
                    audioType = AudioType.AUDIOQUEUE;
                    break;
                case ".alac":
                    audioType = AudioType.AUDIOQUEUE;
                    break;
            }

            if (audioType == AudioType.UNKNOWN)
            {
                throw new Exception($"Can not load sound \"{path}\": Unknown audio type.");
            }

            using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(path, audioType))
            {
                www.SendWebRequest();
                while (!www.isDone) { }

                if (www.error != null)
                {
                    throw new Exception($"Sound loading error \"{path}\": {www.error}");
                }

                AudioClip audioClip = DownloadHandlerAudioClip.GetContent(www);
                audioClip.name = Path.GetFileNameWithoutExtension(path);

                return audioClip;
            }
        }
    }
}
