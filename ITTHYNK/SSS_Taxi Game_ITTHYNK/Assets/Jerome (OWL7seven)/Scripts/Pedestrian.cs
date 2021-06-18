/*
 * This code is part of Jerome Chetty Summision for ITTYHNK GameJam 2021
 */
using UnityEngine.AI;
using UnityEngine;

public class Pedestrian : MonoBehaviour
{
    // Needs a taxi
    public bool active;
    // Gender of ped
    public bool male;

    // agent attach to gameobject
    public NavMeshAgent agent;
    // animator attach to gameobject
    public Animator animator;
    // randomWalk attach to gameobject
    public RandomWalk randomWalk;

    // when the pedestrian collides with a taxi, it goes into ragdoll mode
    void OnCollisionEnter(Collision collision)
    {
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

    // called when activce pedestrian colliders with taxi
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
    }
}
