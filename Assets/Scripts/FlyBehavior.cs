using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehavior : MonoBehaviour
{
    [SerializeField] float velocity = 2f;
    [SerializeField] float rotationSpeed = 10f;
    private Rigidbody2D rb;
    AudioPlayer audioPlayer;
    bool isAlive = true;

    private void Awake()
    {
        audioPlayer = FindObjectOfType<AudioPlayer>();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!isAlive)
        {
            return;
        }

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.velocity = Vector2.up * velocity;
            audioPlayer.PlayFlappingClip();
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
        isAlive = false;
        audioPlayer.PlayHitClip();
    }

    public bool PlayerIsAlive()
    {
        return isAlive;
    }
}
