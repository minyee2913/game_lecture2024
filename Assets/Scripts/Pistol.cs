using UnityEngine;

public class Pistol : Gun {
    protected override void MouseLeftPress() {
        Attack();
    }

    protected override void RKeyPress()
    {
        Reload();
    }
}