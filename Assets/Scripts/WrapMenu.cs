using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrapMenu : MonoBehaviour
{
    public RectTransform Panel;

    public RectTransform button;

    bool wrap = false;

    public void OnMouseDown()
    {
        if (!wrap) {

            Panel.LeanMove(new Vector3(-107, -198, 0), 0.7f);

            button.LeanMove(new Vector3(14, -22, 0), 0.7f);
            wrap = true;
        }

        else
        {
            button.LeanMove(new Vector3(221, -22, 0), 0.7f);

            Panel.LeanMove(new Vector3(107, -198, 0), 0.7f);

            wrap = false;
        }
    }
}
