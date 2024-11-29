using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour {
    [SerializeField] private Transform hand;
    [SerializeField]
    private List<Weapon> weapons = new();
    private Weapon _holdingWep;

    public void HoldWeapon(int index){
        ClearHand();

        if (index < 0 || index >= weapons.Count) {
            return;
        }

        _holdingWep = Instantiate(weapons[index], hand);
    }
    public void ClearHand() {
        if (_holdingWep == null) return;

        Destroy(_holdingWep.gameObject);

        _holdingWep = null;
    }
}