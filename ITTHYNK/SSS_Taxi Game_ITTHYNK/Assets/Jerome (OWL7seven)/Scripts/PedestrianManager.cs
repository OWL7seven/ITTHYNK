/*
 * This code is part of Jerome Chetty Summision for ITTYHNK GameJam 2021
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PedestrianManager : MonoBehaviour
{
    //Gobal reference to access instance of this class
    public static PedestrianManager Instance;

    //instantiate this class as gobal instance
    private void Awake()
    {
        Instance = this;
    }

    //Number of pedestrians to spawn
    [SerializeField]
    private int numberOfPeds = 10;

    //Number of pedestrians to spawn
    [SerializeField]
    private int numberOfActivePeds = 1;

    //Random spawning of pedestrians
    [SerializeField]
    private bool randomSpawn;

    //Pedestrian spawn radius
    [SerializeField]
    private float spawnRadius = 25f;

    //Pedestrian pickup radius
    [SerializeField]
    private float pickUpRadius = 10f;

    //Number of predestrian prefabs found in the resources
    //Hard coded for now
    //Will create a search fucntion that will check for current amount
    [SerializeField]
    private int numberOfPedPrefabs = 3;

    //list of active pedestrians
    [SerializeField]
    private List<NavMeshAgent> agents = new List<NavMeshAgent>();

    //list of pedestrians spawn points
    [SerializeField]
    private List<Transform> spawnPoints = new List<Transform>();

    //list of pedestrians that are active
    [SerializeField]
    private List<Pedestrian> activePeds = new List<Pedestrian>();

    private void Start()
    {
        if (randomSpawn)
        {
            SpawnRandomPositions();
        }
        else
        {
            SpawnLocations();
        }

        InvokeRepeating("ActivatePedestrians",0,1);
    }

    //Spawns peds in random locations of the nav mesh
    private void SpawnRandomPositions()
    {
        for (int i = 0; i < numberOfPeds; i++)
        {
            NavMeshAgent agent = Instantiate(Resources.Load<NavMeshAgent>($"Prefabs/Passenger_0{Random.Range(1, numberOfPedPrefabs + 1)}"));
            RandomWalk walk = agent.gameObject.AddComponent<RandomWalk>();
            walk.randomLocation = randomSpawn;
            agents.Add(agent);
        }
    }

    //Spawns peds at transform locations create in the children of this gamobject
    private void SpawnLocations()
    {
        foreach (Transform spawn in gameObject.GetComponentsInChildren<Transform>())
        {
            spawnPoints.Add(spawn);
        }
        foreach (Transform spawn in spawnPoints)
        {
            for (int i = 0; i < numberOfPeds; i++)
            {
                AddPedestrian(spawn);
            }
        }
    }

    //Create Pedestiran
    private void AddPedestrian(Transform spawn)
    {
        int randomNumber = Random.Range(1, numberOfPedPrefabs + 1);

        NavMeshAgent agent = Instantiate(Resources.Load<NavMeshAgent>($"Prefabs/Passenger_0{randomNumber}"));
        agent.transform.position = spawn.transform.position;
        agent.destination = spawn.transform.position;

        RandomWalk walk = agent.gameObject.AddComponent<RandomWalk>();
        walk.m_minDistance = 1;
        walk.randomLocation = false;

        Pedestrian ped = agent.gameObject.AddComponent<Pedestrian>();
        ped.agent = agent;
        ped.randomWalk = walk;
        ped.animator = agent.gameObject.GetComponentInChildren<Animator>();
        if (randomNumber != 1)
        {
            ped.male = true;
        }

        agents.Add(agent);
    }

    private void ActivatePedestrians()
    {
        if (activePeds.Count == 0)
        {
            for (int i = 0; i < agents.Count; i++)
            {
                if (Vector3.Distance(agents[i].transform.position, TaxiFeeMachine.instance.transform.position) > pickUpRadius && Vector3.Distance(agents[i].transform.position, TaxiFeeMachine.instance.transform.position) < pickUpRadius*2)
                {
                    Pedestrian ped = agents[i].gameObject.GetComponent<Pedestrian>();
                    activePeds.Add(ped);

                    // activate ped
                    ped.active = true;

                    // stop and animate ped
                    if (ped.agent.enabled)
                    {
                        agents[i].isStopped = true;
                    }
                    
                    if (ped.male)
                    {
                        ped.animator.Play("m_idle_A");
                    }
                    else 
                    {
                        ped.animator.Play("f_idle_A");
                    }
                    GameObject marker = Instantiate(Resources.Load<GameObject>($"Prefabs/LocationMarker"));
                    marker.transform.parent = agents[i].transform;
                    marker.transform.localPosition = Vector3.zero;
                    agents.Remove(agents[i]);
                    // add random destination
                    break;
                }
            }
        }
    }

    public List<Pedestrian> GetActivePeds()
    {
        return activePeds;
    }
}
