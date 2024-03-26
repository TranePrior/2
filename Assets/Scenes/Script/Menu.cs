using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public Button Play ;
    public string gameSceneName;

    void Start()
    {
        Play.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
