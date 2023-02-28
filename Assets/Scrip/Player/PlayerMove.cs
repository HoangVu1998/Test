using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    // Transform c?a ??i t??ng c?n xoay
    private Transform transform;
    public Text printRotation;
    // G�c xoay theo tr?c Y
    private float rotationY;

    private void Start()
    {
        // L?y tham chi?u ??n Transform c?a ??i t??ng
        transform = GetComponent<Transform>();
    }

    private void Update()
    {
        // L?y g�c xoay theo tr?c Z c?a ?i?n tho?i
        float rotationZ = Input.acceleration.z;

        // Chuy?n ??i g�c xoay theo tr?c Z sang tr?c Y
        rotationY = rotationZ * 90;

        // Thay ??i g�c xoay c?a ??i t??ng
        transform.rotation = Quaternion.Euler(0, rotationY, 0);
        printRotation.text = rotationY.ToString();
    }
}
