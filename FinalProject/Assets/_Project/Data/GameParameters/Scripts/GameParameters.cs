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
    private float _playerJumpVelocityBase = 3.0f;

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

    [Header("Health & Scurvy")]
    [SerializeField]
    [Tooltip("What is the player's initial jump velocity at max Scurvy?")]
    private float _scurvyMaxJumpVelocity = 12.0f;

    [SerializeField]
    [Tooltip("What % Scurvy does the player start at?")]
    [Range(0.0f, 100.0f)]
    private float _initialScurvyLevel = 25.0f;

    [SerializeField]
    [Tooltip("What % Scurvy does the player gain per second?")]
    [Range(0.0f, 100.0f)]
    private float _passiveScurvyGain = 1.0f;

    [SerializeField]
    [Tooltip("What % Scurvy is removed by an orange?")]
    [Range(0.0f, 100.0f)]
    private float _orangeScurvyReduction = 10.0f;

    [Header("Economy")]

    [SerializeField]
    [Tooltip("How many coins does one Orange cost?")]
    private int _perOrangeCost = 1;

    [SerializeField]
    [Tooltip("How many coins does it cost to use the Anchor?")]
    private int _anchorCost = 1;
    #endregion

    #region Getters
    public int AnchorCost
    {
        get
        {
            return _anchorCost;
        }
    }
    public float DoubloonProjectileSpeed
    {
        get
        {
            return _doubloonProjectileSpeed;
        }
    }
    public float InitialScurvyLevel
    {
        get
        {
            return _initialScurvyLevel;
        }
    }
    public float OrangeScurvyReduction
    {
        get
        {
            return _orangeScurvyReduction;
        }
    }
    public float PassiveScurvyGain
    {
        get
        {
            return _passiveScurvyGain;
        }
    }
    public int PerOrangeCost
    {
        get
        {
            return _perOrangeCost;
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
    public float ScurvyMaxJumpVelocity
    {
        get
        {
            return _scurvyMaxJumpVelocity;
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
