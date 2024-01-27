using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BottomBarController : MonoBehaviour
{

    public TextMeshProUGUI barText;
    public TextMeshProUGUI personNameText;

    public StoryScene currentScene;
    private int sentenceIndex = -1; // because it adds at the beginning to 0
    private State state = State.COMPLETED;

    private enum State
    {
        PLAYING, COMPLETED
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TypeText(currentScene.senteces[++sentenceIndex].text));
    }


    private IEnumerator TypeText(string text)
    {
        barText.text = "";
        state = State.PLAYING;
        int wordIndex = 0;
        while(state != State.COMPLETED){
            barText.text += text[wordIndex];
            yield return new WaitForSeconds(0.05f);
            if (++wordIndex == text.Length)
            {
                state = State.COMPLETED;
                break;
            }
        }
    }

}
