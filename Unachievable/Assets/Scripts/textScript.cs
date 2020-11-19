using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textScript : MonoBehaviour
{
    [SerializeField] private textA textAnimator;

    public TextMeshPro text;

    public string[] sayings;
   
    private string whatToSay;
    
    public float typeSpeed;

    public int value;

    private void Awake()
    {
        text = FindObjectOfType<TextMeshPro>();
    }
    private void Update()
    {
       

    }
    public void Write()
    {

        whatToSay = sayings[value];

        textAnimator.AddWriter(text, whatToSay, typeSpeed);
    }
}
   
