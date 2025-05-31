using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private StateMachine stateMachine;
    private NavMeshAgent agent;
    private GameObject player;

    public NavMeshAgent Agent { get => agent; }
    public GameObject Player { get => player; }

    public Path path;
    [Header("Sight Values")]
    public float sightDistance = 500;
    public float fieldOfView = 200f;
    public float eyeHeight = 0.7f;
    [Header("Weapon Values")]
    public Transform gunBarrel;
    [Range(0.1f, 10f)]
    public float fireRate;

    [SerializeField]
    private string currentState;

    private Animator animator;
    private bool isWalking = false;
    public bool isDying = false;

    void Start()
    {
        stateMachine = GetComponent<StateMachine>();
        agent = GetComponent<NavMeshAgent>();
        stateMachine.Initialize();
        player = GameObject.FindGameObjectWithTag("Player");

        animator = GetComponent<Animator>();
        /*
        if (animator == null)
        {
            Debug.LogError("Animator component is missing on the enemy GameObject.");
        }*/
    }

    void Update()
    {
        CanSeePlayer();
        currentState = stateMachine.activeState.ToString();

        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        bool isMoving = agent.velocity.magnitude > 0.1f && agent.remainingDistance > agent.stoppingDistance;

        if (isMoving)
        {
            if (!isWalking)
            {
                isWalking = true;
                if (animator)
                    animator.SetBool("isWalking", true);
            }
        }
        else
        {
            if (isWalking)
            {
                isWalking = false;
                if (animator)
                    animator.SetBool("isWalking", false);
            }
        }
    }

    public bool CanSeePlayer()
    {
        if (player != null)
        {
            if (!player.GetComponent<PlayerMotor>().crouching)
            {
                if (Vector3.Distance(transform.position, player.transform.position) < sightDistance)
                {
                    Vector3 targetDirection = player.transform.position - transform.position - (Vector3.up * eyeHeight);
                    float angleToPlayer = Vector3.Angle(targetDirection, transform.forward);
                    if (angleToPlayer >= -fieldOfView && angleToPlayer <= fieldOfView)
                    {
                        Ray ray = new Ray(transform.position + (Vector3.up * eyeHeight), targetDirection);
                        RaycastHit hitInfo = new RaycastHit();
                        if (Physics.Raycast(ray, out hitInfo, sightDistance))
                        {
                            if (hitInfo.transform.gameObject == player)
                            {
                                Debug.DrawRay(ray.origin, ray.direction * sightDistance);
                                return true;
                            }
                        }
                    }
                }
            }
        }
        return false;
    }

    public void SetShooting(bool isShooting)
    {
        if (animator != null)
        {
            animator.SetBool("isShooting", isShooting);
        }
    }

    public void gotShot()
    {
        isDying = true;
        if (animator)
            animator.SetBool("isDying", isDying);
        StartCoroutine(DestroyAfterDelay());
    }

    IEnumerator DestroyAfterDelay()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
