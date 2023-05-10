using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVisiblePercentScript : MonoBehaviour
{
    bool isDown;

    public Material materialOn;

    public Material materialOf;

    public SelectToggle selectToggle;

    void Start()
    {
        isDown = false;
    }

    public void OnMouseDown()
    {
        var rens = selectToggle.GetRenderers();

        if (!isDown)
        {
            foreach (var render in rens) 
                render.sharedMaterial = materialOn;      
            isDown = true;
        }
        else
        {
            foreach (var render in rens)
                render.sharedMaterial = materialOf;

            isDown = false;
        }

        selectToggle.SetCurrentMaterial(materialOn);
    }
}
