using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private List<PoopTarget> poopTargets;
    public string nextSceneString;


    void Start()
    {
        poopTargets = new List<PoopTarget>();
        GameObject[] targetObjects = GameObject.FindGameObjectsWithTag("Target");
        foreach (GameObject g in targetObjects)
        {
            poopTargets.Add(g.GetComponent<PoopTarget>());

        }
    }

    public void clickedOnBackground()
    {
        SceneManager.LoadScene("PlayerLost");
    }

    // Update is called once per frame
    void Update()
    {
        if (targetsAllHit())
        {
            StartCoroutine(MoveCoroutine());
            //start ending sequence
            // Debug.Log("All targets hit");
        }
    }

    private IEnumerator MoveCoroutine()
    {


        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(nextSceneString);
    }


    private bool targetsAllHit()
    {
        foreach (PoopTarget p in poopTargets)
        {
            if (!p.hasBeenHit)
            {
                return false;
            }
        }
        return true;
    }
}
