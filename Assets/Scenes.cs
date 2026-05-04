using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    void Update()
{
         if(Input.GetKeyDown(KeyCode.Space)) 
    {   
        SceneManager.LoadScene("LevelTst");
    }
}
   
}



