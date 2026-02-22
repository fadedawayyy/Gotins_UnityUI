using UnityEngine;
using UnityEngine.UI;
using System;

public class TextScript : MonoBehaviour
{
    public InputField nameInputField;
    public InputField yearInputField;
    public Text resultText;

    public void ShowResult()
    {
        string name = nameInputField.text;
        string yearText = yearInputField.text;

        if (System.Text.RegularExpressions.Regex.IsMatch(name, @"\d"))
        {
            resultText.text = "Vārds nedrīkst saturēt ciparus!";
            return;
        }
        if (int.TryParse(yearText, out int birthYear))
        {
            if (birthYear < 1960 || birthYear>2025)
            {
                resultText.text = "Dzimšanas gads nedrīkst būt mazāks par 1960 un vairak par 2025!";
                return;
            }

            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            resultText.text = $"Raktuves meistars {name} jau {age} gadus ceļ un izdzīvo Minecraft pasaulē!";
        }
        else
        {
            resultText.text = "Lūdzu, ievadiet pareizu dzimšanas gadu (skaitli).";
        }
    }
}
