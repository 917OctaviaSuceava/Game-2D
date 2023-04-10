using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField]
    private GameObject menu;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void OnSinglePlayer()
    {
        SceneManager.LoadScene("SampleScene");
        menu.SetActive(false);
    }

    public void OnMultiPlayer()
    {
        SceneManager.LoadScene("MultiPlayerScene");
        menu.SetActive(false);
    }
}
