using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
  public FixedJoystick moveJoystick;
  public FixedJoystick aimJoystick;
  
  Vector2 moveVelocity;
  Vector2 aimVelocity;
  public Rigidbody2D rb;

  public float moveSpeed;
  public float fireSpeed;

  private void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    moveVelocity = new Vector2(moveJoystick.Horizontal, moveJoystick.Vertical);
    Vector2 MoveInput = new Vector2(moveJoystick.Horizontal, moveJoystick.Vertical);
    Vector2 MoveDirection = MoveInput.normalized * moveSpeed;
    rb.MovePosition(rb.position + MoveDirection * Time.deltaTime);
    
    aimVelocity = new Vector2(aimJoystick.Horizontal, aimJoystick.Vertical);
    Vector2 AimInput = new Vector2(aimJoystick.Horizontal, aimJoystick.Vertical);
    Vector2 LookAtPoint = AimInput.normalized * fireSpeed;
    transform.LookAt(LookAtPoint);
  }
}
