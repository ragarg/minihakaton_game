using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScale : MonoBehaviour
{
    [ContextMenu("PlanePosition")]
        private void PlanePosition()
        {
            transform.position = new Vector3(2.0f, 0.0f, (transform.localScale.z / 2) * 10);
        }
}
