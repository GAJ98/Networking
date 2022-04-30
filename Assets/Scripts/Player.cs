using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
  [SerializeField] private float speed = 10.0f;
  void HandleMovement()
  {
    if (isLocalPlayer)
    {
      float moveHorizontal = Input.GetAxis("Horizontal") * (speed * Time.deltaTime);
      float moveVertical = Input.GetAxis("Vertical") * (speed * Time.deltaTime);

      Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
      transform.position = transform.position + movement;
    }
  }

  void Update()
  {
    HandleMovement();
  }
}
