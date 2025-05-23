using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource menuMusicSource;
    public AudioSource gameMusicSource;

    public AudioClip easyMusic;
    public AudioClip mediumMusic;
    public AudioClip hardMusic;

    void Start()
    {
        menuMusicSource.Play(); // Menu music starts
    }

    public void SelectDifficulty(string difficulty)
    {
        // Stop menu music
        if (menuMusicSource.isPlaying)
        {
            menuMusicSource.Stop();
        }

        // Select music according to difficulty
        switch (difficulty)
        {
            case "easy":
                gameMusicSource.clip = easyMusic;
                break;
            case "medium":
                gameMusicSource.clip = mediumMusic;
                break;
            case "hard":
                gameMusicSource.clip = hardMusic;
                break;
        }

        gameMusicSource.Play();

        // Here you could start the game (activate game UI, etc.)
        Debug.Log("Juego iniciado con dificultad: " + difficulty);
    }
}
