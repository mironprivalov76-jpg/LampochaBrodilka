using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class ExampleClass : MonoBehaviour
{
    public Transform player;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
void Update()
{
   agent.SetDestination(player.position);
}
}