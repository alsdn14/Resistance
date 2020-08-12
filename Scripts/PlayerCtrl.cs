using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCtrl : MonoBehaviour {

    public int Health;   
    public Text HPText;
    public Animation DamageEffect;


	void Start () {
        Health = 100;
	}

    public void ApplyDamage(int Damage)
    {
        Health -= Damage;
        HPText.text = "Health :" + Health;
        DamageEffect.Play();

        if (Health <= 0)
        {
            Application.LoadLevel(7);
        }
    }
	
}
