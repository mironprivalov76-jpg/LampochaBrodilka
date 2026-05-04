using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healt : MonoBehaviour
{
    
    [SerializeField] Text healttext;
    int xp =50;

    public GameObject myObject;
     

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("frag"))
        {
            xp --;
             healttext.text = "xp :  " + xp;
             print(xp);
             if(xp == 0)
            {
                myObject.SetActive(true);
            }

            
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        healttext.text = "xp :  " + xp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
    
     
