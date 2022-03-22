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
    float timer;
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider = GetComponent<Collider2D>();
        movement = GetComponent<Movement>();
        port.Open();

        port.ReadTimeout = 100;
    }

    private void Update()
    {
        // Set the new direction based on the current input
        if(timer > 1)
        {
            if (port.IsOpen == true)
            {
                updatedInput = port.ReadLine();
                if (updatedInput != lastInput)
                {
                    lastInput = updatedInput;
                    //up
                    if (lastInput == "UP")
                    {
                        movement.SetDirection(Vector2.up);
                    }
                    //down
                    else if (lastInput == "DOWN")
                    {
                        movement.SetDirection(Vector2.down);
                    }
                    //left
                    else if (lastInput == "LEFT")
                    {
                        movement.SetDirection(Vector2.left);
                    }
                    //right
                    else if (lastInput == "RIGHT")
                    {
                        movement.SetDirection(Vector2.right);
                    }
                    timer = 0;
                }
            }
        }

        else
        {
            timer += Time.deltaTime;
        }

        // Rotate pacman to face the movement direction
        float angle = Mathf.Atan2(movement.direction.y, movement.direction.x);
        transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);
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

}
