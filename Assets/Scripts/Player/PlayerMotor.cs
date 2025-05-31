using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool isGrounded; 
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    private bool isWalking = false;
    private Animator animator;

    private bool lerpCrouch = false, sprinting= false;
    public bool crouching = false;
    private float crouchTimer = 0;
    private PlayerInteract playerInteract;

    public AudioClip walkingSound;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerInteract = GetComponent<PlayerInteract>();
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = walkingSound;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;
        if (lerpCrouch)
        {
            crouchTimer += Time.deltaTime;
            float p = crouchTimer / 1;
            p *= p;
            if (crouching)
                controller.height = Mathf.Lerp(controller.height, 1, p);
            else
                controller.height = Mathf.Lerp(controller.height, 2, p);
            if (p > 1)
            {
                lerpCrouch = false;
                crouchTimer = 0f;
            }

        }

        if(animator)
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
            {
                animator.SetBool("isJumping", false);
            }

    }
    // Receive the inputs for our InputManager.cs and apply them to our character controller.
    public void ProcessMove(Vector2 input)
    {
        Vector3 moveDirection = new Vector3(input.x, 0, input.y);
        controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);

        bool isMoving = moveDirection.magnitude > 0.1f && isGrounded;

        if (isMoving)
        {
            if(animator)
                if (!isWalking)
                {
                    isWalking = true;
                    animator.SetBool("isWalking", true);
                }

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
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

            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
        }

        playerVelocity.y += gravity * Time.deltaTime;
        if (isGrounded && playerVelocity.y < 0)
            playerVelocity.y = -2f;

        controller.Move(playerVelocity * Time.deltaTime);
    }
    public void Jump()
    {
        if(isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
            if (animator)
                animator.SetBool("isJumping", true);
        }
    }
    public void Crouch()
    {
        crouching = !crouching;
        crouchTimer = 0;
        lerpCrouch = true;
    }
    public void Sprint()
    {
        sprinting = !sprinting;
        if (sprinting)
            speed = 8;
        else
            speed = 5;
    }

    /*
    public void Shoot() //called from input manager, on mouse click
    {
        Debug.Log("Shoot function called");  // Debug to confirm function is called

        //makes a sound
        //Changes the crossplane
        //then


        playerInteract.ShootEnemy(); //looks if the ray on the enemy and shoot
    }

    */
}
