using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Used for handling AI states of different NPCs.
//Based on code from previous game jam.

public interface IState
{
    public IEnumerator doState();
}

public class AIStateHandler : MonoBehaviour
{
    //Call interface and instances of NPC objects.
    IState currentState;
    NPCPatronAgent AIpatron;
    NPCPenguinAgent AIpenguin;

    Coroutine coroutine1;
    Coroutine coroutine2;
    public AIStateHandler(IState state, NPCPatronAgent patron, NPCPenguinAgent penguin)
    {
        currentState = state;
        this.AIpatron = patron;
        this.AIpenguin = penguin;

        changeState(state);
    }

    public void changeState(IState newState)
    {
        if (coroutine1 != null)
        {
            AIpatron.StopCoroutine(coroutine1);
           
            coroutine1 = null;
        }
        coroutine1 = AIpatron.StartCoroutine(currentState.doState());

        if(coroutine2 != null)
        {
            AIpenguin.StopCoroutine(coroutine2);
            coroutine2 = null;
        }
        coroutine2 = AIpenguin.StartCoroutine(currentState.doState());
    }
}
