using System.Collections;
using UnityEngine;

namespace SimpleAudio
{
    public class Sound : MonoBehaviour
    {
        public float SoundLength;

        private IEnumerator Start()
        {
            yield return new WaitForSeconds(SoundLength + 2);
            Destroy(gameObject);
        }
    }
}
