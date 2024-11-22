using UnityEngine;

public class ShotGun : Gun, IRecoilable {
    [SerializeField] private float recoilForce;
    public void Recoil(float force)
    {
        Debug.Log("반동" + recoilForce.ToString() + "만큼 받기");
    }

    protected override void MouseLeftPress() {
        if (Attack()) {
            Recoil(recoilForce);
        }
    }

    protected override void RKeyPress()
    {
        Reload();
    }
}