using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;


public class UIManager : MonoBehaviour
{
    GameObject button;
    Button quitbutton;

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
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void QuitGame() {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode) {
        if (scene.buildIndex == 1) {
            button = GameObject.FindWithTag("Quit");
            quitbutton = button.GetComponent<Button>();
            quitbutton.onClick.AddListener(QuitGame);
        }
    }
    
}
