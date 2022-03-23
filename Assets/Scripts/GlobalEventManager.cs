using System;
using UnityEngine;

public class GlobalEventManager : MonoBehaviour
{
    public static event Action OnDamageHit;


    public static void SendDamageHit()
    {
        if (OnDamageHit != null) OnDamageHit.Invoke();
    }
}
