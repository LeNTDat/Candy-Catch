using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    int moveSpeed;

    [SerializeField]
    float maxPos;

    float inputX;

    public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       if(canMove)
        {
            Move();
        }
    }

    private void Move()
    {
        inputX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.position += Vector3.right * inputX;

        float xPos = Mathf.Clamp(transform.position.x , -maxPos, maxPos);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);

    }


}
