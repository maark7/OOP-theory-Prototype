using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Car : Vehicles
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI tyresText;

    public override void Name()
    {
        names = "Car";
        nameText.SetText($"Name : {names}");
    }

    public override void features()
    {
        tyres = 4;
        tyresText.SetText($"Tyres : {tyres}");
    }
}
