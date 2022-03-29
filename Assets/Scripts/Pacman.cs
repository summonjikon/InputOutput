using UnityEngine;
using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
[RequireComponent(typeof(Movement))]
public class Pacman : MonoBehaviour
{
    public AnimatedSprite deathSequence;
    public SpriteRenderer spriteRenderer { get; private set; }
    public new Collider2D collider { get; private set; }
    public Movement movement { get; private set; }
    public SerialPort port = new SerialPort("COM6", 19200);
    string lastInput;
    string updatedInput;
    bool inputGiven;
    float timer;
    Vector2 playerPos;

    private Dictionary<string, Vector2> directionMap = new Dictionary<string, Vector2>()
    {
        { "UP", Vector2.up },
        { "LEFT", Vector2.left },
        { "DOWN", Vector2.down },
        { "RIGHT", Vector2.right},
        { "NEAR", Vector2.zero},
        { "FAR", Vector2.zero},
        { "NONE", Vector2.zero}
    };
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<Collider2D>();
        movement = GetComponent<Movement>();
        port.Open();
    }

    private void Update()
    {
        // Rotate pacman to face the movement direction
        float angle = Mathf.Atan2(movement.direction.y, movement.direction.x);
        transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);

        timer += Time.deltaTime;
        playerPos = gameObject.transform.position;
        ReadInput();
    }

    public void ResetState()
    {
        enabled = true;
        spriteRenderer.enabled = true;
        collider.enabled = true;
        deathSequence.enabled = false;
        deathSequence.spriteRenderer.enabled = false;
        movement.ResetState();
        gameObject.SetActive(true);
    }

    public void DeathSequence()
    {
        enabled = false;
        spriteRenderer.enabled = false;
        collider.enabled = false;
        movement.enabled = false;
        deathSequence.enabled = true;
        deathSequence.spriteRenderer.enabled = true;
        deathSequence.Restart();
    }

    private void ReadInput()
    {
        if (timer >= 0.5) return;
        if (!port.IsOpen) return;

        updatedInput = port.ReadLine();

        if (updatedInput == lastInput) return;

        lastInput = updatedInput;

        Vector2 direction = directionMap[lastInput];
        movement.SetDirection(direction);
        inputGiven = true;
        timer = 0;
    }

}
