using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonScriptInvoke : MonoBehaviour
{
    void Start()
    {
        // Exécution initiale après 3s seulement
        Invoke("MonMethodeExemple", 3f);

        // Exécution initiale après 5s et repétitions à chaque 10s
        InvokeRepeating("MonMethodeExempleRepetee", 5f, 10f);

        // La méthode en dessous cancelle tous les 
        // exécutions faites avec Invoke() ou InvokeRepeating()
        // CancelInvoke();
    }

    void MonMethodeExemple()
    {
        Debug.Log("Juste une méthode exemple.");
    }

    void MonMethodeExempleRepetee()
    {
        Debug.Log("Juste une méthode exemple repetée.");
    }
}
