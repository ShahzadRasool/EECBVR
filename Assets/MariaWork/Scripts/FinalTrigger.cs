using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTrigger : MonoBehaviour
{
    public GameObject CongratulationsText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(wait());
        }
    }

    IEnumerator wait()
    {
        CongratulationsText.SetActive(true);
        yield return new WaitForSeconds(3f);
        CongratulationsText.transform.GetChild(3).gameObject.SetActive(false);
    }
}
