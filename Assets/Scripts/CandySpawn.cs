using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawn : MonoBehaviour
{
    [SerializeField]
    GameObject[] candyObj;

    [SerializeField]
    float xMax;

    [SerializeField]
    float interval;

    Vector3 spawnPos;

    public static CandySpawn instance;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        //InvokeRepeating("spawnCandy", 4f, 2.5f);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnCandy()
    {
        int randCandy = Random.Range(0, candyObj.Length);

        spawnPos = new Vector3(Random.Range(-xMax, xMax), transform.position.y, transform.position.z);

        Instantiate(candyObj[randCandy], spawnPos, Quaternion.identity);
    }

    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            spawnCandy();

            yield return new WaitForSeconds(interval);
        }
        
    }

    public void StartSpawner ()
    {
        StartCoroutine("Spawner");
    }

    public void StopSpawner()
    {
        StopCoroutine("Spawner");   
    }


}
