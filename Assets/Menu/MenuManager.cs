using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Canvas mainMenuCanvas;  // Объект вашего Canvas меню
    public Canvas[] Canvas;  // Массив других Canvas

    void Start()
    {
        // Включаем Canvas меню и выключаем другие Canvas при запуске игры
        mainMenuCanvas.gameObject.SetActive(true);
        foreach (Canvas canvas in Canvas)
        {
            canvas.gameObject.SetActive(false);
        }
    }

    public void CloseMainMenu()
    {
        // Выключаем Canvas меню и включаем другие Canvas при закрытии меню
        mainMenuCanvas.gameObject.SetActive(false);
        foreach (Canvas canvas in Canvas)
        {
            canvas.gameObject.SetActive(true);
        }
    }
}
