using UnityEngine;
using System.Collections;

public class MaCoroutineSimple : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Message avant d'ex�cuter la coroutine");
        // Appel de la coroutine que j'ai defini
        // en-dessous le moment que mon script
        // est activ� en sc�ne.
        StartCoroutine("MaCoroutine");

        Debug.Log("Message pendant la pause");
    }

    // D�finition d'une coroutine
    public IEnumerator MaCoroutine()
    {
        Debug.Log("Instruction avant la pause");
        // Pour appliquer une pause avec un d�lai � la coroutine 
        yield return new WaitForSeconds(1f);
        Debug.Log("Instruction apr�s la pause");
    }
}
