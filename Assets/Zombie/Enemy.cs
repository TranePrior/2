using UnityEngine;
using UnityEngine.AI;
using System;

public class Enemy : MonoBehaviour
{
    public static Action OnEnemyDestroyed = delegate { };  // Событие, которое вызывается при уничтожении врага

    public float currentHealth = 10f;
    public Animator animator;
    public float stopDistance = 1f;
    public float attackDistance = 1;
    public Transform playerTarget;
    private NavMeshAgent agent;
    private bool isAttacking = false;
    private bool isDead = false;
    public int damage = 1; // Урон, который наносит враг
    public Player player; // ссылка на скрипт игрока

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        // Найдите игрока на сцене и сохраните ссылку на его скрипт
        player = GameObject.FindObjectOfType<Player>();
    }

    void Update()
    {
        if (isDead) return;  // Если враг мертв, не выполняем обновление

        // Обновляем ссылку на игрока каждый кадр
        playerTarget = GameObject.FindGameObjectWithTag("Player").transform;

        if (Vector3.Distance(playerTarget.position, transform.position) <= attackDistance)
        {
            isAttacking = true;
            animator.SetBool("isAttacking", true);
            AttackPlayer(); // Враг атакует игрока, когда он достаточно близко
        }
        else if (Vector3.Distance(playerTarget.position, transform.position) > stopDistance)
        {
            isAttacking = false;
            animator.SetBool("isAttacking", false);
            agent.SetDestination(playerTarget.position);
        }
        else
        {
            agent.isStopped = true;
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0 && !isDead)
        {
            Die();
        }
    }

    public void Die()
    {
        isDead = true;
        animator.SetTrigger("Death");
        agent.isStopped = true;  // Останавливаем агента, но не отключаем его
        Invoke("DestroyEnemy", 1f);
    }

    void DestroyEnemy()
    {
        OnEnemyDestroyed.Invoke();  // Вызываем событие при уничтожении врага
        Destroy(gameObject);
    }

    void AttackPlayer()
    {
        // Вызовите метод TakeDamage() из скрипта игрока
        player.TakeDamage(damage);
    }
}
