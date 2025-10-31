using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnType : MonoBehaviour
{
    public BTNType currentType;
    public CanvasGroup mainmenu;
    public CanvasGroup ctrlmenu;

   
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.Start:
                SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
                break;
            case BTNType.Exit:
                Application.Quit();
                break;
            case BTNType.Ctrl:
                CanvasGroupOn(ctrlmenu);
                CanvasGroupOff(mainmenu);
                break;
            case BTNType.Back:
                CanvasGroupOn(mainmenu);
                CanvasGroupOff(ctrlmenu);
                break;

        }

    }
    public void CanvasGroupOn(CanvasGroup cg)
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
    }
}

   