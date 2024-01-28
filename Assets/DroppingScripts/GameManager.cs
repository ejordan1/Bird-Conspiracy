using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{


    public string nextSceneString;


    void Start()
    {

    }

    public void clickedOnBackground()
    {
        Debug.Log("player lost");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator MoveCoroutine()
    {


        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(nextSceneString);
    }
}
