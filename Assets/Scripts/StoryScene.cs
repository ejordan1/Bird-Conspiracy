
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewStoryScene", menuName ="Data/New Story Scene")]
[System.Serializable]

public class StoryScene : ScriptableObject
{
    public List<Sentence> senteces;
    // Start is called before the first frame update
    public Sprite background;
    public StoryScene nextScene;

    [System.Serializable]
    public struct Sentence
    {
        public string text;
        public Speaker speaker;
    }
}
