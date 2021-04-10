using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace GameBooster.Events.Components
{
    public class GameEventListenerWithDelay : GameEventListener
    {
        [FormerlySerializedAs("_delayedUnityEvent")] [SerializeField]
        UnityEvent delayedUnityEvent;

        [FormerlySerializedAs("_delayInSeconds")]
        public float delayInSeconds = 1f;

        /// <summary>
        /// Raise the registered Unity Event and then start
        /// the delay for the DelayedUnityEvent.
        /// </summary>
        /// <returns></returns>
        public override void RaiseEvent()
        {
            _unityEvent.Invoke();
            StartCoroutine(RunDelayedEvent());
        }

        /// <summary>
        /// Run the registered Delayed Event.
        /// </summary>
        /// <returns></returns>
        private IEnumerator RunDelayedEvent()
        {
            yield return new WaitForSeconds(delayInSeconds);
            delayedUnityEvent.Invoke();
        }
    }
}