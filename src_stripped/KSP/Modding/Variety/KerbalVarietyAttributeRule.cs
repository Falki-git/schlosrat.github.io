﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modding.Variety.KerbalVarietyAttributeRule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Modding.Variety
{
  public struct KerbalVarietyAttributeRule
  {
    public string attributeName;
    public List<string> dependsOn;
    public string attributeRangeRuleKey;
    public string preGenerationFunction;
    public string applyFunction;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KerbalVarietyAttributeRule Defaults() => throw null;
  }
}
