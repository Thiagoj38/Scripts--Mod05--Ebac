using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyBase : MonoBehaviour, IKillable, IDamageable<int>
{
    

    #region Variables

    public EnemySetup enemySetup;
    public int life;
    public Object enemy;
    
    protected int damage = 2;   
    
    #endregion

    #region METHODS
    

    public virtual void Damage()
    {

        life -= damage;
        
        
    }

    public virtual void Kill()
    {
        if (life == 0 || life < 0)
        {
            Object.Destroy(enemy);
        }
    }
    #endregion
    

    private void Awake()
    {
        Init();        
    }

    private void Init()
    {
        life = enemySetup.startLife;
        
        
    }

    private void Update()
    {
        
    }

}

