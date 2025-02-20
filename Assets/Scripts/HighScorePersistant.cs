using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScorePersistant : MonoBehaviour
{
    // etiquettes UI utilis�s pour montrer 
    // le pointage plus �l�v� et l'actuel
    public TextMeshProUGUI texteHighScore;
    public TextMeshProUGUI textePointage;

    // cl� utilis� pour enregistrer le pointage dans
    // la base du PlayerPrefs
    public string highscoreClef = "HIGHSCORE";

    // variables pour le record et le pointage actuel
    private int _highScoreActuel = 0;
    private int _pointageActuel = 0;

    void Start()
    {
        // initialisation de pointage
        _pointageActuel = 0;
        // chargement du record enregistr� avec la highscoreClef
        // si il n'y a pas de record, la valeur sera 0
        _highScoreActuel = PlayerPrefs.GetInt(highscoreClef, 0);

        // actualise les etiquettes de l'UI
        texteHighScore.text = _highScoreActuel.ToString();
        textePointage.text = _pointageActuel.ToString();
    }

    // cette m�thode est publique, donc elle peut �tre
    // appell� � partir d'autres composantes
    public void OnChangerPointage(int nouvellePointage)
    {
        // changer le pointage actuel
        _pointageActuel = nouvellePointage;

        // si c'est le nouveau record
        if (_pointageActuel > _highScoreActuel)
        {
            _highScoreActuel = _pointageActuel;
            // enregistrement du nouveau record
            PlayerPrefs.SetInt(highscoreClef, _highScoreActuel);
        }

        // actualise les etiquettes de l'
        textePointage.text = _pointageActuel.ToString();
        texteHighScore.text = _highScoreActuel.ToString();
    }
}
