using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selects : MonoBehaviour
{
    public GameObject te;
    
    //For multiple choice
    public void Mostrar(string[] message){
        te.GetComponent<UnityEngine.UI.Text>().text = string.Join(" - ",message);
    }
    //for data and time
    public void mostrar(string message){
        te.GetComponent<UnityEngine.UI.Text>().text = message;
    }
}
