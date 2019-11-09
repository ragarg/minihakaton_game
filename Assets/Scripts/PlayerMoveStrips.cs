using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveStrip : MonoBehaviour
{
    public float speed;
    private int strip;

    // Start is called before the first frame update
    void Start()
    {
        strip = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (strip > -1)
            {
                for (int i = 0; i < 10; i++)
                {
                    transform.position = Vector3.left * 0.1f;
                }
                strip--;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (strip < 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    transform.position = Vector3.right * 0.1f;
                }
                strip++;
            }
        }
        transform.position += Vector3.forward * speed;
    }
}
