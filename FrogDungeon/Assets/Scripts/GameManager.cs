using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHadEnded = false;

    bool Tet;

    public AudioClip beepSound;
    AudioSource audioSource;

    public GameObject gameOverScreen;
    public GameObject ExitScreen;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    public void DeadGame()
    {
        if (gameHadEnded == false)
        {
            gameHadEnded = true;

            FindObjectOfType<AudioManager>().Play("Dead");

            gameOverScreen.SetActive(true);
        }
    }

    public void ExitGame()
    {
        if (gameHadEnded == false)
        {
            gameHadEnded = true;

            FindObjectOfType<AudioManager>().Play("Exit");

            ExitScreen.SetActive(true);
        }
    }

    void Update() 
    {
        if (gameHadEnded == true && Input.GetKey(KeyCode.Z))
        {
            FindObjectOfType<AudioManager>().Play("Beep");

            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
