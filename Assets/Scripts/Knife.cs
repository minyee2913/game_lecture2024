using UnityEngine;

public class Knife : Weapon {
    public virtual bool Attack()
    {
        if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, maxDistance, detectLayer))
        {
            if(hit.transform.TryGetComponent(out IDamageable damageable))
            {
                damageable.TakeDamage(weaponDamage);
            }
        }

        return true;
    }
}