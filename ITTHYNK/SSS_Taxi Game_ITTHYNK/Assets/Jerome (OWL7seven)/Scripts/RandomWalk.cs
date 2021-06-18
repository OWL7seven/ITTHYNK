/*
 * This code is part of Jerome Chetty Summision for ITTYHNK GameJam 2021
 */
using UnityEngine;
using UnityEngine.AI;

// Walk to a random position and repeat
[RequireComponent(typeof(NavMeshAgent))]
public class RandomWalk : MonoBehaviour
{
    [SerializeField]
    private float range = 25.0f;
    [SerializeField]
    public float minDistance = 0.1f;
    [SerializeField]
    public bool randomLocation = false;
    [SerializeField]
    private Vector3 targetPosition;
    [SerializeField]
    private Vector3 finalPosition;
    [SerializeField]
    private float targetdistance;
    [SerializeField]
    private bool atTarget;

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (randomLocation)
        {
            transform.position = RandomNavmeshLocation(range);
        }

        InvokeRepeating("Walk", 0, 15f);
    }

    private void Walk()
    {
        if (agent.isOnNavMesh)
        {
            targetPosition = agent.destination;
            targetdistance = agent.remainingDistance;

            if (agent.pathPending || agent.remainingDistance > minDistance)
            {
                return;
            }

            agent.destination = RandomNavmeshLocation(range);

            if (agent.destination == transform.position)
            {
                atTarget = true;
            }
            else
            {
                atTarget = false;
            }
        }
       // GetArea();
    }
    private Vector3 RandomNavmeshLocation(float radius)
    {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;

        NavMeshHit hit;
        finalPosition = Vector3.zero;

        if (NavMesh.SamplePosition(randomDirection, out hit, radius, 1))
        {
            finalPosition = hit.position;
        }
        return finalPosition;
    }

    private void GetArea()
    {
        NavMeshHit navMeshHit;
        Debug.DrawRay(agent.transform.position, agent.transform.up * -5f);

        if (agent.Raycast(agent.transform.up * -5f, out navMeshHit))
        {
            print(navMeshHit.mask);
        }
    }
}
