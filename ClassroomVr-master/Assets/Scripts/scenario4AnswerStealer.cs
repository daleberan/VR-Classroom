using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenario4AnswerStealer : MonoBehaviour
{

    public GameObject scenario4GoodText;
    public GameObject scenario4BadText;

    private GameObject answerKey;

    public bool visitedDesk;
    public bool haveAnswerKey;


    void Start()
    {


        visitedDesk = false;
        haveAnswerKey = false;

        scenario4GoodText.SetActive(false);
        scenario4BadText.SetActive(false);

        answerKey = GameObject.FindGameObjectWithTag("answerKey");
        answerKey.SetActive(true);

    }



    void OnTriggerEnter(Collider other)


    {
       

        if (other.gameObject.CompareTag("Desk"))
        {
          
                visitedDesk = true;
        

        }


        if (other.gameObject.CompareTag("Chair") && visitedDesk == true && haveAnswerKey == false)
        {
            
              scenario4GoodText.SetActive(true);
            scenario4BadText.SetActive(false);

            StartCoroutine(EndGame());

        }

        if (other.gameObject.CompareTag("Chair") && visitedDesk == true && haveAnswerKey == true)
        {

            scenario4BadText.SetActive(true);
            scenario4GoodText.SetActive(false);
            StartCoroutine(RestartLevel()); 
        }

        if (other.gameObject.CompareTag("answerKey"))


        {
            {

                haveAnswerKey = true;
               
            }
        }


    }


    IEnumerator RestartLevel()
    {

        yield return new WaitForSeconds(12);
        SceneManager.LoadScene(2);

    }

    IEnumerator EndGame()
    {

        yield return new WaitForSeconds(12);
        Application.Quit();

    }




}
