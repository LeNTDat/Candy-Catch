using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScripts : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //detectOutRange();
    }

    private void FixedUpdate()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            GameManager.Instance.getScore();
            Destroy(gameObject);

        }else if(collider.gameObject.tag == "Boundary")
        {
            GameManager.Instance.liveCounter();
            Destroy(gameObject);
        }
        
    }
    // one of ways to delete candies during play time
    //void detectOutRange()
    //{
    //    if (transform.position.y < -6.0f)
    //    {
    //        Destroy(gameObject);

    //    }
    //}
}


