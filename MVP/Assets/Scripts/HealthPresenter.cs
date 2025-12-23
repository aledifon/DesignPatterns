using UnityEngine;
using UnityEngine.UI; 

public class HealthPresenter : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private Slider healthSlider;

    void Start()
    {
        if(health != null)
        {
            // Event Subscription
            health.HealthChanged += OnHealthChanged;
            // Set health to its def. value
            Restore();
        }
        UpdateView();
    }
    private void OnDestroy()
    {
        if(health != null)
            health.HealthChanged -= OnHealthChanged;
    }
    public void Damage(int amount)
    {
        health.Decrement(amount);
    }
    public void Heal(int amount)
    {
        health.Increment(amount);
    }
    public void Restore()
    {
        health.Restore();
    }
    public void UpdateView()
    {
        // Security
        if (health == null) 
            return;

        if(healthSlider != null && health.MaxHealth != 0)
        {
            // Update the slider value
            healthSlider.value = (float)health.CurrentHealth / (float)health.MaxHealth;
        }
    }

    public void OnHealthChanged()
    {
        //Update the UI
        UpdateView();
    }
}
