using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public Transform[] SpawnPoint = new Transform[1];
    public GameObject Enemy;
    private float SpawnTime;


	// Use this for initialization
	void Start () {
        SpawnTime = 2.0f;

        StartCoroutine(Spawn());
	}

    IEnumerator Spawn()
    {

        yield return new WaitForSeconds(7f);

        for (int i = 0; i <= 10; i++)
        {
            int point = Random.Range(0, 5);

            Instantiate(Enemy, SpawnPoint[point].position, SpawnPoint[point].rotation);

            yield return new WaitForSeconds(SpawnTime);

            SpawnTime -= 0.01f;
        }
        yield return null;
    }
}
