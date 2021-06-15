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

    private void Start()
    {
        for (int i = 0; i < numberOfPeds; i++)
        {            
            NavMeshAgent agent = Instantiate(Resources.Load<NavMeshAgent>($"Prefabs/Passenger_0{Random.Range(1,numberOfPedPrefabs + 1)}"));
            RandomWalk walk = agent.gameObject.AddComponent<RandomWalk>();
            walk.m_Range = Random.Range(0, spawnRadius);
            walk.m_minDistance = 10;
            walk.randomLocation = randomSpawn;
            agents.Add(agent);
        }
    }
}
