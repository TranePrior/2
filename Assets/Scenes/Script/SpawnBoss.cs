using System.Collections;
using UnityEngine;

public class RespawnBoss : MonoBehaviour
{
    public GameObject EnemyPrefabBOSS;
    private float respawnTime = 180.0f;

    void Start()
    {
        Invoke("Respawn", respawnTime);
    }

    void Respawn()
    {
        Vector3 spawnPoint = new Vector3(-10.97f, 0f, 87.09f);

        Instantiate(EnemyPrefabBOSS, spawnPoint, Quaternion.identity);
    }
}
