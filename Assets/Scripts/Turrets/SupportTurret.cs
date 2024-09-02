﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SupportTurret : MonoBehaviour, ITurret
{
    virtual public string TurretClass => throw new System.NotImplementedException();

    virtual public int Level => throw new System.NotImplementedException();

    virtual public int Cost => throw new System.NotImplementedException();

    virtual public float Influence => throw new System.NotImplementedException();

    [SerializeField]
    Building _building;

    public Building AttachedBuilding { get => _building; set => _building = value; }
    virtual public float BuildTime { get; }

    [SerializeField]
    bool _online = false;
    public bool Online { get => _online; set => _online = value; }

    [SerializeField]
    protected Transform influence_center;

    public Dictionary<string, string> GetHoverData()
    {
        if (!Online)
        {
            return null;
        }

        return new Dictionary<string, string>()
        {
            {"type" , "support_turret"},
            {"name", TurretClass },
            {"level", Level.ToString() },
            {"bhp", _building.hp.ToString() },
        };
    }

    public virtual void OnHoverOff()
    {
    }

    public virtual void OnHoverOver(HoverInfo info)
    {
    }

    virtual public void OnTurretDestroy()
    {
    }

    virtual public void OnTurretSpawn()
    {
        Online = true;
    }

    protected virtual void Start()
    {
        Online = false;
    }

}
