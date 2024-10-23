using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TeleportPoint : MonoBehaviour
{
    public void Teleport()
    {
        TeleportManager.Instance.Teleport(transform.position);
    }
    public void OnPointerClick()
    {
        Teleport();
    }
}