using DG.Tweening;
using SingleApp;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

public class Spinner : Singleton<Spinner>
{
    public SkinnedMeshRenderer skin;
    public DOTweenAnimation Animation;
    public Transform spinner;

    public Material[] mats;
    
    [Button]
    public void Rotate()
    {
        spinner.DOKill();
        spinner.DOLocalRotate(Vector3.up * 360, 0.5f, RotateMode.FastBeyond360).SetLoops(8, LoopType.Incremental).SetEase(Ease.Linear);
    }

    public void ChangeMat(int i)
    {
        skin.sharedMaterial = mats[i];
    }
}
