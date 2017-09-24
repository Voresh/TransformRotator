using UnityEngine;
using UnityEngine.EventSystems;

public class TransformRotator : MonoBehaviour, IDragHandler
{
    [SerializeField] private Transform _unitToRotate;
    [Range(0.01f, 0.5f)] [SerializeField] private float _rotationCoefficient = 0.25f;
    [SerializeField] private bool _lockX;
    [SerializeField] private bool _lockY;

    public void OnDrag(PointerEventData eventData)
    {
        var x = _lockX ? 0f : eventData.delta.y * _rotationCoefficient;
        var y = _lockY ? 0f : eventData.delta.x * -_rotationCoefficient;
        _unitToRotate.Rotate(x, y, 0f, Space.World);
    }
}