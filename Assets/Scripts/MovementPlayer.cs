using Codice.CM.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public Transform playerMovement;

    bool keepMovement = false;

    private void Update()
    {
        if (keepMovement )
        {
            playerMovement.position = transform.position + new Vector3(-4, 1, 0);
        }
    }

    public void OnPointerEnter()
    {
        if (!keepMovement)
        {
            keepMovement = true;
        }
    }

    public void OnPointerExit()
    {

    }

    public void OnPointerClick()
    {
    }
}
