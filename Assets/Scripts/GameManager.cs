using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewEmptyCSharpScript : MonoBehaviour
{

    public GameObject block;
    public float maxX;
    public Transform spawnPoint;

    public float spawnRate;
bool gameStarted = false;


void Update()
{
   if(Input.GetMouseButtonDown(0) && !gameStarted)
   {
       StartSpawning();
       gameStarted = true;
   }
}


void StartSpawning(){
    InvokeRepeating("SpawnBlock", 0.5f, spawnRate);
}


private void SpawnBlock()
{
    Vector3 spawnPos = spawnPoint.position;
    spawnPos.x = Random.Range(-maxX, maxX);

    Instantiate(block, spawnPos, Quaternion.identity);

}
}
