using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected int health;
    protected float movementSpeed;
    protected float attackSpeed;
    protected float attackRange;
    protected int attackPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage) { }

    virtual protected void Attack(Character target) { }

    protected void Move(Vector3 placeTarget) { }
}
