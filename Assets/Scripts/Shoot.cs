
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject bullet; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnPoint.transform.position = Test.spawnPoint.transform.position;
        if(Input.GetMouseButton(0))
        {
            Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation);
        }
    }
}
