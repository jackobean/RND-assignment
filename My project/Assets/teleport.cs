using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class teleport : MonoBehaviour
{

    public GameObject portal1;
    public GameObject portal2;
    public bool cooldown;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == portal1 && !cooldown)
        {
            this.gameObject.transform.position = portal2.transform.position;
            cooldown = true;
            StartCoroutine(timer());
        }
        else if (collision.gameObject == portal2 &&!cooldown)
        {
            this.gameObject.transform.position = portal1.transform.position;
            cooldown = true;
            StartCoroutine(timer());
        }
    }
    public IEnumerator timer()
    { 
    
        yield return new WaitForSeconds(2);
         cooldown = false;
    }
}
