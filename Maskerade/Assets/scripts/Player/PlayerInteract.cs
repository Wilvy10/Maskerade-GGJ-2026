using UnityEngine;
using TMPro;

public class PlayerInteract : MonoBehaviour
{
    public TMP_Text interactText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactText.enabled = true;
        interactText.transform.position = collision.gameObject.transform.position;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interactText.enabled = false;
    }

    
}
