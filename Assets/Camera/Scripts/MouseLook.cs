 using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class MouseLook : MonoBehaviour
{
    public Transform player;

    void Update() {
        transform.position = player.transform.position;
    }
}
