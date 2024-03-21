using UnityEngine;
using TMPro;

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
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        DisplayHealth();
    }

    void DisplayHealth()
    {
        float healthPercentage = (float)currentHealth / maxHealth * 100; // Вычисляем процент здоровья
        healthText.text = healthPercentage.ToString("0"); // Отображаем процент здоровья
    }
}
