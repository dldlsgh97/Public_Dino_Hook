using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneBackGround : MonoBehaviour
{
    [SerializeField] 
    float ScrollSpeed = 1f;
    [SerializeField]
    GameObject[] Backgrounds;
    
    float backgroundWidth = 17.25f;


    void Update()
    {
        foreach (GameObject bg in Backgrounds)
        {
            bg.transform.Translate(Vector2.left * ScrollSpeed * Time.deltaTime);
            
            if (bg.transform.position.x <= -backgroundWidth)
            {
                Vector3 newPos = new Vector3(bg.transform.position.x + backgroundWidth * Backgrounds.Length, bg.transform.position.y, bg.transform.position.z);
                bg.transform.position = newPos;
            }
        }
    }


}
