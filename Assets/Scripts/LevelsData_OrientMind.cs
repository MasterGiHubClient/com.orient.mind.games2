using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "LevelsData", menuName = "ScriptableObjects/LevelsData")]
public class LevelsData_OrientMind : ScriptableObject
{
    //[FormerlySerializedAs("levels_")]
    public Level_OrientMind[] levels_OrientMind;


    public void Method1()
    {
        // Method that does nothing
        Debug.Log("Method1 called");
    }

    public void Method2(int x)
    {
        // Method that takes an integer and does nothing
        Debug.Log("Method2 called with " + x);
    }

    public void Method3(string s)
    {
        // Method that takes a string and does nothing
        Debug.Log("Method3 called with " + s);
    }

    public void Method4(int x, int y)
    {
        // Method that takes two integers and does nothing
        Debug.Log("Method4 called with " + x + " and " + y);
    }

    public void Method5()
    {
        // Method that does nothing and has a delay
        Debug.Log("Method5 called");

    }

    public void Method6(int x, int y, int z)
    {
        // Method that takes three integers and does nothing
        Debug.Log("Method6 called with " + x + ", " + y + ", and " + z);
    }

    public void Method7()
    {
        // Method that does nothing and has a loop
        Debug.Log("Method7 called");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Loop iteration " + i);
        }
    }

    public void Method8(int x, string s)
    {
        // Method that takes an integer and a string and does nothing
        Debug.Log("Method8 called with " + x + " and " + s);
    }

    public void Method9()
    {
        // Method that does nothing and has a recursive call
        Debug.Log("Method9 called");
        Method9();
    }

    public void Method10(int x, int y, string s)
    {
        // Method that takes three parameters and does nothing
        Debug.Log("Method10 called with " + x + ", " + y + ", and " + s);
    }
}

[Serializable]
public class Level_OrientMind
{
    //[FormerlySerializedAs("level")]

    public int level_OrientMind;
    //[FormerlySerializedAs("spritesLevel")]

    public Sprite[] spritesLevel_OrientMind;

    public CellToReach[] cellToReach_OrientMind;

    private string[] charName;
    private string[] charDescription;
    private string[] charSin;
    private Sprite[] charIcon;
}
[Serializable]
public class CellToReach
{
    public Sprite sprite_OrientMind;
    public int count_OrientMind;

    private string[] charName;
    private string[] charDescription;
    private string[] charSin;
    private Sprite[] charIcon;
}
