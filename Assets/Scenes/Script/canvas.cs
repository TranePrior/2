using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject canvas; // Ваш объект Canvas

    void Start()
    {
        // Скрываем Canvas в начале игры
        canvas.SetActive(true);
    }

    public void StartGame()
    {
        // Показываем Canvas при запуске игры
        canvas.SetActive(true);
    }
}
