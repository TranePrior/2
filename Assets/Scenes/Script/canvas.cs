using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject canvas; // ��� ������ Canvas

    void Start()
    {
        // �������� Canvas � ������ ����
        canvas.SetActive(true);
    }

    public void StartGame()
    {
        // ���������� Canvas ��� ������� ����
        canvas.SetActive(true);
    }
}
