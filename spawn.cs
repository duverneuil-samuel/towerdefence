using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    #region Exposed
    public GameObject _ennemy;//les gameobject quon dragdrop dans l'inspecteur qui sevent au spawn

    [SerializeField]
    private inWaveCount _numbWave; //scriptable quon decremente qunad on spawn les enemy

    [SerializeField]
    private float _chronospawn;//timer qui sert a choisir quand von spawn les wave
    
    [SerializeField]
    private WLvalue _WL;

    [SerializeField]
    float i = 0;

    [SerializeField]
    private GameObject _portal;
    #endregion

    #region Unity API
    void Start()
    {
        GetComponent<textWaveCount>();
        _chronospawn = 0;
        _WL.m_enemysvalue = 0;
    }
    void Update()
    {
        _chronospawn += Time.deltaTime;//on incremente le timer
        if (_chronospawn >= 8 && _1 == false)
        {
            _portal.SetActive(true);
            if (_chronospawn >= 10.50000 && i < 1)
            {
                i++;
                Instantiate(_ennemy, transform.position + Vector3.forward * i, transform.rotation);
                _WL.m_enemysvalue++;
            }
            if (_chronospawn >= 12 && i < 1.5)
            {
                i += 0.5f;
                Instantiate(_ennemy, transform.position + Vector3.forward * i, transform.rotation);
                _WL.m_enemysvalue++;
            }
            if (_chronospawn >= 14 && i < 2)
            {
                i += 0.5f;
                Instantiate(_ennemy, transform.position + Vector3.forward * i, transform.rotation);
                _WL.m_enemysvalue++;
            }
            if (_chronospawn >= 15.5 && i < 2.5)
            {
                i += 0.5f;
                Instantiate(_ennemy, transform.position + Vector3.forward * i, transform.rotation);
                _WL.m_enemysvalue++;
                _numbWave.m_value--;//on decremente
            }
            if (_chronospawn > 16.5f)
            {
                _portal.SetActive(false);
                i = 0f;
                _1 = true;//on le passe true
            }
        }

        if (_chronospawn >= 18f && _2 == false)
        {
            _portal.SetActive(true);
            if (_chronospawn >= 19 && i < 1)
            {
                i++;
                Instantiate(_ennemy, transform.position + Vector3.forward * i, transform.rotation);//on invoc le mob a la position ciblé
                _WL.m_enemysvalue++;//on augente le nombre d'enemi
            }
            if (_chronospawn >= 20 && i < 1.25)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.forward * i, transform.rotation);
                _WL.m_enemysvalue++;
            }
            if (_chronospawn >= 21 && i < 1.5)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.forward * i, transform.rotation);
                _WL.m_enemysvalue++;
            }
            if (_chronospawn >= 22 && i < 1.75)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                _WL.m_enemysvalue += 2;
            }
            if (_chronospawn >= 23 && i < 2)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.left * i, transform.rotation);
                _WL.m_enemysvalue++;
            }
            if (_chronospawn >= 24 && i < 2.25)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                _WL.m_enemysvalue += 2;
                _numbWave.m_value--;//on decremente
            }
            if (_chronospawn > 26f)
            {
                _portal.SetActive(false);
                i = 0f;//on re initialise i
                _2 = true;//on le passe true
            }
        }

        if (_chronospawn >= 35f && _3 == false)
        {
            _portal.SetActive(true);
            if (_chronospawn >= 35.5 && i < 0.25)
            {
                i += 1f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
            }
            if (_chronospawn >= 37 && i <= 1)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                _WL.m_enemysvalue += 2;
            }
            if (_chronospawn >= 38.5 && i <= 1.25)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                _WL.m_enemysvalue += 2;
            }
            if (_chronospawn >= 39.5 && i <= 1.5)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                _WL.m_enemysvalue += 2;
            }
            if (_chronospawn >= 41 && i <= 1.75)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
                _numbWave.m_value--;//on decremente
            }
            if (_chronospawn > 44f)
            {
                _portal.SetActive(false);
                i = 0f;
                _3 = true;//on le passe true
            }
        }

        if (_chronospawn >= 48f && _4 == false)
        {
            _portal.SetActive(true);
            if (_chronospawn >= 49.5 && i < 0.25)
            {
                i += 1f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
            }
            if (_chronospawn >= 51 && i <= 1.25 && _lock==false)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
                _lock = true;
            }
            if (_chronospawn >= 52.5 && i <= 1.5)
            {
                i += 0.3f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
            }
            if (_chronospawn >= 54 && i <= 1.75)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
            }
            if (_chronospawn >= 55.5 && i <= 2 && _lock5==false)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
                _lock5 = true;
                _numbWave.m_value--;//on decremente
            }
            if (_chronospawn > 58f)
            {
                _portal.SetActive(false);
                i = 0f;
                _4 = true;//on le passe true
            }
        }

        if (_chronospawn >= 62f && _5 == false)
        {
            _portal.SetActive(true);
            if (_chronospawn >= 63.5 && i < 0.25)
            {
                i += 1f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
            }
            if (_chronospawn >= 65 && i <= 1.25 && _5bis == false)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
                _5bis = true;
            }
            if (_chronospawn >= 66 && i <= 1.5 && _lock4==false)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
                _lock4 = true;
            }
            if (_chronospawn >= 67 && i <= 1.75 && _lock7==false)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
                _lock7 = true;
            }
            if (_chronospawn >= 68 && i <= 2)
            {
                i += 0.3f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
                _numbWave.m_value--;//on decremente
            }
            if (_chronospawn > 70f)
            {
                _portal.SetActive(false);
                i = 0f;
                _5 = true;//on le passe true
            }
        }
        if (_chronospawn >= 72.5f && _6 == false)
        {
            _portal.SetActive(true);
            if (_chronospawn >= 73 && i < 0.25)
            {
                i += 1f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
            }
            if (_chronospawn >= 75 && i <= 1.25 && _lock2 ==false)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
                _lock2 = true;
            }
            if (_chronospawn >= 76 && i <= 1.5 && _lock3==false)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
                _lock3 = true;
            }
            if (_chronospawn >= 77.5 && i <= 1.75 && _lock6==false)
            {
                i += 0.25f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
                _lock6 = true;
            }
            if (_chronospawn >= 79 && i <= 2)
            {
                i += 0.3f;
                Instantiate(_ennemy, transform.position + Vector3.right * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position + Vector3.left * i + Vector3.forward * i, transform.rotation);
                Instantiate(_ennemy, transform.position, transform.rotation);
                _WL.m_enemysvalue += 3;
                _numbWave.m_value--;//on decremente
            }
            if (_chronospawn > 80f)
            {
                _portal.SetActive(false);
                i = 0f;
                _6 = true;//on le passe true
            }
        }
    }
    #endregion


    #region Privates
    private bool _1;//bool qui sert a valider la condition on aura besoin de un a chaque wave
    private bool _2;
    private bool _3;
    private bool _4;
    private bool _5;
    [SerializeField]
    private bool _5bis;
    [SerializeField]
    private bool _6;

    [SerializeField]
    private bool _lock;
    [SerializeField]
    private bool _lock2;
    [SerializeField]
    private bool _lock3;
    [SerializeField]
    private bool _lock4;
    [SerializeField]
    private bool _lock5;
    [SerializeField]
    private bool _lock6;
    [SerializeField]
    private bool _lock7;
    [SerializeField]
    private bool _lock8;
    [SerializeField]
    private bool _lock9;
    #endregion
}
