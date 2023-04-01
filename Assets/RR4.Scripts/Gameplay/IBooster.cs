using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// interface to represent car booster type
public interface IBooster 
{
    public void Boost();
    public void Deactivate();

    public bool IsActive { get; }

    public float BoostDuration { get; }

    public float BoostSpeed { get; }

    public float BoostCooldown { get; }

    public float BoostCooldownTimer { get; set; }

    public float BoostTimer { get; set; }

    public float BoostSpeedMultiplier { get; set; }

    

}
