using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class TargetClick : MonoBehaviour, IPointerClickHandler
{
    public event UnityAction<Vector3, Vector3> OnClick;
    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick.Invoke(eventData.pointerPressRaycast.worldPosition, 
                            eventData.pointerPressRaycast.worldNormal);
    }
    
}
