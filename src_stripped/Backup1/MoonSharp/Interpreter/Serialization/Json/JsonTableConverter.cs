﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Serialization.Json.JsonTableConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Tree;
using System.Runtime.CompilerServices;
using System.Text;

namespace MoonSharp.Interpreter.Serialization.Json
{
  public static class JsonTableConverter
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string TableToJson(this Table table) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void TableToJson(StringBuilder sb, Table table) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ObjectToJson(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ValueToJson(StringBuilder sb, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string EscapeString(string s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsValueJsonCompatible(DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Table JsonToTable(string json, Script script = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AssertToken(Lexer L, TokenType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Table ParseJsonArray(Lexer L, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Table ParseJsonObject(Lexer L, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue ParseJsonValue(Lexer L, Script script) => throw null;
  }
}
