using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSuccessText : MonoBehaviour {

	void OnEnable ()
    {
        StartCoroutine(HideText());
	}

    IEnumerator HideText ()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }

}
