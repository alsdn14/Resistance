using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponChange : MonoBehaviour {


    public GameObject MyWeapon;
    public GameObject WeaponOntheGround;
    public GameObject FirstWeapon;
    public GameObject SecondWeapon;
    public GameObject ThirdWeapon;
    public GameObject FifthWeapon;

    void Start()
    {

        MyWeapon.SetActive(false);
        SecondWeapon.SetActive(false);
        ThirdWeapon.SetActive(false);
        FifthWeapon.SetActive(false);

    }

    void OnTriggerEnter(Collider _collider)
    {
        Debug.Log("Trigger M4!");
        if (_collider.gameObject.tag == "Player")
        {
            SoundManager2.instance.PlaySound();
            MyWeapon.SetActive(true);
            WeaponOntheGround.SetActive(false);
            FirstWeapon.SetActive(false);
            SecondWeapon.SetActive(false);
            ThirdWeapon.SetActive(false);
            FifthWeapon.SetActive(false);

        }
    }
}

