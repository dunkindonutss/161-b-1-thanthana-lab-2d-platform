using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Character character;
    [SerializeField] private Image healthBar;

    private float maxHealth;

    public void SetMaxHealth(float maxHealth)
    {
        this.maxHealth = maxHealth;
        UpdateHealthBar();
    }

    public void UpdateHealthBar()
    {
        float fill = character.Health / maxHealth;
        healthBar.fillAmount = fill;
    }
}