using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogBox : MonoBehaviour
{
    public Text dialogText;

    public void setDialogText(string text)
    {
        //TODO: formatting, resizing? min/max size?
        dialogText.text = text;
        gameObject.SetActive(true);
    }
}
