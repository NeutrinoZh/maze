using System;
using System.Collections;

using UnityEngine;

namespace MTK.Timer
{
    public class MTKTimer : MonoBehaviour
    {
        public void StartInterval(Action func, float interval)
        {
            StartCoroutine(StartIntervalCoroutine(func, interval));
        }

        private IEnumerator StartIntervalCoroutine(Action func, float interval)
        {
            while (true)
            {
                yield return new WaitForSeconds(interval);
                func?.Invoke();
            }
        }
    }
}
