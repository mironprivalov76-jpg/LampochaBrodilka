using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnCollisionEnter : MonoBehaviour





{
    
    [SerializeField] Text ochitext;
     
    int ochi = 0;
    private void OnTriggerEnter(Collider other)
 {
   
    ochi ++;
    ochitext.text = "цель собрать 1 монеток собрано :" + ochi ;
    if(ochi == 1)
    {
     SceneManager.LoadScene("menu 1");
    print(ochi);
    Destroy(gameObject);
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
