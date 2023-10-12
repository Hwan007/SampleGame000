using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eSoundType
{
    Master,
    BGM,
    Effect,
    UI,
}

public enum eUIType
{
    Popup,
}

[System.Serializable]
public struct CustomResolution
{
    public int Width;
    public int Height;
}

[Serializable]
public struct CustomSize
{
    public float Width;
    public float Height;
}
