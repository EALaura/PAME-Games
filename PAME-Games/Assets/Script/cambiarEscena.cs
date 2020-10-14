using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarEscena : MonoBehaviour
{
    // Start is called before the first frame update
    
     public void CambiarEscena(string nombre){
        print("cambiaste a la escena"+nombre);
        SceneManager.LoadScene(nombre);
    }
}
