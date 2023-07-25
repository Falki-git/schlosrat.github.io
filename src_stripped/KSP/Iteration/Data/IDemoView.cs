﻿// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.Data.IDemoView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.Generic;

namespace KSP.Iteration.Data
{
  public interface IDemoView
  {
    IProperty<bool> MapIsEnabled { get; }

    void ToggleMapIsEnabled();

    void SetMapIsEnabled(bool value);

    IProperty<IDemoVessel> ActiveVessel { get; }
  }
}
