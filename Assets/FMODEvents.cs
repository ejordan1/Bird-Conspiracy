using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using FMOD.Studio;

public class FMODEvents : MonoBehaviour
{
    public static FMODEvents instance {get; private set;}
    
    [field: Header ("Coin SFX")]
    [field: SerializeField] public EventReference poopsplat {get; private set;}

    [field: Header ("Music sfx")]
    [field: SerializeField] public EventReference music {get; private set;}
        // Start is called before the first frame update    
        private void Awake()
        {
            if (instance != null)
            {
                Debug.Log("Already has instance");
            }
            instance = this;
        }

        public EventInstance CreateInstance(EventReference eventReference)
        {
            EventInstance eventInstance = RuntimeManager.CreateInstance(eventReference);
            return eventInstance;
        }
}
