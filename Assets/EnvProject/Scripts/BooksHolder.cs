using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BooksHolder : MonoBehaviour
{
    public GameObject BookHolder;
    public GameObject BookHolderPlacementText1;
    public GameObject BookHolderPlacementText2;
    public GameObject BookHolderPlacementText3;
    
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
            //Will Accept Book 3
            if (other.gameObject.tag == "book3")
            {
                Highlighter1.SetActive(false);
                BookHolder.SetActive(true);
                PickableBooks[2].SetActive(false);
                PlayerPrefs.SetInt("Count", PlayerPrefs.GetInt("Count") + 1);
            }
            else
            {
                if (other.gameObject.tag == "book1")
                {
                    BookHolderPlacementText2.SetActive(true);
                }
                else if (other.gameObject.tag == "book2")
                {
                    BookHolderPlacementText3.SetActive(true);
                }
                StartCoroutine(wait2());
            }
        }
        else if (this.gameObject.name == "Dest2")
        {
            // Will Accept Book 1
            if (other.gameObject.tag == "book1")
            {
                Highlighter2.SetActive(false);
                BookHolder.SetActive(true);
                PickableBooks[0].SetActive(false);
                PlayerPrefs.SetInt("Count", PlayerPrefs.GetInt("Count") + 1);
            }
            else
            {
                if (other.gameObject.tag == "book2")
                {
                    BookHolderPlacementText3.SetActive(true);
                }
                else if (other.gameObject.tag == "book3")
                {
                    BookHolderPlacementText1.SetActive(true);
                }
                StartCoroutine(wait2());
            }
        }
        else if (this.gameObject.name == "Dest3")
        {
            // Will Accept Book 2
            if (other.gameObject.tag == "book2")
            {
                Highlighter3.SetActive(false);
                BookHolder.SetActive(true);
                PickableBooks[1].SetActive(false);
                PlayerPrefs.SetInt("Count", PlayerPrefs.GetInt("Count") + 1);
            }
            else
            {
                if(other.gameObject.tag == "book1")
                {
                    BookHolderPlacementText3.SetActive(true);
                }
                else if(other.gameObject.tag == "book3")
                {
                    BookHolderPlacementText1.SetActive(true);
                }
                StartCoroutine(wait2());
            }
        }
        if(PlayerPrefs.GetInt("Count") == 3)
        {
            PlaceBooksText.SetActive(false);
            StartCoroutine(wait());
        }
    }


    IEnumerator wait()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            turnlightsoffSound.Play();
        }
        TurnLightsOffText.SetActive(true);
        ArrowsLights.SetActive(true);
        yield return new WaitForSeconds(10f);
        TurnLightsOffText.SetActive(false);
    }
    
    IEnumerator wait2()
    {
        yield return new WaitForSeconds(3f);
        BookHolderPlacementText1.SetActive(false);
        BookHolderPlacementText2.SetActive(false);
        BookHolderPlacementText3.SetActive(false);
    }
}
