using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ColorRandomChange", menuName = "ScriptableObject/ColorRandomChange", order = 0)]
public class ColorRandomChange : ScriptableObject
{
    [SerializeField] private Material objectMaterial;
    [SerializeField] private Color[] colorArray;

    private int correctColorIndex;

    public void SetRandomColor()
    {
        correctColorIndex = Random.Range(0, colorArray.Length);
        objectMaterial.color = colorArray[correctColorIndex];
    }

    public bool CheckColor(int selectedIndex)
    {
        return selectedIndex == correctColorIndex;
    }
}