using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenucontroller : MonoBehaviour
{
    public void LoadLevel(string levelName)
    {
        GameManager.instance.LoadScene(levelName);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
