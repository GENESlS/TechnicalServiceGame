using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour
{
    /*
    private Sound[] sounds;

    private void Awake()
    {
        sounds = GameObject.Find("AudioManager").GetComponent<AudioManager>().sounds;
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    } */
    public void Load()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
