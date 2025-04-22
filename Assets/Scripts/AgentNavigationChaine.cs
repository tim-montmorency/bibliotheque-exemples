using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentNavigationChaine : MonoBehaviour
{
    public GameObject objetCible;
    
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //InvokeRepeating("RecalculerRoute", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(objetCible.transform.position);

    }

    void RecalculerRoute()
    {
    }
}
