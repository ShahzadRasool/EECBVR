using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class MyDestination : MonoBehaviour
{
    public GameObject Player;
    public GameObject NPC;
    public AudioSource LeavingSentence;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(Wait());
        }
    }


    IEnumerator Wait()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        if (SceneManager.GetActiveScene().name == "OfficeEnvironmentNPCIntevention")
        {
            LeavingSentence.Play();
            NPC.transform.LookAt(new Vector3(Player.transform.position.x, NPC.transform.position.y, Player.transform.position.z));
            NPC.transform.LookAt(new Vector3(Player.transform.position.x, NPC.transform.position.y, Player.transform.position.z));
            NPC.transform.LookAt(new Vector3(Player.transform.position.x, NPC.transform.position.y, Player.transform.position.z));
        }
        yield return new WaitForSeconds(8f);
        NPC.GetComponent<Animator>().SetBool("walk", true);
        NPC.GetComponent<SWS.navMove>().enabled = true;
        NPC.GetComponent<NavMeshAgent>().enabled = true;
    }
}
