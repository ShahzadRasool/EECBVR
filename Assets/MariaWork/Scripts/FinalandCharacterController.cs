using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalandCharacterController : MonoBehaviour
{
    public static FinalandCharacterController Instance;

    public GameObject[] ArrowsCheck;
    public GameObject WalkTowardsExit;
    public GameObject FinalTrigger;
    public GameObject StartingText;
    public AudioSource WalkTowardsExitSound;
    public AudioSource StartingSound;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        StartCoroutine(waitforstartingtext());
    }

    IEnumerator waitforstartingtext()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 1|| SceneManager.GetActiveScene().buildIndex == 3)
        {
            StartingSound.Play();
        }
        StartingText.SetActive(true);
        yield return new WaitForSeconds(5f);
        StartingText.SetActive(false);
    }
    public void Check()
    {
        if (!ArrowsCheck[0].activeSelf && !ArrowsCheck[1].activeSelf && !ArrowsCheck[2].activeSelf && !ArrowsCheck[3].activeSelf && !ArrowsCheck[4].activeSelf && !ArrowsCheck[5].activeSelf && !ArrowsCheck[6].activeSelf)
        {
            StartCoroutine(wait());
            FinalTrigger.SetActive(true);
        }
    }

    IEnumerator wait()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 1 || SceneManager.GetActiveScene().buildIndex == 3)
        {
            WalkTowardsExitSound.Play();
        }
        WalkTowardsExit.SetActive(true);
        yield return new WaitForSeconds(10f);
        WalkTowardsExit.SetActive(false);
    }
}
