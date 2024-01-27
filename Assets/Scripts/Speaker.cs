using UnityEngine;

[CreateAssetMenu(fileName ="NewSpeaker", menuName = "Data/New Speaker")]
[System.Serializable]

public class Speaker : ScriptableObject
{
    // Start is called before the first frame update
    public string speakerName;
    public Color textColor;
}
