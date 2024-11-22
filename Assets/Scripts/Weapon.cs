using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] protected int weaponDamage;
    [SerializeField] protected float maxDistance;
    [SerializeField] protected LayerMask detectLayer;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            MouseLeftPress();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            MouseLeftRelease();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            MouseRightPress();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            MouseRightRelease();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RKeyPress();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RKeyRelease();
        }
    }

    protected virtual void MouseLeftPress()
    {

    }
    protected virtual void MouseLeftRelease()
    {

    }
    protected virtual void MouseRightPress()
    {

    }
    protected virtual void MouseRightRelease()
    {

    }
    protected virtual void RKeyPress()
    {

    }
    protected virtual void RKeyRelease()
    {

    }
}
