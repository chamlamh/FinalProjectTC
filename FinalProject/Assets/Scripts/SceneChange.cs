using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DOVirtual.DelayedCall(3, GotoNextScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }void GotoNextScene()
    {
        SceneManager.LoadScene("MainLobby");
    }
}
