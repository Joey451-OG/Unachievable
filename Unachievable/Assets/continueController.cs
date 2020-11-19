using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continueController : MonoBehaviour
{
    public string input;
    void Update()
    {
        if (Input.GetButtonDown(input))
        {
            this.gameObject.SetActive(false);
        }
    }
}
