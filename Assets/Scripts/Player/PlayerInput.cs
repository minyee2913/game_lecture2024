using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    float h, v;
    Vector2 axisInput;
    public Vector2 GetAxisInput(bool normalize = true) {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        axisInput = new Vector2(h, v);

        if (normalize)
            axisInput = axisInput.normalized;

        return axisInput;
    }

    public bool GetJumpInput() {
        return Input.GetKeyDown(KeyCode.Space);
    }

    public Vector2 GetAxisStored() {
        return axisInput;
    }
}
