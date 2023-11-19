using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//on en a besoin pour l'ui

public class goldTexte : MonoBehaviour
{
    #region Exposed
    public float m_startgold;//gold de départ qu'on va définir sur chaque scène 
    [SerializeField]
    private floatgold _goldValue;//on va chercher le ScriptableObject

    [SerializeField]
    private TextMeshProUGUI _goldlabel;// on va chercher le texte qu'on affiche
    #endregion

    #region Unity API
    void Start()
    {
        m_startgold = 500;//on défini les gold de départ
         _goldValue.m_value = m_startgold;//on dit que la valeur du ScriptableObject au start estéegal au gold de départ
    }
    void Update()
    {
        if (_goldValue != null)//si la valeur de gold n'est pas null 
        {
            _goldlabel.text = _goldValue.m_value.ToString() + " pièces d'or";//on affiche la quantité de gold avec le message
        }
    }
    #endregion
}
