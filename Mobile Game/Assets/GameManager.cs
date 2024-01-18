using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int o2;
    public static int multiplier;
    void Start()
    {
        multiplier = PlayerPrefs.GetInt("multiplier", 1);
        o2 = PlayerPrefs.GetInt("o2", 0);

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
