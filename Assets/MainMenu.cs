using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select stage    
                if (hit.transform.name == "LessVisualAids")
                {
                    SceneManager.LoadScene(2);
                }
                //Select stage    
                else if (hit.transform.name == "DenseVisualAids")
                {
                    SceneManager.LoadScene(4);
                }
                //Select stage    
                else if (hit.transform.name == "NPC Interaction")
                {
                    SceneManager.LoadScene(1);
                }
                //Select stage    
                else if (hit.transform.name == "LessAudioAids")
                {
                    SceneManager.LoadScene(0);
                }
                //Select stage    
                else if (hit.transform.name == "DenseAudioAids")
                {
                    SceneManager.LoadScene(3);
                }
                //Select stage    
                else if (hit.transform.name == "CasualScene")
                {
                    SceneManager.LoadScene(5);
                }
            }
        }
    }
}
