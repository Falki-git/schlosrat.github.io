﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ManipulationCameraTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ManipulationCameraTest : MonoBehaviour
  {
    private bool isRotating;
    private bool isDragging;
    private Vector3 curPos;
    private Vector3 lastPos;
    public float speedMult;
    public float rotateSpeed;
    private GameObject grabbedObject;
    private GameObject cameraPivot;
    private Camera curCamera;
    private Plane dragPlane;
    private ManipulationWidget manipulationWidget;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManipulationCameraTest() => throw null;
  }
}
