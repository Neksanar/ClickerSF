using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ParticleManager : MonoBehaviour
{
    public ParticleSystem StrikeParticlesPrefab;

    public void CreateParticles(Vector3 pos, Vector3 rot)
    {
        Instantiate<ParticleSystem>(StrikeParticlesPrefab, pos, Quaternion.LookRotation(rot));
    }
}