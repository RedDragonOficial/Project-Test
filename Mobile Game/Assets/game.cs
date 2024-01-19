using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class game : MonoBehaviour
{
    public Text ui;
    public void increment()
    {
        GameManager.Money += GameManager.multiplier;
        PlayerPrefs.SetInt("$", GameManager.Money);
    }

    public void Buy(int num)
    {
        if (num == 1 && GameManager.Money >= 25)
        {
            GameManager.multiplier += 1;
            GameManager.Money -= 25;
            PlayerPrefs.SetInt("$", GameManager.Money);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 2 && GameManager.Money >= 125)
        {
            GameManager.multiplier += 10;
            GameManager.Money -= 125;
            PlayerPrefs.SetInt("$", GameManager.Money);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 3 && GameManager.Money >= 1500)
        {
            GameManager.multiplier += 100;
            GameManager.Money -= 1500;
            PlayerPrefs.SetInt("$", GameManager.Money);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
    }

    private void Update()
    {
        ui.text = "$: " + GameManager.Money;
    }
}
