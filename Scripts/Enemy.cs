using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{


    public float health = 50f;
    private GameObject Player;
    private NavMeshAgent navMesh;
    private Animator ani;
    private bool isAttack;
    //공격중 상태를 저장하는 변수


    void Start()
    {

        Player = GameObject.FindWithTag("Player");

        navMesh = GetComponent<NavMeshAgent>();

        ani = GetComponent<Animator>();




    }

    void Update()
    {
        
        navMesh.destination = Player.transform.position;
        

        float Distance = Vector3.Distance(Player.transform.position, transform.position);

        if (Distance <= 6.0f)
        {

            navMesh.Stop();

            if (isAttack == false)
            {
                ani.SetBool("Idle", true);

                StartCoroutine(Attack());


            }
        }
        

        else
        {
            
            ani.SetBool("Idle", false);

            navMesh.Resume();
        }

    }

    IEnumerator Attack()
    {
        isAttack = true;

        yield return new WaitForSeconds(1f);

        ani.SetBool("Attack", true);

        yield return new WaitForSeconds(0.5f);

        Player.GetComponent<PlayerCtrl>().ApplyDamage(10);
        

        isAttack = false;

        ani.SetBool("Attack", false);




    }



    public void TakeDamage(float amount)
    {
        health -= amount;

        if (health <= 0f)
        {
            
            StartCoroutine(delay());

            
        }

    }

    IEnumerator delay()
    {
        SoundManager.instance.PlaySound();
        ani.SetBool("down", true);

        yield return new WaitForSeconds(1f);

        Destroy(gameObject);

    }
}
