using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public BaseState activeState; //Property for the patrol state


    public void Initialize()
    {
        ChangeState(new PatrolState());
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (activeState != null)
            activeState.Perform();
    }
    public void ChangeState(BaseState newState)
    {
        if (activeState != null)
            activeState.Exit(); //Run cleanup on activeState.  

        activeState = newState; //Change to a new state

        if (activeState != null) //Fail-safe null chekc to make sure new state wasn't null
        {
            activeState.stateMachine = this; //Setup a new state
            activeState.enemy = GetComponent<Enemy>();
            activeState.Enter();

        }

    }
}
