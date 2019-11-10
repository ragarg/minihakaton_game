using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1;
    private string right = "right";
    private string left = "left";

    void Update()
    {
        transform.GetComponent<Animator>().SetBool(right, false);
        transform.GetComponent<Animator>().SetBool(left, false);
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -2)
            {
                transform.position += Vector3.left * 0.05f;
                transform.GetComponent<Animator>().SetBool(left, true);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 2)
            {
                transform.position += Vector3.right * 0.05f;
                transform.GetComponent<Animator>().SetBool(right, true);
            }
        }
        transform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
