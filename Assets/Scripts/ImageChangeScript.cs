using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChangeScript : MonoBehaviour
{
    public GameObject imageField;
    public Text descriptionText; // Add reference to Text UI component
    public Sprite[] soriteArray;
    public string[] descriptions; // Add array for descriptions

    public void Dropdown(int index)
    {
        if(index == 0) {
            imageField.GetComponent<Image>().sprite = soriteArray[0];
            descriptionText.text = descriptions[0];
        }
        else if (index == 1) {
            imageField.GetComponent<Image>().sprite = soriteArray[1];
            descriptionText.text = descriptions[1];
        }
        else if (index == 2) {
            imageField.GetComponent<Image>().sprite = soriteArray[2];
            descriptionText.text = descriptions[2];
        }
    }
}
