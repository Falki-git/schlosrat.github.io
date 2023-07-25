﻿// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoCap2DController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public interface IGizmoCap2DController
  {
    void UpdateHandles();

    void UpdateTransforms();

    void CapSlider2D(Vector2 sliderDirection, Vector2 sliderEndPt);

    void CapSlider2DInvert(Vector2 sliderDirection, Vector2 sliderEndPt);

    float GetSliderAlignedRealLength();
  }
}
