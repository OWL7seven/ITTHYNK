using UnityEngine;
using UnityEngine.AI;

// Walk to a random position and repeat
[RequireComponent(typeof(NavMeshAgent))]
public class RandomWalk : MonoBehaviour
{
    public float m_Range = 25.0f;
    NavMeshAgent m_Agent;
    public float m_minDistance = 0.1f;
    public bool randomLocation = false;

    void Start()
    {
        m_Agent = GetComponent<NavMeshAgent>();
        if (randomLocation)
        {
            transform.localPosition = RandomNavmeshLocation(m_Range);
        }
    }

    void Update()
    {
        if (m_Agent.pathPending || m_Agent.remainingDistance > m_minDistance)
            return;

        m_Agent.destination = RandomNavmeshLocation(m_Range);        
    }
    public Vector3 RandomNavmeshLocation(float radius)
    {
        Vector3 randomDirection = Random.insideUnitSphere * radius;
        randomDirection += transform.position;
        NavMeshHit hit;
        Vector3 finalPosition = Vector3.zero;
        if (NavMesh.SamplePosition(randomDirection, out hit, radius, 1))
        {
            finalPosition = hit.position;
        }
        return finalPosition;
    }
}
