using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 10f; // ����, ������� ������� ����

    void OnCollisionEnter(Collision collision)
    {
        var hitObject = collision.gameObject;
        var enemy = hitObject.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Debug.Log("Collision detected");
        }

        Destroy(gameObject); // ���������� ���� ����� ������������
    }
}
