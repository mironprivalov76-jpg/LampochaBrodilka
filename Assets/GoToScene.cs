using UnityEngine; 
using UnityEngine.SceneManagement; 

public class GoToScene : MonoBehaviour 
{ 
    public string sceneName; 

    public void ChangeScene() 
    { 
        SceneManager.LoadScene(sceneName); 
    } 
} 