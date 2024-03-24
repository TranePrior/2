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
            // ������������� ��� ��������
            Time.timeScale = 0;
            // ������������� ������
            corsorUnloced();
        }
    }

    public void TakeDamage(int damage)
    {
        if (currentHealth <= 0) // ���� �������� ������ ����� ��� ������ 0, �� �������� ����
        {
            return;
        }
        currentHealth -= damage;
        DisplayHealth();
    }

    void DisplayHealth()
    {
        float healthPercentage = (float)currentHealth / maxHealth * 100; // ��������� ������� ��������
        healthText.text = healthPercentage.ToString("0"); // ���������� ������� ��������
    }
  
    // ��������������, ��� ���� ����� ������������ ������
    void corsorUnloced()
    {
        // ��� ��� ��� ������������� �������
    }
}
