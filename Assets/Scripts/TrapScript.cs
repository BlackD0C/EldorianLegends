using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScript : MonoBehaviour
{
    [SerializeField]
    GameObject box;
    public AudioClip shootSound;
    private bool played;
    void Start()
    {
        played = false;
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (!played)
            {
                AudioSource.PlayClipAtPoint(shootSound, other.gameObject.transform.position);
                played = true;
            }
               
            box.GetComponent<Rigidbody>().useGravity = true;
        }

    }
}
