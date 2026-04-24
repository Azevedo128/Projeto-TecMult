using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuControlMedium : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        MasterInfo.CoinCount = 0;
        MasterInfo.DistanceRun=0;
    }
}
