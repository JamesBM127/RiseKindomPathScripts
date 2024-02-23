using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentWeapon : MonoBehaviour
{
    public GameObject weaponPrefab;
    public SpriteRenderer spriteInstWeapon;
    private int spriteLayer;

    void Start()
    {
        weaponPrefab = Instantiate(weaponPrefab, this.transform);
        spriteInstWeapon = weaponPrefab.GetComponent<SpriteRenderer>();
        int playerLayer = Player.player.gameObject.GetComponent<SpriteRenderer>().sortingOrder;
        //GameObject weaponInst = Instantiate(weaponPrefab, this.transform);
        //spriteInstWeapon = weaponInst.GetComponent<SpriteRenderer>();
        spriteLayer = playerLayer;
    }

    void Update()
    {
        switch (Player.player.animatorDirection)
        {
            case "Down":
            case "Right":
                spriteInstWeapon.sortingOrder = spriteLayer + 1;
                break;

            case "Left":
            case "Up":
                spriteInstWeapon.sortingOrder = spriteLayer - 1;
                break;
        }
    }
}
