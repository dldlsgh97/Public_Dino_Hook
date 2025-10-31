using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foodspawn : MonoBehaviour
{
    // Start is called before the first frame update

    NearChest chest;
    public CanvasGroup finishGroup;
    void Start()
    {
        chest = GameObject.Find("chest").GetComponent<NearChest>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (chest.status == 1)
        {
            GameObject steak = GameObject.Instantiate(this.prefab1) as GameObject;
            GameObject gameObject = GameObject.Instantiate(this.prefab2) as GameObject;
            chest.status = 0;
            CanvasGroupOn(finishGroup);
        }*/
    }
/*    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }*/
}
