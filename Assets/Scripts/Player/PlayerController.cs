using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(WeaponHolder))]
public class PlayerController : MonoBehaviour
{
    PlayerInput input;
    PlayerMovement movement;
    WeaponHolder holder;
    void Awake()
    {
        input = GetComponent<PlayerInput>();
        movement = GetComponent<PlayerMovement>();
        holder = GetComponent<WeaponHolder>();
        
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        movement.MoveByInput(input.GetAxisInput());

        if (input.GetJumpInput())
            movement.JumpByInput();

        movement.ImplementGravity();

        int alphaInput = input.GetNumberInput();
        if (alphaInput >= 0) {
            holder.HoldWeapon(alphaInput);
        }
    }
}
