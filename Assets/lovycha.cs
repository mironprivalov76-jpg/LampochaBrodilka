using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healt : MonoBehaviour
{
    
    [SerializeField] Text healttext;
    int xp =5;
     

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            xp --;
             healttext.text = "xp :  " + xp;
             print(xp);
             if(xp == 0)
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
    
     
