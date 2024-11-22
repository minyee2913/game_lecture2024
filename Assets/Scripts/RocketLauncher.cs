using UnityEngine;

public class RocketLauncher : Gun, IRecoilable, IZoomable {
    [SerializeField] private float recoilForce;
    public void Recoil(float force)
    {
        Debug.Log("반동" + recoilForce.ToString() + "만큼 받기");
    }

    protected override void MouseLeftPress() {
        Attack();
    }

    protected override void RKeyPress()
    {
        Reload();
    }

        public void ZoomIn()
    {
        Debug.Log("zoom in");
    }

    public void ZoomOut()
    {
        Debug.Log("zoom out");
    }

    protected override void MouseRightPress()
    {
        ZoomIn();
    }

    protected override void MouseRightRelease()
    {
        ZoomOut();
    }
}