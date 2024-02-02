using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCredits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    

    private IEnumerator SwitchScene()
    {

        yield return new WaitForSeconds(5.3f);
            SceneManager.LoadScene("Notreal");
    }
}
