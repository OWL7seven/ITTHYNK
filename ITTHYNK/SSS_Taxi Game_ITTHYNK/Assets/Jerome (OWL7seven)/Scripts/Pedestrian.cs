using UnityEngine.AI;
using UnityEngine;

public class Pedestrian : MonoBehaviour
{
    public bool active;
    public bool male;

    public NavMeshAgent agent;
    public Animator animator;
    public RandomWalk randomWalk;

    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        //Debug.Log(collision.collider.name);
        if (collision.collider.gameObject.tag == "Player")
        {
            animator.enabled = false;
            randomWalk.enabled = false;
            if (agent.enabled)
            {
                agent.isStopped = true;
                agent.enabled = false;
            }
            GetComponent<CapsuleCollider>().enabled = false;
            enabled = false;
        }
    }

    public void EnterTaxi()
    {
        animator.enabled = false;
        randomWalk.enabled = false;
        if (agent.enabled)
        {
            agent.isStopped = true;
            agent.enabled = false;
        }
        enabled = false;

        transform.GetChild(transform.childCount - 2).gameObject.SetActive(false);
        transform.GetChild(transform.childCount - 1).gameObject.SetActive(false);

        // to activate new ped
        // PedestrianManager.Instance.GetActivePeds().Clear();
    }
}
