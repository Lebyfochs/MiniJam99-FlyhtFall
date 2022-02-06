using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCPenguinAgent : AIAgent
{

 
    AIStateHandler states;
    private IdleState idle;
    public NavMeshAgent navAI;
    private void Awake()
    {
        states = GetComponent<AIStateHandler>();
        idle = GetComponent<IdleState>();
        navAI = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        moveSpeed = Random.Range(2.0f, 4.0f);

        states = new AIStateHandler(idle, this);
    }


    void Update()
    {
        
    }
}
