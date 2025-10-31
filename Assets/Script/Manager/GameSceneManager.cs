using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject Chest;

    public GameObject Steak;
    public GameObject Chicken;

    [SerializeField]
    private GameObject playerSpawnPoint;

    [SerializeField]
    private GameObject gameOverUI;

    [SerializeField]
    private GameObject pauseUI;
   
    [SerializeField]
    private GameObject soundSettingUI;

    [SerializeField]
    private GameObject storySlideShow;

    [SerializeField]
    private GameObject cc_PopUpUI;

    private List<GameObject> list = new List<GameObject>();
    private void Start()
    {
        if (GameManager.Instance.Is_StorySlide)
        {
            storySlideShow.SetActive(true);
            GameManager.Instance.Is_StorySlide = false;
        }
        gameOverUI.SetActive(false);
    }
    public void GameOver()
    {
        StartCoroutine(SpawnFoodRepeatedly());
        GameManager.Instance.Is_StorySlide = true;
    }
    private IEnumerator SpawnFoodRepeatedly()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnFood();
            yield return new WaitForSeconds(0.3f);
        }
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
    private void SpawnFood()
    {
        GameObject obj_1 = GameObject.Instantiate(Steak);
        GameObject obj_2 = GameObject.Instantiate(Chicken);
        list.Add(obj_1);
        list.Add(obj_2);
    }

    public void OnClickRestartBtn()
    {
        Time.timeScale = 1f;
        Player.transform.position = playerSpawnPoint.transform.position;
        Chest.GetComponent<NearChest>().ChestReset();
        foreach(GameObject obj in list)
        {
            if(obj != null)
            {
                Destroy(obj);
            }
        }
        list.Clear();
        gameOverUI.SetActive(false);
        pauseUI.SetActive(false);

    }

    public void OnClickMainMenuBtn()
    {
        gameOverUI.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("StartScene");
    }

    public void OnClickPauseBtn()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void OnClickResumeBtn()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(false);
    }
    public void OnClickSoundSettingBtn()
    {
        soundSettingUI.SetActive(true);
        pauseUI.SetActive(false);
    }
    public void OnClickSoundSettingCloseBtn()
    {
        soundSettingUI.SetActive(false);
        pauseUI.SetActive(true);
    }

    public void OnClickCC_PopUPBtn()
    {
        pauseUI.SetActive(false);
        cc_PopUpUI.SetActive(true);
    }
    public void OnClickCC_PopUPCloseBtn()
    {
        pauseUI.SetActive(true);
        cc_PopUpUI.SetActive(false);
    }

}
