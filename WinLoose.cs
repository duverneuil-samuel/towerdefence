using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoose : MonoBehaviour
{
    #region Exposed
    public WLvalue m_enemysSpark;//on va créer un tableau qui se rempli a chaque qu'un enemi a le bool recolte qui passe true
    public WLvalue m_Sparks;//on va créer un tableau qui se rempli a chaque spark qui s'instancie
    public GameObject m_loose;
    public GameObject m_win;
    public WLvalue _enemys;//on va créer un tableau qui se rempli a chaque enemy qui s'instancie
    public bool m_bloque;

    [SerializeField]
    private intHpNexus _hpNexus;//scriptable object des hp nexus
    
    [SerializeField]
    private inWaveCount _wavecount;//scriptable object qui conte les wave

    [SerializeField]
    private Canvas _UIsound;//le canvas
    #endregion

    #region Unity API
    public void Awake()
    {
        _enemys.m_enemysvalue = 0;
        _enemys.m_Sparksvalue = 0;
        _enemys.m_enemysSparkvalue = 0;
    }
    void Update()
    {
        if (_hpNexus.m_value<=0  && m_enemysSpark.m_enemysSparkvalue <= 0 && m_Sparks.m_Sparksvalue <= 0 && _UIsound.gameObject.activeSelf.Equals(false) && m_bloque == (false)) //on verifi tt les tableau si tt est vide on a perdu*/
        {
            m_bloque = (true);
            m_loose.SetActive(true);
        }

        if (_wavecount.m_value <= 0 && _enemys.m_enemysvalue <= 0 && _hpNexus.m_value > 0 && _UIsound.gameObject.activeSelf.Equals(false)&& m_bloque == (false))//on que les 2 value sont a 0
        {
            m_bloque = (true);
            m_win.SetActive(true);
        }
    }
    #endregion
}
