using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : MonoBehaviour
{
    public Text hellText;
    public float fadeSpeed = 5;
    public bool enterance = false;
    public bool sound = false;
    public AudioClip welcomeSound;
    void Start()
    {
        hellText.color = Color.white;
        welcomeSound = Resources.Load("Sounds/Maplestory Theme Music  Intro") as AudioClip;
    }
    void Update()
    {
        ColorChange();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            enterance = true;
            if(sound){
                AudioSource.PlayClipAtPoint(welcomeSound, col.gameObject.transform.position);
                sound = true;
            }
        }
            
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player"){
            enterance = false;
        }
    }
    private void ColorChange()
    {
        if (enterance)
            hellText.color = Color.Lerp(hellText.color, Color.white, fadeSpeed * Time.deltaTime);
        else
            if(!enterance)
            hellText.color = Color.Lerp(hellText.color, Color.clear, fadeSpeed * Time.deltaTime);
    }

}
