using UnityEngine;

public class Rifle : Gun, IZoomable {
    public void ZoomIn()
    {
        Debug.Log("zoom in");
    }

    public void ZoomOut()
    {
        Debug.Log("zoom out");
    }

    protected override void MouseLeftPress() {
        Attack();
    }

    protected override void RKeyPress()
    {
        Reload();
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