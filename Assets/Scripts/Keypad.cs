using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    public AudioClip gateSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Interact()
    {
        doorOpen = !doorOpen;
        AudioSource.PlayClipAtPoint(gateSound, transform.position);
        door.GetComponent<Animator>().SetBool("isOpen", doorOpen);
    }
}
