using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textA : MonoBehaviour
{
   private TextMeshPro text;
   private string textToWrite;
   private float timePerCharacter;
   private int characterIndex;
   private float timer;
    public static bool isTyping;
    


   public void AddWriter(TextMeshPro text, string textToWrite, float timePerChararcter)
    {
        this.text = text;
        this.textToWrite = textToWrite;
        this.timePerCharacter = timePerChararcter;
        characterIndex = 0;

    }
    private void Update()
    {
        if(text != null)
        {
            isTyping = true;
            timer -= Time.deltaTime;
            while (timer <= 0f){
                timer += timePerCharacter;
                characterIndex++;
                text.text = textToWrite.Substring(0, characterIndex);
                if(characterIndex >= textToWrite.Length)
                {
                    text = null;
                    isTyping = false;
                    return;
                }
            }
        }
    }
}
