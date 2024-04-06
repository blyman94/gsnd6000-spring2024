using UnityEngine;

/// <summary>
/// A VS-friendly data storage class for all parameters in the game. Keep a 
/// reference to a GameParameters variable in the VisualScriptingSceneVariable
/// list and use the getter methods to pull data from a designated parameter
/// file.
/// </summary>
[CreateAssetMenu]
public class GameParameters : ScriptableObject
{
    #region Data Fields
    [Header("Player Movement")]

    [SerializeField]
    [Tooltip("What is the player's base initial jump velocity?")]
    private float _playerJumpVelocityBase = 10.0f;

    [SerializeField]
    [Tooltip("How fast can the player move on land?")]
    private float _playerMoveSpeedLand = 3.0f;

    [SerializeField]
    [Tooltip("How fast can the player move aboard a ship?")]
    private float _playerMoveSpeedShip = 3.0f;

    [Header("Combat")]

    [SerializeField]
    [Tooltip("How fast do doubloon projectile's move?")]
    private float _doubloonProjectileSpeed = 15.0f;
    #endregion

    [Header("Ship Movement")]

    [SerializeField]
    [Tooltip("How much force is applied to the ship if the player " +
        "triggers the bottom mast coin slot?")]
    private float _shipAppliedForceLow = 2.5f;

    [SerializeField]
    [Tooltip("How much force is applied to the ship if the player " +
        "triggers the middle mast coin slot?")]
    private float _shipAppliedForceMed = 5.0f;

    [SerializeField]
    [Tooltip("How much force is applied to the ship if the player " +
        "triggers the top mast coin slot?")]
    private float _shipAppliedForceHigh = 10.0f;

    #region Getters
    public float DoubloonProjectileSpeed
    {
        get
        {
            return _doubloonProjectileSpeed;
        }
    }
    public float PlayerJumpVelocityBase
    {
        get
        {
            return _playerJumpVelocityBase;
        }
    }
    public float PlayerMoveSpeedLand
    {
        get
        {
            return _playerMoveSpeedShip;
        }
    }
    public float PlayerMoveSpeedShip
    {
        get
        {
            return _playerMoveSpeedShip;
        }
    }
    public float ShipAppliedForceLow
    {
        get
        {
            return _shipAppliedForceLow;
        }
    }
    public float ShipAppliedForceMed
    {
        get
        {
            return _shipAppliedForceMed;
        }
    }
    public float ShipAppliedForceHigh
    {
        get
        {
            return _shipAppliedForceHigh;
        }
    }
    #endregion
}
