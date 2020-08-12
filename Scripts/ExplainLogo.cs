using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplainLogo : MonoBehaviour {

	
    IEnumerator Explain()
    {
        yield return new WaitForSeconds(8.0f);
        Application.LoadLevel(1);
    }
	
	// Update is called once per frame
	void Update () {

        StartCoroutine(Explain());
		
	}
}
