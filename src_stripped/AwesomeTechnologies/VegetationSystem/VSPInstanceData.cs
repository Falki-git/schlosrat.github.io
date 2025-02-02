﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VSPInstanceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public struct VSPInstanceData
  {
    public Vector3 WordspacePosition;
    public Vector2 UV;
    public Vector3 Normal;
    public Matrix4x4 Matrix;
    public Vector4 ControlData;
    public int4 OutputIndex;
    public Vector4 OutputDensity;
  }
}
