using UnityEngine;

public class ClickDamage : MonoBehaviour
{
    [SerializeField] private int damageValue = 10;
    [SerializeField] private HealthPresenter healthPresenter;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
            healthPresenter.Damage(damageValue);
    }
}
