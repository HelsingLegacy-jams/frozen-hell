﻿using UnityEngine;

namespace Code.Common.Extensions
{
  public static class VectorExtensions
  {
    public static Vector3 AddY(this Vector3 vector)
    {
      return new Vector3(vector.x, vector.y + 2f, vector.z);
    }
  }
}