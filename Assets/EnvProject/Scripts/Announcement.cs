using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Announcement : MonoBehaviour
{
    public float delay;
    public float ClipTime;
    public AudioSource Annoucnemnt;
    private void Start()
    {
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        Annoucnemnt.Play();
        yield return new WaitForSeconds(delay+ClipTime);
        StartCoroutine(wait());
    }
}
