using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class AnimatorBoolEvent : MonoBehaviour
{
    public Animator animator;
    public string boolName = "myBool";

    /// <summary>
    /// Set a Bool value on a registered Animator.
    /// </summary>
    /// <param name="value"></param>
    public void SetBool(bool value)
    {
        animator.SetBool(boolName, value);
    }
}
