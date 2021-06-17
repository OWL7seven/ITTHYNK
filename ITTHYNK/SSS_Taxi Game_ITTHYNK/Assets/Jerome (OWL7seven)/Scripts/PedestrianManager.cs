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

    //Number of predestrian prefabs found in the resources
    //Hard coded for now
    //Will create a search fucntion that will check for current amount
    [SerializeField]
    private int numberOfPedPrefabs = 3;

    //Random spawning of pedestrians
    [SerializeField]
    private bool randomSpawn;

    //Pedestrian spawn radius
    [SerializeField]
    private float spawnRadius = 25f;

    //list of active pedestrians
    [SerializeField]
    private List<NavMeshAgent> agents = new List<NavMeshAgent>();

    //list of pedestrians spawn points
    [SerializeField]
    private List<Transform> spawnPoints = new List<Transform>();

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
                NavMeshAgent agent = Instantiate(Resources.Load<NavMeshAgent>($"Prefabs/Passenger_0{Random.Range(1, numberOfPedPrefabs + 1)}"));
                agent.transform.position = spawn.transform.position;
                agent.destination = spawn.transform.position;                
                RandomWalk walk = agent.gameObject.AddComponent<RandomWalk>();
                walk.m_minDistance = 1;
                walk.randomLocation = false;
                agents.Add(agent);
            }
        }
    }
}
