using UnityEngine;
using System.Collections;

public class MaCoroutineSimple : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Message avant d'exécuter la coroutine");
        // Appel de la coroutine que j'ai defini
        // en-dessous le moment que mon script
        // est activé en scène.
        StartCoroutine("MaCoroutine");

        Debug.Log("Message pendant la pause");
    }

    // Définition d'une coroutine
    public IEnumerator MaCoroutine()
    {
        Debug.Log("Instruction avant la pause");
        // Pour appliquer une pause avec un délai à la coroutine 
        yield return new WaitForSeconds(1f);
        Debug.Log("Instruction après la pause");
    }
}
