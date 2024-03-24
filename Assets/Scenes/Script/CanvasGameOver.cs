using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public Player player; // Ссылка на скрипт игрока
    public Canvas gameOverCanvas; // Ссылка на Canvas
    public Image deathImage; // Ссылка на изображение
    public Button restartButton; // Ссылка на кнопку
    public GameObject fon; // Ссылка на объект "Fon"

    void Start()
    {
        // Отключите Canvas при старте
        gameOverCanvas.gameObject.SetActive(false);
        Time.timeScale = 1; // Здесь 1 - это нормальное течение времени                   
        Cursor.visible = true;// Показать курсор после перезапуска игры
    }

    void Update()
    {
        // Проверьте, умер ли игрок
        if (player.currentHealth <= 0)
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        // Включите Canvas, изображение и кнопку при смерти игрока
        gameOverCanvas.gameObject.SetActive(true);
        deathImage.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

        // Скрываем Fon
        fon.SetActive(false);
    }

    public void RestartGame()
    {
        // Перезагрузите сцену "SampleScene" при нажатии кнопки
        StartCoroutine(ReloadScene());
    }

    IEnumerator ReloadScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SampleScene");

        // Ждем, пока сцена полностью не загрузится
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Установите Time.timeScale на 1
        Time.timeScale = 1;

        // Разблокируйте курсор
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // Отключите Canvas при старте
        gameOverCanvas.gameObject.SetActive(false);
        deathImage.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);

        // Показываем Fon
        fon.SetActive(true);
    }
}
