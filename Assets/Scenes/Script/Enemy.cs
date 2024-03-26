using UnityEngine;
using UnityEngine.AI;
using System;

public class Enemy : MonoBehaviour
{
    public static Action OnEnemyDestroyed = delegate { };

    public float currentHealth = 10f;
    public Animator animator;
    public float stopDistance = 1f;
    public float attackDistance = 1;
    public Transform playerTarget;
    private NavMeshAgent agent;
    private bool isAttacking = false;
    private bool isDead = false;
    public int damage = 1;
    public Player player;
    internal int health;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        player = GameObject.FindObjectOfType<Player>();
    }

    void Update()
    {
        if (isDead) return;

        playerTarget = GameObject.FindGameObjectWithTag("Player").transform;

        if (Vector3.Distance(playerTarget.position, transform.position) <= attackDistance)
        {
            isAttacking = true;
            animator.SetBool("isAttacking", true);
            AttackPlayer(); 
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
        agent.isStopped = true;  
        Invoke("DestroyEnemy", 1f);
    }

    void DestroyEnemy()
    {
        OnEnemyDestroyed.Invoke(); 
        Destroy(gameObject);
    }

    void AttackPlayer()
    {
        player.TakeDamage(damage);
    }
}
