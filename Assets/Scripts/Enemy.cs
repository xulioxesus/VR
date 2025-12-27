using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed;
    [SerializeField] float attackRange;
    [SerializeField] float rotationSpeed = 5f;

    
    Vector3 direction;
    Rigidbody rb;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Obtener el objeto que representa al jugador
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        if (player == null)
        {
            player = Camera.main.transform;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Obtener la dirección del jugador
        direction = player.transform.position - transform.position;

        // Mantener el enemigo en el suelo
        direction.y = 0f;

        float distance = direction.magnitude;

        // Rotate smoothly on Y-axis only
        if (direction != Vector3.zero)
        {
            // Create rotation only on Y
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            Vector3 euler = targetRotation.eulerAngles;
            targetRotation = Quaternion.Euler(0f, euler.y, 0f); // lock X and Z
            rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime));
        }

        // Mover el enemigo hacia el jugador
        if (distance > attackRange)
        {
            Vector3 newPosition = rb.position + direction.normalized * speed * Time.deltaTime;
            rb.MovePosition(newPosition);
            animator.SetBool("isAttacking", false);
            animator.SetBool("isWalking", true);
        } else
        {
            animator.SetBool("isAttacking", true);
            animator.SetBool("isWalking", false);
        }
    }
}
