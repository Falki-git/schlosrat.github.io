﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Wind.WindControllerSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Common;
using System;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.VegetationSystem.Wind
{
  [Serializable]
  public class WindControllerSettings : BaseControllerSettings
  {
    public string Heading;
    public string Description;
    public string WindControlerID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WindControllerSettings() => throw null;
  }
}
