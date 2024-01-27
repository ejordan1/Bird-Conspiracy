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
    private Animator animator;
    private bool isHidden = false;

    private enum State
    {
        PLAYING, COMPLETED
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Hide()
    {
        if (!isHidden)
        {
            animator.SetTrigger("Hide");
            isHidden = true;
        }
    }

    public void Show()
    {
        if (isHidden)
        {
            animator.SetTrigger("Show");
            isHidden = false;
        }
    }

    public void ClearText()
    {
        barText.text = "";

        // I added this
        personNameText.text = "";
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
        ActSpeakers();

        // speaker color not working
        //personNameText.color = currentScene.senteces[sentenceIndex].speaker.textColor;
    }

    public bool isCompleted()
    {
        return state == State.COMPLETED;
    }

    public bool IsLastSentence()
    {
        return sentenceIndex + 1 == currentScene.senteces.Count;
    }


    private IEnumerator TypeText(string text)
    {
        barText.text = "";
        state = State.PLAYING;
        int wordIndex = 0;
        while (state != State.COMPLETED)
        {
            barText.text += text[wordIndex];
            yield return new WaitForSeconds(0.05f);
            if (++wordIndex == text.Length)
            {
                state = State.COMPLETED;
                break;
            }
        }
    }

    private void ActSpeakers()
    {
        List<StoryScene.Sentence.Action> actions = currentScene.senteces[sentenceIndex].actions;
        for (int i = 0; i < actions.Count; i++)
        {
            ActSpeaker(actions[i]);
        }
    }

    private void ActSpeaker(StoryScene.Sentence.Action action)
    {
        
    }

}
