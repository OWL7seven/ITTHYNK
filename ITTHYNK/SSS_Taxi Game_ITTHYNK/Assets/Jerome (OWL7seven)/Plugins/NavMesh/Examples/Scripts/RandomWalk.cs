using UnityEngine;
using UnityEngine.AI;

// Walk to a random position and repeat
[RequireComponent(typeof(NavMeshAgent))]
public class RandomWalk : MonoBehaviour
{
    [SerializeField]
    private float m_Range = 25.0f;
    NavMeshAgent m_Agent;
    public float m_minDistance = 0.1f;
    public bool randomLocation = false;
    public Vector3 targetPosition;
    public Vector3 finalPosition;
    public float targetdistance;
    public bool atTarget;

    void Start()
    {
        m_Agent = GetComponent<NavMeshAgent>();
        if (randomLocation)
        {
            transform.position = RandomNavmeshLocation(m_Range);
        }
    }

    void Update()
    {
        targetPosition = m_Agent.destination;
            targetdistance = m_Agent.remainingDistance;
        if (m_Agent.pathPending || m_Agent.remainingDistance > m_minDistance)
            return;

        m_Agent.destination = RandomNavmeshLocation(m_Range);

        if (m_Agent.destination == transform.position)
        {
            atTarget = true;
        }
        else 
        {
            atTarget = false;
        }

       // GetArea();
    }
    public Vector3 RandomNavmeshLocation(float radius)
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
        Debug.DrawRay(m_Agent.transform.position, m_Agent.transform.up * -5f);
        if (m_Agent.Raycast(m_Agent.transform.up * -5f, out navMeshHit))
        {
            print(navMeshHit.mask);
        }
    }
}
