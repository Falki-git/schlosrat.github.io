﻿// Decompiled with JetBrains decompiler
// Type: PA.ParticleField.Samples.CameraSwitch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PA.ParticleField.Samples
{
  public class CameraSwitch : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
  {
    public Camera cameraA;
    public Camera cameraB;
    private RectTransform m_Rt;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerClick(PointerEventData eventData) => throw null;

    private RectTransform rt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SwitchCameras() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraSwitch() => throw null;
  }
}
