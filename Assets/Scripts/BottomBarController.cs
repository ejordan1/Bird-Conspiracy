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

    public void PlayScene(StoryScene scene)
    {
        currentScene = scene;
        sentenceIndex = -1;
        PlayNextSentence();
    }

    // Start is called before the first frame update
    public void PlayNextSentence()
    {
        StartCoroutine(TypeText(currentScene.senteces[++sentenceIndex].text));
        personNameText.text = currentScene.senteces[sentenceIndex].speaker.speakerName;

        // speaker color not working
        //personNameText.color = currentScene.senteces[sentenceIndex].speaker.textColor;
    }

    public bool isCompleted()
    {
        return state == State.COMPLETED;
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
