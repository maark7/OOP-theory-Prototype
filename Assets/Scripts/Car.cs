using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Car : Vehicles
{
    public TextMeshProUGUI nameText;

    public override void Name()
    {
        names = "Car";
        nameText.SetText($"Name : {names}");
    }

    public override void features()
    {
        tyres = 4;
        Debug.Log(tyres);
    }
}
