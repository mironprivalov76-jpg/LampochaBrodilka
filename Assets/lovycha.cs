using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Healt : MonoBehaviour
{
    public GameObject targetObject;
    [SerializeField] Text healttext;
    int xp =50;
     

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("frag"))
        {
            xp --;
             healttext.text = "xp :  " + xp;
             print(xp);
             if(xp == 0)
            {
                targetObject.SetActive(true);
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
    
     
