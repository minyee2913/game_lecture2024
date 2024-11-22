using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon, IAttackable, IReloadable
{
    [SerializeField] protected int maxAmmoCount; // max ammo
    [SerializeField] protected int curAmmoCount; // current ammo
    [SerializeField] protected int totalAmmoCount; // Player Inventory ammo count
    [SerializeField] protected int ammoPerShot; // fire per ammo count

    public virtual bool Attack()
    {
        if(curAmmoCount <= 0 ) return false;

        int shootingAmmoCount = Mathf.Min(ammoPerShot, curAmmoCount);
        curAmmoCount = shootingAmmoCount;

        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, maxDistance, detectLayer))
        {
            if(hit.transform.TryGetComponent<IDamageable>(out IDamageable damageable))
            {
                damageable.TakeDamage(weaponDamage * shootingAmmoCount);
            }
        }

        return true;
    }

    public virtual void Reload()
    {

    }
}
