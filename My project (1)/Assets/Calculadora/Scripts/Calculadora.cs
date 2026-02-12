using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculadora : MonoBehaviour
{
    public Text resultText;
    public float num1 = 0f;
    public float num2 = 0f;
    public string operation;
    
    public void iAddition()
    {
        num1 = float.Parse(resultText.text);
    }

   
    void Update()
    {
        
    }
}
