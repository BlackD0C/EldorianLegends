using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBoxScript : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(100);
        }
    }
}
