using Unity.VisualScripting;
using UnityEditor.ShaderGraph.Internal;
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
    #region Player Movement
    [Header("Player Movement")]

    [SerializeField]
    [Tooltip("What is the player's base initial jump velocity?")]
    public float PlayerJumpVelocityBase = 3.0f;

    [SerializeField]
    [Tooltip("How fast can the player move on land?")]
    public float PlayerMoveSpeedLand = 3.0f;

    [SerializeField]
    [Tooltip("How fast can the player move aboard a ship?")]
    public float PlayerMoveSpeedShip = 3.0f;
    #endregion Player Movement

    #region Combat
    [Header("Combat")]

    [SerializeField]
    [Tooltip("How fast do doubloon projectiles move?")]
    public float DoubloonProjectileSpeed = 15.0f;

    [SerializeField]
    [Tooltip("How much damage does a doubloon projectile do to enemies?")]
    public float DoubloonProjectileDamage = 1.0f;

    [SerializeField]
    [Tooltip("How much damage does the player do with a melee " +
        "attack when their bag is empty?")]
    public float MeleeDamageMin = 1.0f;

    [SerializeField]
    [Tooltip("What how much damage does the player do with a melee " +
        "attack per coin in their bag?")]
    public float PerCoinMeleeDamageIncrease = 1.0f;

    [SerializeField]
    [Tooltip("What is the distance (radius) from the skeleton enemy " +
        "where the player will be detected when chasing?")]
    public float SkeletonEnemyChaseDetectionRadius = 3f;

    [SerializeField]
    [Tooltip("What is the distance (radius) from the skeleton enemy " +
        "where the player will be detected when patrolling?")]
    public float SkeletonEnemyPatrolDetectionRadius = 1.5f;

    [SerializeField]
    [Tooltip("How much health does the skeleton enemy start with?")]
    public float SkeletonEnemyMaxHealth = 10.0f;

    [SerializeField]
    [Tooltip("How fast does a skeleton enemy move when patrolling?")]
    public float SkeletonEnemyPatrolSpeed = 0.15f;

    [SerializeField]
    [Tooltip("How fast does a skeleton enemy move when chasing the player?")]
    public float SkeletonEnemyChaseSpeed = 1.0f;

    [SerializeField]
    [Tooltip("How close (radius) does the skeleton have to be to the " +
        "player to give them scurvy?")]
    public float SkeletonScurvyRadius = 0.5f;

    [SerializeField]
    [Tooltip("How much scurvy does a skeleton enemy add per second to " +
        "the player if they are close by?")]
    public float SkeletonScurvyPerSecond = 1.0f;

    [SerializeField]
    [Tooltip("How much force does a cannon ball fire with?")]
    public float CannonBallForce = 15.0f;

    [SerializeField]
    [Tooltip("How many cannon balls are required to sink an enemy ship?")]
    public int CannonBallsToDefeatShip = 3;
    #endregion Combat

    #region Ship Movement
    [Header("Ship Movement")]

    [SerializeField]
    [Tooltip("How much force is applied to the ship if the player " +
        "triggers the bottom mast coin slot?")]
    public float ShipAppliedForceLow = 2.5f;

    [SerializeField]
    [Tooltip("How much force is applied to the ship if the player " +
        "triggers the middle mast coin slot?")]
    public float ShipAppliedForceMed = 5.0f;

    [SerializeField]
    [Tooltip("How much force is applied to the ship if the player " +
        "triggers the top mast coin slot?")]
    public float ShipAppliedForceHigh = 10.0f;
    #endregion Ship Movement

    #region Scurvy
    [Header("Scurvy")]
    [SerializeField]
    [Tooltip("How many oranges does each tree have?")]
    public int OrangesPerTree = 3;

    [SerializeField]
    [Tooltip("What is the player's initial jump velocity at max Scurvy?")]
    public float ScurvyMaxJumpVelocity = 12.0f;

    [SerializeField]
    [Tooltip("What % Scurvy does the player start at?")]
    [Range(0.0f, 100.0f)]
    public float InitialScurvyLevel = 25.0f;

    [SerializeField]
    [Tooltip("What % Scurvy does the player gain per second?")]
    [Range(0.0f, 100.0f)]
    public float PassiveScurvyGain = 1.0f;

    [SerializeField]
    [Tooltip("What % Scurvy is removed by an orange?")]
    [Range(0.0f, 100.0f)]
    public float OrangeScurvyReduction = 10.0f;
    #endregion Scurvy

    #region Economy
    [Header("Economy")]

    [SerializeField]
    [Tooltip("How many shovels does the player start with?")]
    public int InitialShovelCount = 0;

    [SerializeField]
    [Tooltip("How many coins does the player start with?")]
    public int InitialCoinCount = 20;

    [SerializeField]
    [Tooltip("How many coins does one Orange cost?")]
    public int PerOrangeCost = 1;

    [SerializeField]
    [Tooltip("How many coins does it cost to use the Anchor?")]
    public int AnchorCost = 1;

    [SerializeField]
    [Tooltip("How many coins does it cost to use an XMarksTheSpot?")]
    public int XCost = 1;

    [SerializeField]
    [Tooltip("What is the minimum number of coins a player can get from XMarksTheSpot?")]
    public int CoinsFromXMin = 3;

    [SerializeField]
    [Tooltip("What is the maximum number of coins a player can get from XMarksTheSpot?")]
    public int CoinsFromXMax = 10;

    [SerializeField]
    [Tooltip("How many coins does it cost to fire a cannon ball?")]
    public int CannonBallCost = 3;

    [SerializeField]
    [Tooltip("What is the minimum number of coins the player can lose " +
        "when using a melee attack?")]
    public int MinMeleeCoinsLost = 1;

    [SerializeField]
    [Tooltip("What is the maximum number of coins the player can lose " +
        "when using a melee attack?")]
    public int MaxMeleeCoinsLost = 5;

    [SerializeField]
    [Tooltip("At what speed do heatseeking pickups move at?")]
    public float HeatSeekSpeed = 3.0f;

    [SerializeField]
    [Tooltip("What is the minimum shovel drop count of a ship?")]
    public int ShipShovelDropCountMin = 1;

    [SerializeField]
    [Tooltip("What is the maximum shovel drop count of a ship?")]
    public int ShipShovelDropCountMax = 2;

    [SerializeField]
    [Tooltip("What is the minimum shovel drop count of an enemy?")]
    public int EnemyShovelDropCountMin = 0;

    [SerializeField]
    [Tooltip("What is the maximum shovel drop count of an enemy?")]
    public int EnemyShovelDropCountMax = 1;

    [SerializeField]
    [Tooltip("What is the minimum coin drop count of a ship?")]
    public int ShipCoinDropCountMin = 10;

    [SerializeField]
    [Tooltip("What is the maximum coin drop count of a ship?")]
    public int ShipCoinDropCountMax = 30;

    [SerializeField]
    [Tooltip("What is the minimum coin drop count of an enemy?")]
    public int EnemyCoinDropCountMin = 1;

    [SerializeField]
    [Tooltip("What is the maximum coin drop count of an enemy?")]
    public int EnemyCoinDropCountMax = 5;

    #endregion Economy
}


    
