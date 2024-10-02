using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* using TMPro; */

public class DialogPlanet : MonoBehaviour
{
	public string text;
    //public TextMeshProUGUI //;
    
	public GameObject dialogBubble;

    void Start()
    {
		//dialogText.text = text;
        OnPointerExit();
    }

    public void OnPointerEnter()
    {
        dialogBubble.SetActive(true);
        Debug.Log("on point enter ---- ");
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        dialogBubble.SetActive(false);
        Debug.Log("on point exit  -----");
    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClick()
    {
        Debug.Log("on point click ---- ");
    }
}
