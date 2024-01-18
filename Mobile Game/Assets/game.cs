using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class game : MonoBehaviour
{
    public Text ui;
    public void increment()
    {
        GameManager.o2 += GameManager.multiplier;
        PlayerPrefs.SetInt("o2", GameManager.o2);
    }

    public void Buy(int num)
    {
        if (num == 1 && GameManager.o2 >= 25)
        {
            GameManager.multiplier += 1;
            GameManager.o2 -= 25;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 2 && GameManager.o2 >= 125)
        {
            GameManager.multiplier += 10;
            GameManager.o2 -= 125;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 3 && GameManager.o2 >= 1500)
        {
            GameManager.multiplier += 100;
            GameManager.o2 -= 1500;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
    }

    private void Update()
    {
        ui.text = "O2: " + GameManager.o2;
    }
}
