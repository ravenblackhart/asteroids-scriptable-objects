using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    [Tooltip("Drag & Drop Pickups Prefabs into list")]public GameObject[] Pickups; 
    [SerializeField] private float SpawnRate = 5f;
    [SerializeField] private float SpawnStart = 2f;

    private Vector2 spawnPos; 
    void Start()
    {
        InvokeRepeating("SpawnPickup", SpawnStart, SpawnRate);
    }

    // Update is called once per frame
    void SpawnPickup()
    {
        int xPos = Random.Range(-6, 6);
        int yPos = Random.Range(-4, 4);

        spawnPos = new Vector2(xPos, yPos);

        Instantiate(Pickups[Random.Range(0, Pickups.Length)], spawnPos, Quaternion.identity); 
            
        gameObject.transform.position = spawnPos;
        gameObject.tag = "PickUp"; 
    }
}
