using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject SpawnPoint1;
    public GameObject SpawnPoint2;
    public GameObject Enemy; 
    private void Update()
    {
        StartCoroutine(WaitToSpawn(5f));
    }

    IEnumerator WaitToSpawn(float time)
    {
        yield return new WaitForSeconds(time);
        Instantiate(Enemy, SpawnPoint1.transform.position, transform.rotation);
        Instantiate(Enemy, SpawnPoint2.transform.position, transform.rotation);
         
    } 
        
}
