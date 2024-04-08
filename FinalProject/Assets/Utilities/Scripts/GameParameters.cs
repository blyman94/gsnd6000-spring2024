using Unity.VisualScripting;
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

    [SerializeField]
    [Tooltip("How much damage does a doubloon projectile do to enemies?")]
    private float _doubloonProjectileDamage = 1.0f;

    [SerializeField]
    [Tooltip("What is the minimum number of coins the player can lose " +
        "when using a melee attack?")]
    private int _minMeleeCoinsLost = 1;

    [SerializeField]
    [Tooltip("What is the maximum number of coins the player can lose " +
        "when using a melee attack?")]
    private int _maxMeleeCoinsLost = 5;

    [SerializeField]
    [Tooltip("How much damage does the player do with a melee " +
        "attack when their bag is empty?")]
    private float _meleeDamageMin = 1.0f;

    [SerializeField]
    [Tooltip("What how much damage does the player do with a melee " +
        "attack per coin in their bag?")]
    private float _perCoinMeleeDamageIncrease = 1.0f;

    [SerializeField]
    [Tooltip("What is the distance (radius) from the skeleton enemy " +
        "where the player will be detected when chasing?")]
    private float _skeletonEnemyChaseDetectionRadius = 3f;

    [SerializeField]
    [Tooltip("What is the distance (radius) from the skeleton enemy " +
        "where the player will be detected when patrolling?")]
    private float _skeletonEnemyPatrolDetectionRadius = 1.5f;

    [SerializeField]
    [Tooltip("How much health does the skeleton enemy start with?")]
    private float _skeletonEnemyMaxHealth = 10.0f;

    [SerializeField]
    [Tooltip("How fast does a skeleton enemy move when patrolling?")]
    private float _skeletonEnemyPatrolSpeed = 0.15f;

    [SerializeField]
    [Tooltip("How fast does a skeleton enemy move when chasing the player?")]
    private float _skeletonEnemyChaseSpeed = 1.0f;

    [SerializeField]
    [Tooltip("How close (radius) does the skeleton have to be to the " + 
        "player to give them scurvy?")]
    private float _skeletonScurvyRadius = 0.5f;

    [SerializeField]
    [Tooltip("How much scurvy does a skeleton enemy add per second to " +
        "the player if they are close by?")]
    private float _skeletonScurvyPerSecond = 1.0f;

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
    [Tooltip("How many oranges does each tree have?")]
    private int _orangesPerTree = 3;

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
    [Tooltip("How many shovels does the player start with?")]
    private int _initialShovelCount = 0;

    [SerializeField]
    [Tooltip("How many coins does the player start with?")]
    private int _initialCoinCount = 20;

    [SerializeField]
    [Tooltip("How many coins does one Orange cost?")]
    private int _perOrangeCost = 1;

    [SerializeField]
    [Tooltip("How many coins does it cost to use the Anchor?")]
    private int _anchorCost = 1;

    [SerializeField]
    [Tooltip("How many coins does it cost to use an XMarksTheSpot?")]
    private int _xCost = 1;

    [SerializeField]
    [Tooltip("What is the minimum number of coins a player can get from XMarksTheSpot?")]
    private int _coinsFromXMin = 3;

    [SerializeField]
    [Tooltip("What is the maximum number of coins a player can get from XMarksTheSpot?")]
    private int _coinsFromXMax = 10;
    #endregion

    #region Getters
    public int AnchorCost
    {
        get
        {
            return _anchorCost;
        }
    }
    public int CoinsFromXMax
    {
        get
        {
            return _coinsFromXMax;
        }
    }
    public int CoinsFromXMin
    {
        get
        {
            return _coinsFromXMin;
        }
    }
    public float DoubloonProjectileDamage
    {
        get
        {
            return _doubloonProjectileDamage;
        }
    }
    public float DoubloonProjectileSpeed
    {
        get
        {
            return _doubloonProjectileSpeed;
        }
    }
    public int InitialCoinCount
    {
        get
        {
            return _initialCoinCount;
        }
    }
    public float InitialScurvyLevel
    {
        get
        {
            return _initialScurvyLevel;
        }
    }
    public int InitialShovelCount
    {
        get
        {
            return _initialShovelCount;
        }
    }
    public int MaxMeleeCoinsLost
    {
        get
        {
            return _maxMeleeCoinsLost;
        }
    }
    public int MinMeleeCoinsLost
    {
        get
        {
            return _minMeleeCoinsLost;
        }
    }
    public float MeleeDamageMin
    {
        get
        {
            return _meleeDamageMin;
        }
    }
    public float OrangeScurvyReduction
    {
        get
        {
            return _orangeScurvyReduction;
        }
    }
    public int OrangesPerTree
    {
        get
        {
            return _orangesPerTree;
        }
    }
    public float PassiveScurvyGain
    {
        get
        {
            return _passiveScurvyGain;
        }
    }
    public float PerCoinMeleeDamageIncrease
    {
        get
        {
            return _perCoinMeleeDamageIncrease;
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
    public float SkeletonEnemyChaseDetectionRadius
    {
        get
        {
            return _skeletonEnemyChaseDetectionRadius;
        }
    }
    public float SkeletonEnemyChaseSpeed
    {
        get
        {
            return _skeletonEnemyChaseSpeed;
        }
    }
    
    public float SkeletonEnemyPatrolDetectionRadius
    {
        get
        {
            return _skeletonEnemyPatrolDetectionRadius;
        }
    }
    public float SkeletonEnemyPatrolSpeed
    {
        get
        {
            return _skeletonEnemyPatrolSpeed;
        }
    }
    public float SkeletonEnemyMaxHealth
    {
        get
        {
            return _skeletonEnemyMaxHealth;
        }
    }
    public float SkeletonScurvyRadius
    {
        get
        {
            return _skeletonScurvyRadius;
        }
    }
    public float SkeletonScurvyPerSecond
    {
        get
        {
            return _skeletonScurvyPerSecond;
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
    public int XCost
    {
        get
        {
            return _xCost;
        }
    }
    #endregion
}
