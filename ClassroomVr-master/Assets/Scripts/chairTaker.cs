using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class chairTaker : MonoBehaviour
{
    public GameObject introText;




    void Start()
    {
        introText.SetActive(false);
    }




    void OnTriggerEnter(Collider other)


    {
        if (other.gameObject.CompareTag("Chair"))

        {
            introText.SetActive(true);
            StartCoroutine(GotoNextScenario());
           

        }

    }


    IEnumerator GotoNextScenario()
    {
       
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(1);
      
    }

}
