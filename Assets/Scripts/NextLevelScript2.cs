using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript2 : MonoBehaviour
{
    public AudioClip welcomeSound;
    void Start()
    {
        welcomeSound = Resources.Load("Sounds/Maplestory Theme Music  Intro") as AudioClip;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && GameManager.kills == 9)
        {
            AudioSource.PlayClipAtPoint(welcomeSound, col.gameObject.transform.position);
            SceneManager.LoadScene(3, LoadSceneMode.Single);


        }

    }
}
