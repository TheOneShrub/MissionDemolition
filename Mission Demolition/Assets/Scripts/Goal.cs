using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Renderer))]

public class Goal : MonoBehaviour
{
    static public bool goalMet = false; 

    void OnTriggerEnter(Collider other) {
       // SceneManager.LoadScene(1);
        Projectile proj = other.GetComponent<Projectile>();
        if(proj != null)
        {
            Goal.goalMet = true;
            SceneManager.LoadScene(1);
           // print("HELP");
            Material mat = GetComponent<Renderer>().material;
            Color c = mat.color;
            c.a = 0.75f;
            mat.color = c;
        }
    }
    // Start is called before the first frame update
    
}
