using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] public GameObject player;


    //COROUTINE.
    IEnumerator Fly()
    {
        //CODE HERE FOR FLYING UP AND FORWARD.
        //JANKY SYSTEM BUT KINDA INTERESTING.
        player.transform.position += transform.up * 12.0f * Time.deltaTime;
        player.transform.position += transform.forward * 8.0f * Time.deltaTime;
        //rb.useGravity = false;
        yield return null;
        player.transform.position += transform.forward * 7.0f * Time.deltaTime;
        yield return new WaitForSeconds(0.1f);
        //rb.useGravity = true;
        player.transform.position += transform.forward * 9.0f * Time.fixedDeltaTime;
        yield return null;


    }
    private void Awake()
    {
         rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
       
        
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if(Fly() != null)
            {
                StopCoroutine(Fly());
            }
            StartCoroutine(Fly());
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Rotate(0.0f, -60f * Time.fixedDeltaTime, 0.0f, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Rotate(0.0f, 60f * Time.fixedDeltaTime, 0.0f, Space.World);
        }

    }
  
}
