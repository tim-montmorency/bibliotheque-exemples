using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonScriptExemple : MonoBehaviour
{
    // Ce m�thode va �tre disponible sur la boite 
    // d'�v�nement parce qu'il est publique
    public void MonMethodeExemple()
    {
        Debug.Log("La m�thode exemple a execut�.");
    }
}
