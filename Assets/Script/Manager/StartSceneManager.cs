using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneManager : MonoBehaviour
{
    [SerializeField]
    private GameObject ctrlUI;
    [SerializeField]
    private GameObject soundSettingUI;
    [SerializeField]
    private GameObject characterUI;

    [SerializeField]
    Image[] playerCharacterBtn;

    private Color pickColor = new Color(255, 255, 0);
    private Color notPickColor = new Color(255, 255, 255);

    public void OnClickGameStartBtn()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void OnClickQuitBtn()
    {
        Application.Quit();
    }
    public void OnClickCtrlBtn()
    {
        ctrlUI.SetActive(true);
    }
    public void OnClickBackBtn()
    {
        ctrlUI.SetActive(false);
    }

    public void OnClickSoundSettingBtn()
    {
        soundSettingUI.SetActive(true);
    }
    public void OnClickSoundSettingCloseBtn()
    {
        soundSettingUI.SetActive(false);
    }
    public void OnClickCharacterBtn()
    {
        int num = GameManager.Instance.PlayerSprite;
        characterUI.SetActive(true);

        ChangePlayerCharBtn(num);
    }
    public void OnClickCharacterCloseBtn()
    {
        characterUI.SetActive(false);
    }
    public void OnClickPlayerBlue()
    {
        GameManager.Instance.PlayerSprite = 0;
        ChangePlayerCharBtn(0);
    }
    public void OnClickPlayerRed()
    {
        GameManager.Instance.PlayerSprite = 2;
        ChangePlayerCharBtn(2);
    }
    public void OnClickPlayerGreen()
    {
        GameManager.Instance.PlayerSprite = 1;
        ChangePlayerCharBtn(1);
    }
    public void OnClickPlayerYellow()
    {
        GameManager.Instance.PlayerSprite = 3;
        ChangePlayerCharBtn(3);
    }

    void ChangePlayerCharBtn(int n)
    {
        for(int i = 0; i < 4; i++)
        {
            if(i == n)
            {
                playerCharacterBtn[i].color = pickColor;
            }
            else
            {
                playerCharacterBtn[i].color = notPickColor;
            }
        }
    }
}
