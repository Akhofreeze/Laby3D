using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{

    [SerializeField]
    GameObject Text;

    [SerializeField]
    Animator MyAnimator;

    [SerializeField]
    Animator MyAnimatorLever;

    [SerializeField]
    GameObject Door;

    [SerializeField]
    bool doorStatus = false;
    private void OnTriggerEnter(Collider other)
    {
        Text.SetActive(true);

        Debug.Log("Win");
    }

    private void OnTriggerExit(Collider other)
    {
        Text.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("OpenTheDoor");
            doorStatus = true;
            MyAnimator.enabled = true;
            MyAnimatorLever.enabled = true;
        }
    }
}
