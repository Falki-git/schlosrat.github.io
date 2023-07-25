﻿// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoCap3DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public interface IGizmoCap3DController
  {
    void UpdateHandles();

    void UpdateTransforms(float zoomFactor);

    void CapSlider3D(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor);

    void CapSlider3DInvert(Vector3 sliderDirection, Vector3 sliderEndPt, float zoomFactor);

    float GetSliderAlignedRealLength(float zoomFactor);
  }
}
