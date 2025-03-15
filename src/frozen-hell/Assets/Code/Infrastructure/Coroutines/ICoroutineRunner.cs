using System.Collections;
using UnityEngine;

namespace Code.Infrastructure.Coroutines
{
  public interface ICoroutineRunner
  {
    Coroutine StartCoroutine(IEnumerator enumerator);
  }
}