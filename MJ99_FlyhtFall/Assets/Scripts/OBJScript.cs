using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJScript : MonoBehaviour
{
    float OBJSpeed;
    float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        OBJSpeed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(OBJSpeed, OBJSpeed, 0.0f) * Time.deltaTime;
        lifeTime += Time.deltaTime;
        if (lifeTime >= 6)
        {
            Destroy(this.gameObject);
            lifeTime = Random.Range(0.05f, 2f);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {

        OBJSpeed = 0;

        if (collision.collider.name == "TEST_PLAYER")
        {
            Destroy(this.gameObject);
        }
    }



}
