using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;

    private Vector3 delta;
    private Vector3 x;

    // Start is called before the first frame update
    void Start()
    {
        delta = transform.position - target.position;
        x = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + delta;
        transform.position = new Vector3(x.x, transform.position.y, transform.position.z);
    }
}
