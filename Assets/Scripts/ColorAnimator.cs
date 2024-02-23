using DG.Tweening;
using UnityEngine;

public class ColorAnimator : MonoBehaviour
{
	[SerializeField] private Material _material;
	[SerializeField] private float _animationTime;

	private void Start()
	{
		_material.color = Color.white;

		StartColorAnimation();
	}

	private void StartColorAnimation()
	{
		_material.DOColor(Color.red, _animationTime)
			.SetLoops(-1, LoopType.Yoyo)
			.SetEase(Ease.InOutBack);
	}
}