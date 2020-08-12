using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM40GUN : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public GameObject impactEffect;
    public GameObject impactEffect2;
    public float fireRate = 15f;
    public float damage2 = 20f;

    public ParticleSystem muzzleFlash;

    private float nextTimeToFire = 0f;


    // Update is called once per frame
    void Update () {
        

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }
        

    }
    void Shoot ()
    {

        muzzleFlash.Play();
        

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);  

            Enemy enemy = hit.transform.GetComponent<Enemy>();
            Enemy2 enemy2 = hit.transform.GetComponent<Enemy2>();
            Enemy3 enemy3 = hit.transform.GetComponent<Enemy3>();

            if (enemy != null)
            {
                enemy.TakeDamage(damage);
                GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 1f);
            }

            if (enemy2 != null)
            {
                enemy2.TakeDamage(damage);
                GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 1f);
            }

            if (enemy3 != null)
            {
                enemy3.TakeDamage(damage2);
                GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 1f);
            }

            GameObject impactGO2 = Instantiate(impactEffect2, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO2, 0.1f);

        }
        
    }

 }
    

