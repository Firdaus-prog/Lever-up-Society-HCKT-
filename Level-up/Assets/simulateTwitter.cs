using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class simulateTwitter : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            goToTwitter();
        }
    }
    public void goToTwitter()
    {
        SceneManager.LoadScene(4);
    }
}
