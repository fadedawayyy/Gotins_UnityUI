using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChangeScript : MonoBehaviour
{
    public GameObject imageField;
    public Text descriptionText;
    public Sprite[] soriteArray;
    public string[] descriptions;
    public GameObject GrowthSlider;
    public GameObject WidthSlider;

    public void ChangeGrowth()
    {
        float currentGrowth = GrowthSlider.GetComponent<Slider>().value;
        Vector3 scale = imageField.transform.localScale;
        scale.y = currentGrowth;
        imageField.transform.localScale = scale;
    }

    public void ChangeWidth()
    {
        float currentWidth = WidthSlider.GetComponent<Slider>().value;
        Vector3 scale = imageField.transform.localScale;
        scale.x = currentWidth;
        imageField.transform.localScale = scale;
    }

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
