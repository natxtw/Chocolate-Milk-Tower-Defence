using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AlienNavMeshAgent : MonoBehaviour
{
    [SerializeField] Transform Spawn;
    [SerializeField] Transform Destination;

    NavMeshAgent AgentAlien;
    public GameObject AlienPrefab;

    public bool iHaveSpawned = true;
    protected int AlienSpawnID = 0;

    void Start()
    {
        AgentAlien = this.GetComponent<NavMeshAgent>(); //find the navmesh component

        if(AgentAlien == null)
        {
            Debug.LogError("NavMesh component is not attatched - " + gameObject.name);
        }
        else
        {
            MoveToTheDestination();
        }
    }

    void Update()
    {
        //SpawnAlien();
        //Debug.Log("I should work");
    }

    private void MoveToTheDestination()
    {
        if (Destination != null)
        {
            Vector3 targetVector = Destination.transform.position;
            AgentAlien.SetDestination(targetVector);
        }
    }
/*
    void SpawnAlien()
    {
        if(iHaveSpawned == true)
        {
            AlienCreation(Spawn);
            iHaveSpawned = false;
            Debug.Log("iHaveSpawned should be set to false and an Alien should have spawned, " + iHaveSpawned);
        }
    }

    void AlienCreation(Transform AlienTransform) //Spawns them weirdly, needs fixing
    {
            GameObject AlienClone = Instantiate(AlienPrefab, AlienTransform.position, AlienTransform.rotation);
            AlienSpawnID++;
            AlienClone.name = "Alien " + AlienSpawnID;
    }
    */
}
