﻿// Decompiled with JetBrains decompiler
// Type: UnityEditor.SpaceDrawer
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 01B28312-B6F5-4E06-90F6-BE297B711E41
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEditor.dll

using UnityEngine;

namespace UnityEditor
{
  [CustomPropertyDrawer(typeof (SpaceAttribute))]
  internal sealed class SpaceDrawer : DecoratorDrawer
  {
    public override float GetHeight()
    {
      return (this.attribute as SpaceAttribute).height;
    }
  }
}