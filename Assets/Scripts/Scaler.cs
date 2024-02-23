using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _animationTime;
    [SerializeField] private float _targetPositionX;
    [SerializeField] private float _targetPositionY;
    [SerializeField] private float _targetPositionZ;

    private Transform _transform;
    

   private void Start()
   {
	   _transform = GetComponent<Transform>();
	   
	   StartScaleAnimation();
   }

   private void StartScaleAnimation()
    {
	    Vector3 targetPosition = new Vector3(_targetPositionX, _targetPositionY, _targetPositionZ);

	    _transform.DOScale(targetPosition, _animationTime)
		    .SetLoops(-1, LoopType.Yoyo)
		    .SetEase(Ease.InElastic);
    }
}
