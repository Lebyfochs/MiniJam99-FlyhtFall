using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visitor : MonoBehaviour
{

    [SerializeField] private Vector3 visitorPos;
    [SerializeField] private float foodChuck;
    public Transform playerPenguinOBJ;

    public GameObject throwOBJ;
    public float throwCooldown;
    public Transform throwPoint;
    
    void Start()
    {
        visitorPos = transform.position;
    }

   
    void Update()
    {
        throwCooldown += Time.deltaTime;
        throwFood();
        
    }

    //For throwing food at the player (if close enough to visitor object).
    public void throwFood()
    {
        foodChuck = Vector3.Distance(playerPenguinOBJ.position, visitorPos);

        if (foodChuck < 95f)
        {
            //Debug.Log("Throwing");
            if (throwCooldown >= 5f)
            {
                Instantiate(throwOBJ, throwPoint.position, throwPoint.rotation);
                throwCooldown = 0;
            }

        }

        
    }
}
