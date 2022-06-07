using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterDo : MonoBehaviour
{
    [SerializeField] private UnityEvent enemyActions;
    [SerializeField] private UnityEvent bananaActions;
    [SerializeField] private UnityEvent generalActions;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            enemyActions.Invoke();
        }
        if (collision.CompareTag("Banana"))
        {
            bananaActions.Invoke();
        }
        else
        {
            generalActions.Invoke();
        }
    
    }
}
