using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonScriptExemple : MonoBehaviour
{
    // Ce méthode va être disponible sur la boite 
    // d'événement parce qu'il est publique
    public void MonMethodeExemple()
    {
        Debug.Log("La méthode exemple a executé.");
    }
}
