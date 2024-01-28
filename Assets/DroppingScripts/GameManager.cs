using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //public List<GameObject> targetObjects;
    private List<PoopTarget> poopTargets;

    public string nextSceneString;

    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {

        camera = Camera.main;
        poopTargets = new List<PoopTarget>();
        GameObject[] targetObjects = GameObject.FindGameObjectsWithTag("Target");
        foreach (GameObject g in targetObjects)
        {
            poopTargets.Add(g.GetComponent<PoopTarget>());

        }
    }

    public void clickedOnBackground()
    {
        Debug.Log("player lost");
    }

    // Update is called once per frame
    void Update()
    {
    //     if (Input.GetMouseButtonDown(0))
    //     {

    //        Vector3 mousePosition = Input.mousePosition;
    //        Ray ray = camera.ScreenPointToRay(mousePosition);
    //        if (Physics.Raycast(ray, out RaycastHit hit))
    //        {
    //         Debug.Log(hit.)
    //            // Use the hit variable to determine what was clicked on.
    //        }
    //    }
            // Vector3 mousePos = Input.mousePosition;
            // bool targetHit = false;

            // foreach (PoopTarget poopTarget in poopTargets)
            // {
            //     if ((Mathf.Abs(mousePos.x - poopTarget.gameObject.transform.position.x) < poopTarget.xSize) && Math.Abs(mousePos.y - poopTarget.gameObject.transform.position.y) < poopTarget.ySize)
            //     {
            //         poopTarget.GotPooped();
            //         targetHit = true;
            //     }
            // }
            // if (!targetHit)
            // {
            //     // game over
            // }

        //}

        // if (targetsAllHit())
        // {
        //     StartCoroutine(MoveCoroutine());
        //     //start ending sequence
        //     // Debug.Log("All targets hit");
        // }
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

    private IEnumerator MoveCoroutine()
    {


        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(nextSceneString);
    }
}
