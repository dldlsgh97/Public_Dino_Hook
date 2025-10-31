using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearChest : MonoBehaviour
{    
    public bool near;

    [SerializeField]
    private GameSceneManager gameSceneManager;

    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        near = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            near = true;
            anim.SetBool("Near", true);
        }
    }
    private void Update()
    {
        if (near)
        {
            gameSceneManager.GameOver();
            near = false;
        }
    }

    public void ChestReset()
    {
        anim.SetBool("Near", false);
        near = false;
    }
}
