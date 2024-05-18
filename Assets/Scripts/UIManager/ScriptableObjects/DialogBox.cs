using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogBox", menuName = "ScriptableObjects/Dialog", order = 1)]
public class DialogBox : ScriptableObject
{
    public List<DialogType> DialogTypes;
}
