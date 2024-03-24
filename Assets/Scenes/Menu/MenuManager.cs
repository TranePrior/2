using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Canvas mainMenuCanvas;  // ������ ������ Canvas ����
    public Canvas[] Canvas;  // ������ ������ Canvas

    void Start()
    {
        // �������� Canvas ���� � ��������� ������ Canvas ��� ������� ����
        mainMenuCanvas.gameObject.SetActive(true);
        foreach (Canvas canvas in Canvas)
        {
            canvas.gameObject.SetActive(false);
        }
    }

    public void CloseMainMenu()
    {
        // ��������� Canvas ���� � �������� ������ Canvas ��� �������� ����
        mainMenuCanvas.gameObject.SetActive(false);
        foreach (Canvas canvas in Canvas)
        {
            canvas.gameObject.SetActive(true);
        }
    }
}
