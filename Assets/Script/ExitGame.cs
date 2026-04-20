using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Saiu do jogo");

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
            #else
        Application.Quit();
            #endif
    }
}