using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSettings : MonoBehaviour
{

    public Animator settingAnimator;

    public bool slideIn = false;

    public void settingBtnMethod()
    {
        if (slideIn == false)
        {
            slideIn = true;
            settingAnimator.SetBool("SlideIn",slideIn);
        }
        else if (slideIn == true)
        {
            slideIn = false;
            settingAnimator.SetBool("SlideIn",slideIn);
        }
    }

    


}
