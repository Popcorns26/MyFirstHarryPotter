using UnityEngine;

[CreateAssetMenu(fileName = "NoteInfo", menuName = "ScriptableObjects/NoteInfoScriptableObject", order = 1)]
public class NoteInfo : ScriptableObject
{
    /*
     * Key to play(flute1,flute2,etc)
     * Colour
     * Speed?
     */
    Color color = Color.blue;
}
