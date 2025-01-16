using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            NPCIntervention.Instance.isInHall = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            NPCIntervention.Instance.isInHall = false;
        }
    }
}
