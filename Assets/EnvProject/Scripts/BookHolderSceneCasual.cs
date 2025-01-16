using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BookHolderSceneCasual : MonoBehaviour
{
    public GameObject[] BookHolder1;
    public GameObject[] BookHolder2;
    public GameObject[] BookHolder3;

    public GameObject[] PickableBooks;

    public GameObject PlaceBooksText;
    public GameObject TurnLightsOffText;


    public GameObject Highlighter1;
    public GameObject Highlighter2;
    public GameObject Highlighter3;

    public GameObject ArrowsLights;
    public AudioSource turnlightsoffSound;

    private void Start()
    {
        PlayerPrefs.SetInt("Count", 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.name == "Dest1")
        {
            Highlighter1.SetActive(false);
            if (other.gameObject.tag == "book1")
            {
                BookHolder1[0].SetActive(true);
                PickableBooks[0].SetActive(false);
            }
            else if (other.gameObject.tag == "book2")
            {
                BookHolder1[1].SetActive(true);
                PickableBooks[1].SetActive(false);
            }
            else if (other.gameObject.tag == "book3")
            {
                BookHolder1[2].SetActive(true);
                PickableBooks[2].SetActive(false);
            }
            PlayerPrefs.SetInt("Count", PlayerPrefs.GetInt("Count") + 1);
        }
        else if (this.gameObject.name == "Dest2")
        {
            Highlighter2.SetActive(false);
            if (other.gameObject.tag == "book1")
            {
                BookHolder2[0].SetActive(true);
                PickableBooks[0].SetActive(false);
            }
            else if (other.gameObject.tag == "book2")
            {
                BookHolder2[1].SetActive(true);
                PickableBooks[1].SetActive(false);
            }
            else if (other.gameObject.tag == "book3")
            {
                BookHolder2[2].SetActive(true);
                PickableBooks[2].SetActive(false);
            }
            PlayerPrefs.SetInt("Count", PlayerPrefs.GetInt("Count") + 1);
        }
        else if (this.gameObject.name == "Dest3")
        {
            Highlighter3.SetActive(false);
            if (other.gameObject.tag == "book1")
            {
                BookHolder3[0].SetActive(true);
                PickableBooks[0].SetActive(false);
            }
            else if (other.gameObject.tag == "book2")
            {
                BookHolder3[1].SetActive(true);
                PickableBooks[1].SetActive(false);
            }
            else if (other.gameObject.tag == "book3")
            {
                BookHolder3[2].SetActive(true);
                PickableBooks[2].SetActive(false);
            }
            PlayerPrefs.SetInt("Count", PlayerPrefs.GetInt("Count") + 1);
        }

        if (PlayerPrefs.GetInt("Count") == 3)
        {
            PlaceBooksText.SetActive(false);
            StartCoroutine(wait());
        }
    }


    IEnumerator wait()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            turnlightsoffSound.Play();
        }
        TurnLightsOffText.SetActive(true);
        ArrowsLights.SetActive(true);
        yield return new WaitForSeconds(10f);
        TurnLightsOffText.SetActive(false);
    }
}
