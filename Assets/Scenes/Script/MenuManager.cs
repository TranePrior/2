using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Canvas mainMenuCanvas;
    public Canvas[] Canvas;

    void Start()
    {
        mainMenuCanvas.gameObject.SetActive(true);
        foreach (Canvas canvas in Canvas)
        {
            canvas.gameObject.SetActive(false);
        }
    }

    public void CloseMainMenu()
    {
        mainMenuCanvas.gameObject.SetActive(false);
        foreach (Canvas canvas in Canvas)
        {
            canvas.gameObject.SetActive(true);
        }
    }
}
