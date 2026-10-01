using UnityEngine;



/// <summary>
/// Détecteur de boule qui déclenche des événements lorsque la boule entre ou sort d'une zone.
/// </summary>
[RequireComponent(typeof(Collider))]
public class DetecteurBoule : MonoBehaviour
{
    /// <summary>
    /// La boule est entrée dans la zone de détection.
    /// </summary>
    public event System.Action BouleEntree;

    /// <summary>
    /// La boule est sortie de la zone de détection.
    /// </summary>
    public event System.Action BouleSortie;

    [SerializeField] private Rigidbody balle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boule"))
        {
           //Ajouter charge d'une de ses deux manières:
            //BouleEntree.AjouterCharge()
            //BouleEntree.charge + 1


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Boule"))
        {
            BouleSortie?.Invoke();
        }
    }
}
