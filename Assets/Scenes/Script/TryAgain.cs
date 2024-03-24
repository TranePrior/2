using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartGame()
    {
        // Перезагрузите текущую сцену
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
