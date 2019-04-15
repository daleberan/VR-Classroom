using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenario2Greeter : MonoBehaviour
{

    public bool visitedStudent;
    public GameObject questionText;

    public GameObject goodGreetText;
    public GameObject badTeaseText;

    private void Start()
    {
        goodGreetText.SetActive(false);
        badTeaseText.SetActive(false);

        questionText.SetActive(false);
        visitedStudent = false; 


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("newStudent"))

        {

            questionText.SetActive(true);
            visitedStudent = true; 

  

        }
 
     }

    private void Update()
    {

        if (visitedStudent == true)
        {

            if (OVRInput.GetDown(OVRInput.RawButton.A) || OVRInput.GetDown(OVRInput.RawButton.B))
            {
                goodGreetText.SetActive(true);
                badTeaseText.SetActive(false);
                questionText.SetActive(false);
                StartCoroutine(GoToScenario3());
            }

            if (OVRInput.GetDown(OVRInput.RawButton.X) || OVRInput.GetDown(OVRInput.RawButton.Y))
            {
                badTeaseText.SetActive(true);
                goodGreetText.SetActive(false);
                questionText.SetActive(false);
               

            }
        }
    }


    IEnumerator GoToScenario3()
    {

        yield return new WaitForSeconds(12);
        SceneManager.LoadScene(2);

    }


   





}



