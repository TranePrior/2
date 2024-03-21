using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // ������ �����
    public float respawnTime = 5f; // ����� �� ��������

    private void Start()
    {
        // �������� �������� ������
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            // ���� ����� ���
            if (transform.childCount == 0)
            {
                // ������� ������ �����
                GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                enemy.transform.parent = transform;
            }

            // ���� ����� ��������� ���������
            yield return new WaitForSeconds(respawnTime);
        }
    }
}
