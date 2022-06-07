using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [Header("Configuration")]
    public float maxHealth;
    public float healthPoints;

    [Header("Dependencies")]
    public HealthBar healthBar;

    // Private
    [SerializeField] private UnityEvent onZeroHealthPointsActions;

    private void Start()
    {
        healthPoints = maxHealth;
    }

    public void ReceiveDamage(float damagePoints)
    {
        healthPoints -= damagePoints;

        healthBar.SetHealth(healthPoints);
                
        if (healthPoints <= 0)
        {
            OnZeroHealthPoints();
        }
    }

    public void OnZeroHealthPoints()
    {
        if (onZeroHealthPointsActions != null)
        {
            Debug.LogFormat("Activating!");
            onZeroHealthPointsActions.Invoke();
        }
    }

}

