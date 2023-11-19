using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHP : MonoBehaviour
{
    #region Exposed
    public float _enemyHP; //pv du mob
    public bool _récolte; //bool qui di si on crée une spark en mouran ou non
    public Element m_faiblesse; //on definit le type dans l'inspecteur 
    public Element m_resistance;//on definit le type dans l'inspecteur
    public bool m_gold = true;// variable qui va nous servire a definir si on gagne des gold a la mort
    public int m_enemyforce;
    public WayCollect _mana;

    [SerializeField]
    private floatgold _goldValue;//la quantité de gold
    
    [SerializeField]
    private GameObject _ManaSpark;//game object generé ala mort si recolte est true

    [SerializeField]
    private WLvalue _WL;

    [SerializeField]
    private intHpNexus _hpnexus;
    #endregion


    #region Unity API
    private void Start()
    {
        m_enemyforce = 1;
        _Nexus = GameObject.Find("nexus"); //on recume le game object nexus
        GameObject jesaispas = GameObject.Find("speed/pause");
    }
    void Update()
    {   // ******************************** PARTIE QUI  PERMET DE GAGNE DES GOLD*****************//
        if(_enemyHP <= 0)//on vérifie que l'ennemi a 0 hp ou moins
        {
            _WL.m_enemysvalue--;
            Destroy(gameObject);//Si l'ennemi a 0 hp ou moins on le détruit
            if (m_gold == true)//On vérifie l'état du bool a la mort
            {
                _goldValue.m_value += 50;//si il est true on incrémente 50 gold a la mort
            }
        //*******************************LE RESTE  NA PAS DE RAPPORT AVEC LES GOLD *******************//


            if(_récolte == true && _secu==false)//si recolt est true
            {
                _récolte = false;
                _secu = true;
                Instantiate(_ManaSpark ,transform.position,transform.rotation) ;//on va fair spawn une spark sur le cadavre
                _WL.m_enemysSparkvalue--;
                _WL.m_Sparksvalue++;
            }
            else
            {
                return;
            }
        }
    }
    #endregion


    #region Main Methods
    private void OnTriggerEnter(Collider other)
    {
        if (_récolte == false)
        {
            if (other.gameObject == (_Nexus)) //si on colision le nexus et que recolte et false
            {
                if (_hpnexus.m_value > 0)//on verifier si nexus a + de 0hp
                {
                    _récolte = true;//On passe recolte a true
                    _WL.m_enemysSparkvalue++;
                    _hpnexus.m_value--;
                   // Debug.Log(_hpnexus.m_value);
                }
                else
                    return;
            }
            if (other.gameObject.CompareTag("spark"))//si il colisione une spark
            {
                if (_secu2 == false && _mana._secuspark == false)
                {
                    _récolte = true;// on passe recolte a true pour ne plus recolter
                    _WL.m_enemysSparkvalue++;
                    _WL.m_Sparksvalue--;
                    _secu2 = true;
                    Destroy(other.gameObject);//on detruit la spark
                }
            }
        }

        if (other.gameObject.CompareTag("Reset") /*&& _récolte == true*/)//si il colisione un reset
        {
            _récolte = false;//on passe recolte a false pour pouvoir le detruir ensuite sans créer de spark
            m_gold = false;//on passe gold a false pour pouvoir le detruir ensuite sans incrementer de gold
            _WL.m_enemysSparkvalue--;
        }
       
        if (other.gameObject.CompareTag("sortie"))//si on touche la sortie
        {
            _enemyHP = 0;//on detrui l'ennemi
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (_récolte == false)
        {
            if (other.gameObject.tag == "Nexus")
            //  if (other.gameObject.CompareTag("Nexus")&& _hpnexus.m_value> 0) //si on colision le nexus et que recolte et false
            {
                _récolte = true;//On passe recolte a true
                _WL.m_enemysSparkvalue++;
            }
            else
            {
                return;
            }
            if (other.gameObject.CompareTag("spark") && _récolte == false && _mana._secuspark == false)//si il colisione une spark
            {
                if (_secu2 == false)
                {
                    _récolte = true;// on passe recolte a true pour ne plus recolter
                    Destroy(other.gameObject);//on detruit la spark
                    _WL.m_enemysSparkvalue++;
                    _WL.m_Sparksvalue--;
                }
            }
            else
            {
                return;
            }
        }
    }
    #endregion


    #region Privates
    private  GameObject _Nexus;//objectif des mob
    [SerializeField]
    private bool _secu;
    [SerializeField]
    private bool _secu2;
    #endregion
}
