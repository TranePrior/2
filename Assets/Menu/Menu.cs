using UnityEngine;
using UnityEngine.SceneManagement;  // ��� ������ �� �������
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Button Play ;  // ������ ����� ������ "Play"
    public string gameSceneName;  // ��� ����� ������� �����

    void Start()
    {
        // ��������� ��������� � ������ "Play"
        Play.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        // ��������� ������� �����
        SceneManager.LoadScene(gameSceneName);
    }
}
