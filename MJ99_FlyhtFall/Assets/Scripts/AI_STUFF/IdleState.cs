using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : MonoBehaviour, IState
{
    NPCPenguinAgent penguin;
    //NPCPatronAgent patron;

    public float navRange = 10.0f;
    [SerializeField] private List<Transform> movPositionTrans = new List<Transform>();

    private void Awake()
    {
        penguin = GetComponent<NPCPenguinAgent>();
    }

    public IEnumerator doState()
    {
        while (true)
        {
            var newPos = movPositionTrans[Random.Range(0, movPositionTrans.Count)];
            penguin.navAI.destination = newPos.position;

            while (Vector3.Distance(transform.position, penguin.navAI.destination) > 0.5f)
            {
                yield return null;
            }
            yield return new WaitForSeconds(3.0f);
        }
    }
}
