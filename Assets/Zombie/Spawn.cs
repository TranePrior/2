using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Префаб врага
    public float respawnTime = 5f; // Время до респавна

    private void Start()
    {
        // Начинаем спавнить врагов
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            // Если врага нет
            if (transform.childCount == 0)
            {
                // Создаем нового врага
                GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                enemy.transform.parent = transform;
            }

            // Ждем перед следующей проверкой
            yield return new WaitForSeconds(respawnTime);
        }
    }
}
