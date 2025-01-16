using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCIntervention : MonoBehaviour
{
    public static NPCIntervention Instance;
    public bool isInHall = true;
    public bool isTold = false;
    public GameObject[] OtherNpcs;
    public GameObject Player;
    public float TargetDistance;
    public float AllowedDistance = 5f;
    public GameObject NPC;
    public float FollowSpeed;
    public RaycastHit shot;
    public Animator NPCAnimator;
    public AudioSource NPCInterventionAudio;

    public void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (isTold == false)
        {
            if (isInHall)
            {
                if (!OtherNpcs[0].activeSelf && !OtherNpcs[1].activeSelf && !OtherNpcs[2].activeSelf)
                {
                    transform.LookAt(Player.transform);
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
                    {
                        TargetDistance = shot.distance;
                        if (TargetDistance >= AllowedDistance)
                        {
                            FollowSpeed = 0.1f;
                            NPCAnimator.SetBool("Running", true);
                            NPCAnimator.SetBool("talking", false);
                            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, FollowSpeed);
                            NPCInterventionAudio.Play();
                            StartCoroutine(CheckAudio());
                        }
                        else
                        {
                            FollowSpeed = 0;
                            NPCAnimator.SetBool("talking", true);
                            NPCAnimator.SetBool("Running", false);
                        }
                    }
                }
            }
        }
        else
        {
            NPCAnimator.SetBool("idle", true);
            NPCAnimator.SetBool("Running", false);
            NPCAnimator.SetBool("talking", false);
        }
    }
    IEnumerator CheckAudio()
    {
        yield return new WaitForSeconds(8f);
        isTold = true;
    }
}
