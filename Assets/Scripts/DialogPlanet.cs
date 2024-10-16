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

    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        dialogBubble.SetActive(false);
    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClick()
    {
       
    }
}
