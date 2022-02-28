using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Animation : MonoBehaviour
{
    public static bool playAnimation = false;
    public Animator anim;
    private void Update()
    {
        PlayerAnimation();    
    }
    void PlayerAnimation()
    { 
        if(playAnimation == true)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }


}
