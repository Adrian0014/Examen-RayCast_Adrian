using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rayo : MonoBehaviour
{
    private Transform cam;
    private float currentVelocity;
   
    [SerializeField]private LayerMask groundLayer;
    
    [SerializeField]private LayerMask ignoreLayer;
    [SerializeField]Text contadorText;
    int contador = 5;
    

    // Start is called before the first frame update
    void Awake()
    {
        
        cam = Camera.main.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
       

        if(Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayHit;

            if(Physics.Raycast(ray, out rayHit))
            {
                Debug.Log(rayHit.transform.name);

                if(rayHit.transform.name == "Sphere")
                {
                    Invoke("LoadEsfera", 5);
                    Invoke("Contador", 1);
                }
                if(rayHit.transform.name == "Cube1")
                {
                    Invoke("LoadCube1", 5);
                    Invoke("Contador", 1);
                }
                if(rayHit.transform.name == "Cube2")
                {
                    Invoke("LoadCube2", 5);
                    Invoke("Contador", 1);
                }
                
            }
            
            
        }
        
        
    }
    public void LoadEsfera()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadCube1()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadCube2()
    {
        SceneManager.LoadScene(2);
    }

    public void Contador()
    {
        contador--;
        contadorText.text = contador.ToString();
        Invoke("Contador2", 1);
    }
    public void Contador2()
    {
        contador--;
        contadorText.text = contador.ToString();
        Invoke("Contador3", 1);
    }
    public void Contador3()
    {
        contador--;
        contadorText.text = contador.ToString();
        Invoke("Contador4", 1);
    }
    public void Contador4()
    {
        contador--;
        contadorText.text = contador.ToString();
       
    }

        
}
