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

    public int GetNumberInput() {
        for (int i = 0; i < 9; i++) {
            if (Input.GetKeyDown(KeyCode.Alpha0 + i)) {
                return i;
            }
        }

        return -1;
    }

    public Vector2 GetAxisStored() {
        return axisInput;
    }
}
