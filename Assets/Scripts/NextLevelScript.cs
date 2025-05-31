using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevelScript : MonoBehaviour
{
    public AudioClip welcomeSound;
    void Start()
    {
        welcomeSound = Resources.Load("Sounds/Maplestory Theme Music  Intro") as AudioClip;
    }
    void OnTriggerEnter(Collider col)
    {

        //System.GC.Collect();
        
        if (col.gameObject.tag == "Player" && GameManager.kills ==5)
        {
            AudioSource.PlayClipAtPoint(welcomeSound, col.gameObject.transform.position);
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
    }

}
