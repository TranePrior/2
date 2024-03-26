using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public Player player; 
    public Canvas gameOverCanvas; 
    public Image deathImage; 
    public Button restartButton; 
    public GameObject fon; 

    void Start()
    { 
        gameOverCanvas.gameObject.SetActive(false);
        Time.timeScale = 1; 
        Cursor.visible = true;
    }

    void Update()
    {  
        if (player.currentHealth <= 0)
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        
        gameOverCanvas.gameObject.SetActive(true);
        deathImage.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

        fon.SetActive(false);
    }

    public void RestartGame()
    {     
        StartCoroutine(ReloadScene());
    }

    IEnumerator ReloadScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SampleScene");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        Time.timeScale = 1;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        gameOverCanvas.gameObject.SetActive(false);
        deathImage.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);

        fon.SetActive(true);
    }
}
