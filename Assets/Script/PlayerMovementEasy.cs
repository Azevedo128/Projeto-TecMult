using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEasy : MonoBehaviour
{
    public float PlayerSpeed = 4;
    public float horizontalSpeed = 6;
    public float rightBorder = 12.5f;
    public float leftBorder = -12.5f;
    [SerializeField] bool isRunning;

    void Update()
    {
        if(isRunning == false)
        {
            isRunning= true;
            StartCoroutine(AddDistance());
        }
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
    IEnumerator AddDistance()
    {
        yield return new WaitForSeconds(0.98f);
        MasterInfo.DistanceRun +=1;
        isRunning=false;
    }
}
