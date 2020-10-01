using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : MonoBehaviour
{

    [SerializeField]
    GameObject Text;
    private void OnTriggerEnter(Collider other)
    {
        Text.SetActive(true);
        Debug.Log("Win");
    }

    private void OnTriggerExit(Collider other)
    {
        Text.SetActive(false);
    }
}
