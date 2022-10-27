using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;

public class LifeManager : MonoBehaviour
{
    public Text life_Text;

    public int life = 3;
    // Start is called before the first frame update
    void Awake() {
        DontDestroyOnLoad(gameObject);  
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life_Text.text = ":" + life.ToString();
    }

    public void Dead()
    {
        if (life <= 0)
        {
            SceneManager.LoadScene("StartScene");
        }
        else
        {
            life--;
        }
    }
}
