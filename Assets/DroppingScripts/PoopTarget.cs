using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoopTarget : MonoBehaviour
{

    public bool hasBeenHit = false;
    // Start is called before the first frame update

    public Image poop;
    public Image check;
    void Start()
    {
        poop.GetComponent<Image>().color = new Color32(255,255,225,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            
            if (Vector3.Distance(mousePos, this.transform.position) < 50)
            {
                hasBeenHit = true;
                poop.GetComponent<Image>().color = new Color32(255,255,225,255);
                check.GetComponent<Image>().color = new Color32(255,255,225,255);
            }
            
        }
    }
}
