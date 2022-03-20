using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    int flag = 0, flag1 = 0, flag2 = 0;

    public static AudioManager instance;
    
    void Awake()
    {

        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = s.group;
        }
    }
    
    private void Update()
    {
        //Sound s = Array.Find(sounds, sound => sound.name == name);
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Menu" && flag == 0)
        {
            Play("Menu");
            flag = 1;
        } else if (scene.name == "Opening" && flag1 == 0)
        {
            StartCoroutine(Example());
            flag1 = 1;
        } else if (scene.name == "Episode 1" && flag2 == 0)
        {
            StopPlaying("Intro");
            Play("Theme");
            flag2 = 1;
        }
    } 

    public void Play(String name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");   
            return;
        }
        s.source.Play();
    }

    public void StopPlaying(string sound)
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-1 / 2f, 1 / 2f));
        s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-3 / 2f, 3 / 2f));

        s.source.Stop();
    }

    IEnumerator Example()
    {
        StopPlaying("Menu");
        yield return new WaitForSecondsRealtime(1);
        Play("Intro");
    }

}
