using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class atras : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int name=0;
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(name);

    }
 
}
