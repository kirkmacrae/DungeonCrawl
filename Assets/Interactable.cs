using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string dialog;
    public DialogBox dialogBox;
     
    public void interact()
    {
        if (dialog.Length >0)
        {
            dialogBox.setDialogText(dialog);
        }

        if (GetComponent<LootDrop>())
        {
            print("I have loot");
        }
    }
}
