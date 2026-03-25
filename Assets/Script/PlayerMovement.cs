using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerSpeed = 2;
    public float horizontalSpeed = 3;
    public float rightBorder = 8.5f;
    public float leftBorder = -8.5f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * PlayerSpeed, Space.Self);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > leftBorder)
            {
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < rightBorder)
            {
                transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed);
            }
        }
    }
}
