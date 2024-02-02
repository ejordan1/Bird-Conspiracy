using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class FlyMusic : MonoBehaviour


{

        [SerializeField] private EventReference flyMusic;

        [SerializeField] private EventReference fallSound;
        [SerializeField] private EventReference splatSound;


    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        StartCoroutine(FlyBeginning());
         StartCoroutine(SplatSound());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SplatSound()
    {
        yield return new WaitForSeconds(6f);
        AudioManager.instance.PlayOneShot(splatSound, this.transform.position);
        yield return new WaitForSeconds(2.6f);
        AudioManager.instance.PlayOneShot(fallSound, this.transform.position);

    }

    private IEnumerator FlyBeginning()
    {
        int counter = 0;
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
                        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
               yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
               yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
               yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
               yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
               yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
               yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
               yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
               yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
               yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
               yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
               yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
        yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.04f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.1f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);

                yield return new WaitForSecondsRealtime(.2f);
        AudioManager.instance.PlayOneShot(flyMusic, this.transform.position);
        
    }
}


