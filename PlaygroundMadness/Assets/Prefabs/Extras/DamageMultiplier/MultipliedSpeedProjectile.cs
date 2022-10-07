using MoreMountains.TopDownEngine;
using ProgressionSystem.Scripts.Variables;
using UnityEngine;

public class MultipliedSpeedProjectile : Projectile
{
    public FloatVariable SpeedMultiplier;
    
    public override void Movement()
    {
        _movement = SpeedMultiplier.Value * (Speed / 10) * Time.deltaTime * Direction;
        if (_rigidBody != null)
        {
            _rigidBody.MovePosition (this.transform.position + _movement);
        }
        if (_rigidBody2D != null)
        {
            _rigidBody2D.MovePosition(this.transform.position + _movement);
        }
        // We apply the acceleration to increase the speed
        Speed += Acceleration * Time.deltaTime;
    }
}
