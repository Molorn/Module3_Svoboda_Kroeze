using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class SendingNumbers : MonoBehaviour
{
    [Space(10)]
    [Header("Toggle for the gui on off")]
    public bool GuiOn;
    public bool gateOpen;

    [Space(10)]
    [Header("The text to Display on Trigger")]
    [Tooltip("To edit the look of the text go to Assets > Create > GUIskin. Add the new GUIskin to the Custom Skin property. If you select the GUIskin in your project tab you can now adjust the Label section to change this text")]
    string Text;

    [Tooltip("This is the window box's size. It will be mid screen. Add or reduce the X and Y to move the box in Pixels.")]
    public Rect BoxSize = new Rect(0, 0, 200, 100);

    [Space(10)]
    [Tooltip("To edit the look of the text go to Assets > Create > GUIskin. Add the new GUIskin to the Custom Skin property. If you select the GUIskin in your project tab you can now adjust the font, color, size etc of the text")]
    public GUISkin customSkin;

    void Start()
    {
        Text = gameObject.tag;
    }

    private void OnTriggerEnter()
    {
        GuiOn = true;
    }

    private void OnTriggerExit()
    {
        GuiOn = false;
    }

    void OnGUI()
    {
        if (customSkin != null)
        {
            GUI.skin = customSkin;
        }

        if (GuiOn == true)
        {
            //Make a group on the center of the screen
            GUI.BeginGroup (new Rect((Screen.width - BoxSize.width) / 2, (Screen.height - BoxSize.height) / 2, BoxSize.width, BoxSize.height));
            //All rectangles are now adjusted to the group. (0, 0) is the topleft corner of the group.
            GUI.Label(BoxSize, Text);
            //End the group we started above. This is bery important to remember!
            GUI.EndGroup();
        }
    }

}
