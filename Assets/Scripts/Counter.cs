using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Counter : MonoBehaviour
{
    public Text CounterText;
    [SerializeField] Text pointsText;
    private int count = 0;
    private int points = 0;
    private float spawnRange = 6;
    [SerializeField] int maxBallsToSpawn = 40;
    [SerializeField] GameObject ballPrefab;
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private void Update()
    {


        points += (count);
        pointsText.text = "Points : " + points/30;
    }

    private void OnTriggerEnter(Collider other)
    {
        count -= 1;
        CounterText.text = "Count : " + count;
    }
    
    IEnumerator Spawn()
    {

        while (maxBallsToSpawn > 0)
        {
            yield return new WaitForSeconds(1);
            Instantiate(ballPrefab, GenerateSpawnPosition(), transform.rotation);
            maxBallsToSpawn--;
            count++;
            CounterText.text = "Count : " + count;
        }
     
       
    }

    private Vector3 GenerateSpawnPosition()
    {
        
        float spawnPosZ = Random.Range(-spawnRange, spawnRange); ;
        Vector3 spawnPos = new Vector3(0, 21, spawnPosZ);

        return spawnPos;
    }




}
