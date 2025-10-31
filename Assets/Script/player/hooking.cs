using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hooking : MonoBehaviour
{    
    public DistanceJoint2D Joint2D;
    [SerializeField]
    private grapplinghook grab;
    void Start()
    {
        Joint2D = GetComponent<DistanceJoint2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ring"))
        {
            Joint2D.enabled = true;
            grab.IsAttach = true;
        }
    }
}
