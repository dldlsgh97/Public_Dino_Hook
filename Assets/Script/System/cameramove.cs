using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    public Transform target;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(target.position, target.position,Time.deltaTime*speed);
        transform.position = new Vector3(transform.position.x, transform.position.y+3, -10f);
    }
}
