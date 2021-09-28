using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Vehicles : MonoBehaviour
{
    public string names{get; set; }
    public int tyres{get; set; }

    

    public virtual void Name()
    {
        
    } 

    public virtual void features()
    {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Name();

        features();
    }

    
}
