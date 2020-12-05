using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip explosionSound;
    public static AudioSource audiosrc;
    // Start is called before the first frame update
    void Start()
    {
        explosionSound = Resources.Load<AudioClip>("explosion");
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void playsound(string clip)
    {
        switch(clip)
        {
            case "explosion":
                audiosrc.PlayOneShot(explosionSound);
                break;
        }
    }
}
