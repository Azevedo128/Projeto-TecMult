using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject PlayerAnim;
    [SerializeField] AudioSource CollisionFX;
    [SerializeField] GameObject MainCamera;
    [SerializeField] GameObject FadeOut;
    void OnTriggerEnter(Collider other)
    {
       StartCoroutine(CollisionEnd());
    }

    IEnumerator CollisionEnd()
    {
        CollisionFX.Play();
        thePlayer.GetComponent<PlayerMovement>().enabled=false;
        PlayerAnim.GetComponent<Animator>().Play("Stumble Backwards");
        MainCamera.GetComponent<Animator>().Play("CollisionCam");
        yield return new WaitForSeconds(2);
        FadeOut.SetActive(true);
    }
}

