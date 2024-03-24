using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public Player player; // ������ �� ������ ������
    public Canvas gameOverCanvas; // ������ �� Canvas
    public Image deathImage; // ������ �� �����������
    public Button restartButton; // ������ �� ������
    public GameObject fon; // ������ �� ������ "Fon"

    void Start()
    {
        // ��������� Canvas ��� ������
        gameOverCanvas.gameObject.SetActive(false);
        Time.timeScale = 1; // ����� 1 - ��� ���������� ������� �������                   
        Cursor.visible = true;// �������� ������ ����� ����������� ����
    }

    void Update()
    {
        // ���������, ���� �� �����
        if (player.currentHealth <= 0)
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        // �������� Canvas, ����������� � ������ ��� ������ ������
        gameOverCanvas.gameObject.SetActive(true);
        deathImage.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

        // �������� Fon
        fon.SetActive(false);
    }

    public void RestartGame()
    {
        // ������������� ����� "SampleScene" ��� ������� ������
        StartCoroutine(ReloadScene());
    }

    IEnumerator ReloadScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SampleScene");

        // ����, ���� ����� ��������� �� ����������
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // ���������� Time.timeScale �� 1
        Time.timeScale = 1;

        // ������������� ������
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        // ��������� Canvas ��� ������
        gameOverCanvas.gameObject.SetActive(false);
        deathImage.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);

        // ���������� Fon
        fon.SetActive(true);
    }
}
