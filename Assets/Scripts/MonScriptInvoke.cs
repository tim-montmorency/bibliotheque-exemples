using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonScriptInvoke : MonoBehaviour
{
    void Start()
    {
        // Ex�cution initiale apr�s 3s seulement
        Invoke("MonMethodeExemple", 3f);

        // Ex�cution initiale apr�s 5s et rep�titions � chaque 10s
        InvokeRepeating("MonMethodeExempleRepetee", 5f, 10f);

        // La m�thode en dessous cancelle tous les 
        // ex�cutions faites avec Invoke() ou InvokeRepeating()
        // CancelInvoke();
    }

    void MonMethodeExemple()
    {
        Debug.Log("Juste une m�thode exemple.");
    }

    void MonMethodeExempleRepetee()
    {
        Debug.Log("Juste une m�thode exemple repet�e.");
    }
}
