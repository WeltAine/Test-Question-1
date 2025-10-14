using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{

    public void TakeHit(float damage, GameObject attacker);//基于伤害来源产生不同特别的反馈
    public void TakeHit(float damage);//通用受伤反馈

}
