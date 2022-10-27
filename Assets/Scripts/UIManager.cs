using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;


public class UIManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake() 
    {
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("MainScene");
    }
    
}