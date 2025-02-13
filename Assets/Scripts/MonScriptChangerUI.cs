using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MonScriptChangerUI : MonoBehaviour
{
    // Cettes variables vont être configurées
    // au Inspector
    public TextMeshProUGUI textChrono;
    public Slider sliderOnde;
    public Image imageAlternance;

    void Update()
    {
        // Montrer le temps depuis démarrage comme text
        textChrono.text = Time.time.ToString("00.0");

        // Montrer le valuer d'une onde avec un slider
        sliderOnde.value = Mathf.Sin(Time.time) * 0.5f + 0.5f;

        // Changer la propriété color de l'Image pour donner un tint
        // à partir du valeur du slider
        if(sliderOnde.value < 0.5f )
        {
            imageAlternance.color = Color.red;
        }
        else
        {
            imageAlternance.color = Color.blue;
        }
    }
}
