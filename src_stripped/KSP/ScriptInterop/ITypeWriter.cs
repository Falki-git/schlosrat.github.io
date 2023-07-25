﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.ITypeWriter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Text;

namespace KSP.ScriptInterop
{
  public interface ITypeWriter
  {
    string Write(DynValue value);

    string Write(DynValue value, FormatOptions options);

    bool Write(DynValue value, StringBuilder stringBuilder);

    bool Write(DynValue value, StringBuilder stringBuilder, FormatOptions options);
  }
}
