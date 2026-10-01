using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class CompteurVitesse : MonoBehaviour
{
    [Header("Références")]
    [SerializeField] private Rigidbody balle;
    [SerializeField] private TMP_Text texteTMP;
    [SerializeField] private Text texteLegacy;

    [SerializeField] private Object prefabCharge;
    [SerializeField] private Scene uiCharge;


    private void Awake()
    {
        if (texteTMP == null) texteTMP = GetComponent<TMP_Text>();
        if (texteLegacy == null) texteLegacy = GetComponent<Text>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        string texte = "";
        

        for (int i =0; i < 3; i++)
        {
            //Pour chaque charge que possède la boule, en afficher une 
            Instantiate(prefabCharge, uiCharge);
        }

        if (texteTMP != null) texteTMP.text = texte;
        if (texteLegacy != null) texteLegacy.text = texte;
    }


}
