using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lovycha : MonoBehaviour





{
    
    public InfoPlayer
            infoPlayer;

    
    private void OnTriggerEnter(Collider other)
 {
    if (other.gameObject.CompareTag("Player")){
      int value = 25;
      infoPlayer.HP -- value;
      if(infoPlayer.HP == 0)
         {
            SceneManager.LoadScene("LevelTst");
         }
    
    }
    
    

 }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
