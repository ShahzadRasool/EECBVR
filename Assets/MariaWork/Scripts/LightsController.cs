using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BNG 
{
    public class LightsController : MonoBehaviour 
    {
        public GameObject Lights1;
        public GameObject Lights2;
        public GameObject Lights3;
        public GameObject Lights4;
        public GameObject Lights5;
        public GameObject Lights6;
        public GameObject Lights7;
        public Material Lightsbulb1;
        public Material Lightsbulb2;
        public Material Lightsbulb3;
        public Material Lightsbulb4;
        public Material Lightsbulb5;
        public Material Lightsbulb6;
        public Material Lightsbulb7;
        public GameObject Lights1Arrow;
        public GameObject Lights2Arrow;
        public GameObject Lights3Arrow;
        public GameObject Lights4Arrow;
        public GameObject Lights5Arrow;
        public GameObject Lights6Arrow;
        public GameObject Lights7Arrow;
        public int a = 0;
        public int b = 0;
        public int c = 0;
        public int d = 0;
        public int e = 0;
        public int f = 0;
        public int g = 0;

        private void Start()
        {
            Lightsbulb1.color = new Color(0, 1, 0.12f);
            Lightsbulb2.color = new Color(0, 1, 0.12f);
            Lightsbulb3.color = new Color(0, 1, 0.12f);
            Lightsbulb4.color = new Color(0, 1, 0.12f);
            Lightsbulb5.color = new Color(0, 1, 0.12f);
            Lightsbulb6.color = new Color(0, 1, 0.12f);
            Lightsbulb7.color = new Color(0, 1, 0.12f);
            LightsOnOff("Room2");
            LightsOnOff("Room4");
        }

        public void LightsOnOff(string buttonname) 
        {
            if (buttonname == "Room1")
            {
                a++;
                if (a == 1)
                {
                    Lights1.SetActive(false);
                    Lights1Arrow.SetActive(false);
                    Lightsbulb1.color = new Color(1,0,0);
                }
                else
                {
                    a = 0;
                    Lights1.SetActive(true);
                    Lights1Arrow.SetActive(true);
                    Lightsbulb1.color = new Color(0, 1, 0.12f);
                }
            }
            else if (buttonname == "Room2")
            {
                b++;
                if (b == 1)
                {
                    Lights2.SetActive(false);
                    Lights2Arrow.SetActive(false);
                    Lightsbulb2.color = new Color(1, 0, 0);
                }
                else
                {
                    b = 0;
                    Lights2.SetActive(true);
                    Lights2Arrow.SetActive(true);
                    Lightsbulb2.color = new Color(0, 1, 0.12f);
                }
            }
            else if (buttonname == "Room3")
            {
                c++;
                if (c == 1)
                {
                    Lights3.SetActive(false);
                    Lights3Arrow.SetActive(false);
                    Lightsbulb3.color = new Color(1, 0, 0);
                }
                else
                {
                    c = 0;
                    Lights3.SetActive(true);
                    Lights3Arrow.SetActive(true);
                    Lightsbulb3.color = new Color(0, 1, 0.12f);
                }
            }
            else if (buttonname == "Room4")
            {
                d++;
                if (d == 1)
                {
                    Lights4.SetActive(false);
                    Lights4Arrow.SetActive(false);
                    Lightsbulb4.color = new Color(1, 0, 0);
                }
                else
                {
                    d = 0;
                    Lights4.SetActive(true);
                    Lights4Arrow.SetActive(true);
                    Lightsbulb4.color = new Color(0, 1, 0.12f);
                }
            }
            else if (buttonname == "Room5")
            {
                e++;
                if (e == 1)
                {
                    Lights5.SetActive(false);
                    Lights5Arrow.SetActive(false);
                    Lightsbulb5.color = new Color(1, 0, 0);
                }
                else
                {
                    e = 0;
                    Lights5.SetActive(true);
                    Lights5Arrow.SetActive(true);
                    Lightsbulb5.color = new Color(0, 1, 0.12f);
                }
            }
            else if (buttonname == "Room6")
            {
                f++;
                if (f == 1)
                {
                    Lights6.SetActive(false);
                    Lights6Arrow.SetActive(false);
                    Lightsbulb6.color = new Color(1, 0, 0);
                }
                else
                {
                    f = 0;
                    Lights6.SetActive(true);
                    Lights6Arrow.SetActive(true);
                    Lightsbulb6.color = new Color(0, 1, 0.12f);
                }
            }
            else if (buttonname == "Room7")
            {
                g++;
                if (g == 1)
                {
                    Lights7.SetActive(false);
                    Lights7Arrow.SetActive(false);
                    Lightsbulb7.color = new Color(1, 0, 0);
                }
                else
                {
                    g = 0;
                    Lights7.SetActive(true);
                    Lights7Arrow.SetActive(true);
                    Lightsbulb7.color = new Color(0, 1, 0.12f);
                }
            }

            if(FinalandCharacterController.Instance)
            {
                FinalandCharacterController.Instance.Check();
            }
        }
    }
}