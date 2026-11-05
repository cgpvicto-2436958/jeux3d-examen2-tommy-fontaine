using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class Piece : MonoBehaviour
{
    [SerializeField, Tooltip("reference vers le texte du nombre de pièces")]
    private TextMeshProUGUI textePieces;

    [SerializeField, Tooltip("reference vers la boule")]
    private Boule boule;


    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boule")) 
        { 
            boule.nombrePieces += 1;
            textePieces.text = boule.nombrePieces.ToString();
            gameObject.SetActive(false);
        }
    }
}
