using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grapplinghook : MonoBehaviour
{
    public LineRenderer line;
    public Transform hook;
    Vector2 mousedir;

    private bool ishookactive;
    private bool isLineMax;
    public bool IsAttach;

    private InputController inputContoller;
    private hooking hooking;
    void Start()
    {
        inputContoller = GetComponent<InputController>();
        hooking = hook.gameObject.GetComponent<hooking>();

        inputContoller.OnLookEvent += Look;
        inputContoller.OnHookEvent += Hook;

        line.positionCount = 2;
        line.endWidth = line.startWidth= 0.05f;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, hook.position);
        line.useWorldSpace = true;
        IsAttach = false;
    }

    void Update()
    {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, hook.position);

        #region ·¹°Å½Ã ÀÎÇ²
        /*line.SetPosition(0, transform.position);
        line.SetPosition(1, hook.position);
        
        if (Input.GetKeyDown(KeyCode.E) && !ishookactive)
        {
            hook.position = transform.position;
            mousedir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            ishookactive = true;
            isLineMax = false;
            hook.gameObject.SetActive(true);
        }

        if (ishookactive && !isLineMax && !isAttatch)
        {
            hook.Translate(mousedir.normalized * Time.deltaTime * 15);

            if (Vector2.Distance(transform.position, hook.position) > 5)
            {
                isLineMax = true;
            }
        }
        else if (ishookactive && isLineMax && !isAttatch)
        {
            hook.position = Vector2.MoveTowards(hook.position, transform.position, Time.deltaTime * 15);
            if (Vector2.Distance(transform.position, hook.position) < 0.1f)
            {
                ishookactive = false;
                isLineMax = false;
                hook.gameObject.SetActive(false);
            }
        }
        else if(isAttatch)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isAttatch = false;
                ishookactive = false;
                isLineMax = false;
                hook.GetComponent<hooking>().Joint2D.enabled = false;
                hook.gameObject.SetActive(false);
            }            
        }*/
        #endregion
        if (ishookactive && !isLineMax && !IsAttach)
        {
            hook.Translate(mousedir.normalized * Time.deltaTime * 15);

            if (Vector2.Distance(transform.position, hook.position) > 5)
            {
                isLineMax = true;
            }
        }
        else if (ishookactive && isLineMax && !IsAttach)
        {
            hook.position = Vector2.MoveTowards(hook.position, transform.position, Time.deltaTime * 15);
            if (Vector2.Distance(transform.position, hook.position) < 0.1f)
            {
                ishookactive = false;
                isLineMax = false;
                hook.gameObject.SetActive(false);
            }
        }
    }

    private void Hook()
    {
        if (!ishookactive)
        {
            hook.position = transform.position;            
            ishookactive = true;
            isLineMax = false;
            hook.gameObject.SetActive(true);
        }
        else if(ishookactive && IsAttach)
        {
            IsAttach = false;
            ishookactive = false;
            isLineMax = false;
            hooking.Joint2D.enabled = false;
            hook.gameObject.SetActive(false);
        }

    }
    private void Look(Vector2 direction)
    {
        mousedir = direction;
    }
}
