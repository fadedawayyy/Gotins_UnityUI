using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChangeScript : MonoBehaviour
{
    public GameObject LeatherHelmet;
    public GameObject LeatherChestplate;
    public GameObject LeatherLeggins;
    public GameObject LeatherBoots;
    public GameObject IronHelmet;
    public GameObject IronChestplate;
    public GameObject IronLeggins;
    public GameObject IronBoots;
    public GameObject GoldHelmet;
    public GameObject GoldChestplate;
    public GameObject GoldLeggins;
    public GameObject GoldBoots;
    public GameObject DiamondHelmet;
    public GameObject DiamondChestplate;
    public GameObject DiamondLeggins;
    public GameObject DiamondBoots;
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
    
    public void ToggleLeather(bool value)
    {
        LeatherHelmet.SetActive(value);
        LeatherChestplate.SetActive(value);
        LeatherLeggins.SetActive(value);
        LeatherBoots.SetActive(value);

    }
    public void ToggleIron(bool value)
    {
        IronHelmet.SetActive(value);
        IronChestplate.SetActive(value);
        IronLeggins.SetActive(value);
        IronBoots.SetActive(value);

    }
    public void ToggleGold(bool value)
    {
        GoldHelmet.SetActive(value);
        GoldChestplate.SetActive(value);
        GoldLeggins.SetActive(value);
        GoldBoots.SetActive(value);

    }
    public void ToggleDiamond(bool value)
    {
        DiamondHelmet.SetActive(value);
        DiamondChestplate.SetActive(value);
        DiamondLeggins.SetActive(value);
        DiamondBoots.SetActive(value);

    }
}
