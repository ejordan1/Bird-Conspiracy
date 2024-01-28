using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMOD.Studio;

public class MusicManager : MonoBehaviour
{

    private EventInstance musicInstance;
    // Start is called before the first frame update
    void Start()
    {
        
        musicInstance = AudioManager.instance.CreateInstance(FMODEvents.instance.music);
    
        musicInstance.start();
        StartCoroutine(IncreaseDrone());
    }

    // Update is called once per frame
    void Update()
    {
        
    }





    private IEnumerator IncreaseDrone()
    {
        yield return new WaitForSeconds(7f);
        musicInstance.setParameterByName("Drone Intensity", 1);
    }
}
