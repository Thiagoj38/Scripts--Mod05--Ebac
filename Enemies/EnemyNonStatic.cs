using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyNonStatic : EnemyBase, IKillable, IDamageable<int>
{
    #region VARIABLES
    public MeshRenderer meshRenderer;
    public MeshRenderer meshRenderer02;
    #endregion

    #region METHODS
    public override void Damage()
    {
        base.Damage();
        StartCoroutine(CoroutineColor());
    }

    public override void Kill()
    {
        base.Kill();
    }
    #endregion

    #region COROUTINE
    IEnumerator CoroutineColor()
    {
        for (float i = 1f; i >= 0; i -= .05f)
        {
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.white, Color.red, 1 - i));
            meshRenderer02.material.SetColor(("_Color"), Color.Lerp(Color.white, Color.red, 1 - i));
            meshRenderer.material.SetColor(("_Color"), Color.Lerp(Color.red, Color.white, 1 - i));
            meshRenderer02.material.SetColor(("_Color"), Color.Lerp(Color.red, Color.white, 1 - i));
            yield return new WaitForEndOfFrame();
        }


    }
    #endregion

}
