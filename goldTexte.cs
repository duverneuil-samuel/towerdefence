using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;//on en a besoin pour l'ui

public class goldTexte : MonoBehaviour
{
    #region Exposed
    public float m_startgold;//gold de d�part qu'on va d�finir sur chaque sc�ne 
    [SerializeField]
    private floatgold _goldValue;//on va chercher le ScriptableObject

    [SerializeField]
    private TextMeshProUGUI _goldlabel;// on va chercher le texte qu'on affiche
    #endregion

    #region Unity API
    void Start()
    {
        m_startgold = 500;//on d�fini les gold de d�part
         _goldValue.m_value = m_startgold;//on dit que la valeur du ScriptableObject au start est�egal au gold de d�part
    }
    void Update()
    {
        if (_goldValue != null)//si la valeur de gold n'est pas null 
        {
            _goldlabel.text = _goldValue.m_value.ToString() + " pi�ces d'or";//on affiche la quantit� de gold avec le message
        }
    }
    #endregion
}
