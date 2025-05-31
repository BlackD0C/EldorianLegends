using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionSound : MonoBehaviour
{
    public AudioClip drinkPotion;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(drinkPotion, gameObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
        AudioSource.PlayClipAtPoint(drinkPotion, gameObject.transform.position);
    }
}
