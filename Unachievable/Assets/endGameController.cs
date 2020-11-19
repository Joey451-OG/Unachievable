using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGameController : MonoBehaviour
{
    [SerializeField] private textScript textScript;
    private void Start()
    {
        textScript.value = 0;
        textScript.Write();
    }
}
