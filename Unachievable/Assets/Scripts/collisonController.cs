using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisonController : MonoBehaviour
{
    public int sayingNumber;

    [SerializeField] private textScript textScript;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        textScript.value = sayingNumber;
        textScript.Write();
    }
}
