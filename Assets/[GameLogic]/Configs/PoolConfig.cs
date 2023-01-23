using Core.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "PoolConfig", menuName = "Configs/Game/PoolConfig")]
public class PoolConfig : Config
{
    public enum EnemyType
    {
        One,
        Two,
        Three
    }
    public Enemy[] Enemies;

    [Serializable]
    public class Enemy
    {
        public EnemyView EnemyView;
        public EnemyType EnemyType;
        public int EnemyCount;
        public float Speed;
        public float Health;
        public float Damage;
        public float AttackSpeed;
        [Range(0, 1)]public float Defence;
        public float AttackDistancce;
        public int RandomWeight;
    }

    public Dictionary<int, int> AllWeight()
    {
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        foreach (var enemy in Enemies)
        {
            keyValuePairs.Add((int)enemy.EnemyType, enemy.RandomWeight);
        }

        return keyValuePairs;
    }

    public int RandomEnemyType()
    {
        int[] weights = AllWeight().Values.ToArray();

        int randomWeight = UnityEngine.Random.Range(0, weights.Sum());

        for (int i = 0; i < weights.Length; i++)
        {
            randomWeight -= weights[i];

            if (randomWeight < 0)
            {
                foreach (var enemy in Enemies)
                {
                    if (AllWeight()[i] == enemy.RandomWeight)
                    {
                        return (int)enemy.EnemyType;
                    }
                }
            }
        }

        return -1;
    }
}
