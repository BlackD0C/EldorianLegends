using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //Add or remove an InteractionEvent component to this gameobject.
    public bool useEvents;

    // message displayed to a player when looking at interactable
    [SerializeField]
    public string promptMessage;


    /* public virtual string OnLook()
     {
         return promptMessage;
     }*/
    //This function will be called from our player
    public void BaseInteract()
    {
        if (useEvents)
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
    }
    protected virtual void Interact()
    {
        // We won't have written in this function
        // This is a template to be overwritten by our subclasses
    }
}
