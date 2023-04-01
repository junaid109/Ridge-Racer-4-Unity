using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBooster : MonoBehaviour, IBooster
{
    public Car car;

    public GameObject booseterUIEffect;
    public GameObject boosterEffect;

    public float BoostSpeedMultiplier { get; set; }

    public void Boost()
    {
        if (BoostCooldownTimer <= 0) {
            BoostTimer = BoostDuration;
            BoostCooldownTimer = BoostCooldown;
            car.speed *= BoostSpeed;
            boosterEffect.SetActive(true);
            booseterUIEffect.SetActive(true);
        }
    }

    public void Deactivate()
    {
        if (BoostTimer <= 0) {
            car.speed /= BoostSpeed;
            boosterEffect.SetActive(false);
            booseterUIEffect.SetActive(false);
        }
    }

    public bool IsActive { get; }
    public float BoostDuration { get; }
    public float BoostSpeed { get; }
    public float BoostCooldown { get; }
    public float BoostCooldownTimer { get; set; }
    public float BoostTimer { get; set; }

    private void Update() {
        if (BoostCooldownTimer > 0) {
            BoostCooldownTimer -= Time.deltaTime;
        }
        if (BoostTimer > 0) {
            BoostTimer -= Time.deltaTime;
        }
    }

    public void Start() {
        BoostCooldownTimer = 0;
        BoostTimer = 0;
    }
}
