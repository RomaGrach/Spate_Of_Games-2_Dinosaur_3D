using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouve : MonoBehaviour
{
    public Transform target;
    public float Zsmeshenie = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y, target.position.z + Zsmeshenie);
        }

    }
}
