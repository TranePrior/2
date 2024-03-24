using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public TextMeshProUGUI healthText;

    void Start()
    {
        currentHealth = maxHealth;
        DisplayHealth();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }

        if (currentHealth <= 0)
        {
            // Останавливаем все процессы
            Time.timeScale = 0;
            // Разблокируйте курсор
            corsorUnloced();
        }
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth <= 0) // Если здоровье игрока равно или меньше 0, не наносите урон
        {
            return;
        }
        currentHealth -= damage;
        DisplayHealth();
    }

    void DisplayHealth()
    {
        float healthPercentage = (float)currentHealth / maxHealth * 100; // Вычисляем процент здоровья
        healthText.text = healthPercentage.ToString("0"); // Отображаем процент здоровья
    }
  
    // Предполагается, что этот метод разблокирует курсор
    void corsorUnloced()
    {
        // Ваш код для разблокировки курсора
    }
}
