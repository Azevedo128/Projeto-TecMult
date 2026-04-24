using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;
public class CollisionDetectEasy : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject PlayerAnim;
    [SerializeField] AudioSource CollisionFX;
    [SerializeField] GameObject MainCamera;
    [SerializeField] GameObject FadeOut;
    void OnTriggerEnter(Collider other)
    
    {
        if (other.CompareTag("Coin"))
    {
        return; 
    }else
       StartCoroutine(CollisionEnd());
    }

    

    IEnumerator CollisionEnd()
    {
        CollisionFX.Play();
        thePlayer.GetComponent<PlayerMovementEasy>().enabled=false;
        PlayerAnim.GetComponent<Animator>().Play("Stumble Backwards");
        MainCamera.GetComponent<Animator>().Play("CollisionCam");
        yield return new WaitForSeconds(2);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        MasterInfo.FinalCoins = MasterInfo.CoinCount;
        MasterInfo.FinalDistance = MasterInfo.DistanceRun;
        //MasterInfo.CoinCount = 0;
        SceneManager.LoadScene(7);
    }
}

