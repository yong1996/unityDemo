using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private GameObject end;
    private UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        end = GameObject.FindWithTag("end");
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.SetDestination(end.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(end.transform.position);
    }
}
