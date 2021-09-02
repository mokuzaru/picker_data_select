using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selects : MonoBehaviour
{
    public GameObject te;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mostrar(string message){
        te.GetComponent<UnityEngine.UI.Text>().text = message;
    }
}
