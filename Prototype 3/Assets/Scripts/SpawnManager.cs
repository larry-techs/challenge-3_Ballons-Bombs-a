using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    private float delayTime = 2;
    private float intervalToSpawn = 2;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ObstaclePre",delayTime,intervalToSpawn);
        playerControllerScript = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ObstaclePre()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(ObstaclePrefab, spawnPosition, ObstaclePrefab.transform.rotation);
        }
    }
}
