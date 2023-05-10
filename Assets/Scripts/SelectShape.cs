using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectShape : MonoBehaviour
{
    public string Name;

    public Material Of, SelectMaterial;

    private bool isSelected;

    Renderer renderer;

    public SelectToggle selectToggle;

    void Start()
    {
        isSelected = false;
        renderer = GetComponent<Renderer>();
    }

    public void SetMaterial()
    {
        SelectMaterial = selectToggle.GetCurrentMaterial();

        var rens = selectToggle.GetRenderers();

        if (!isSelected)
        {
            renderer.sharedMaterial = SelectMaterial;

            isSelected = true;

            rens.Add(renderer);
        }
        else
        {
            renderer.sharedMaterial = Of;

            isSelected = false;

            rens.Remove(renderer);
        }
    }
}
