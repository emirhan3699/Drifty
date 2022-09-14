using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{

    private Vector3 _offset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    private Vector3 _currentVelocity = Vector3.zero;
    private Vector3 _defaultposition;
    private void Awake()
    {
        _offset = transform.position - target.position;
        _defaultposition = this.transform.localPosition;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + _offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, smoothTime);
    }
    public void Reset()
    {
        this.transform.localPosition = _defaultposition;
    }
}