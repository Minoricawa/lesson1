using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class: MonoBehaviour {

	// Use this for initialization
	void Start () {

        Color co = new Color();

        co.name = "トマト";
        co.color = "赤";

        Debug.Log(co.name + "は" + co.color);


        Abc a = new Abc();

        Debug.Log(a.abc(co.name,co.color));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}



public class Color
{
    public string name;
    public string color;

}


public class Abc : Color
{
    public string abc(string name, string color)
    {
        return name + " is " + color;
    }
}