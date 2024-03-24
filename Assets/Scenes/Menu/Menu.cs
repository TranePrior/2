using UnityEngine;
using UnityEngine.SceneManagement;  // Для работы со сценами
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Button Play ;  // Объект вашей кнопки "Play"
    public string gameSceneName;  // Имя вашей игровой сцены

    void Start()
    {
        // Добавляем слушатель к кнопке "Play"
        Play.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        // Загружаем игровую сцену
        SceneManager.LoadScene(gameSceneName);
    }
}
