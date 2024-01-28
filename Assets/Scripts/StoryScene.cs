
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu(fileName = "NewStoryScene", menuName ="Data/New Story Scene")]
[System.Serializable]

public class StoryScene : ScriptableObject
{
    public List<Sentence> senteces;
    // Start is called before the first frame update
    public Sprite background;
    //public StoryScene nextScene;
    public string nextSceneString;

    [System.Serializable]
    public struct Sentence
    {
        public string text;
        public Speaker speaker;
        public List <Action> actions;

        [System.Serializable]
        public struct Action 
        {

                public Speaker speaker;
                public int spriteIndex;
                public Type actionType;
                public Vector2 coords;
                public float moveSpeed;
                [System.Serializable]
                public enum Type {
                    NONE, APPEAR, MOVE, DISAPPEAR
                }
        }
    }
}
