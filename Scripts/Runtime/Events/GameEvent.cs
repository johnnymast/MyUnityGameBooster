using System.Collections.Generic;
using GameBooster.Events.Components;
using UnityEngine;

namespace GameBooster.Events
{

    [CreateAssetMenu(menuName = "Game Event", fileName = "New game Event")]
    public class GameEvent : ScriptableObject
    {
        HashSet<GameEventListener> _listeners = new HashSet<GameEventListener>();

        /// <summary>
        /// Raise the event on the registered event listeners.
        /// </summary>
        public void Invoke()
        {
            foreach (var globalEvent in _listeners)
            {
                globalEvent.RaiseEvent();
            }
        }

        /// <summary>
        /// Add a GameEventListener to our _listeners HashSet
        /// </summary>
        /// <param name="gameEventListener"></param>
        public void Register(GameEventListener gameEventListener) => _listeners.Add(gameEventListener);

        /// <summary>
        /// Remove a GameEventListener from our _listeners HashSet
        /// </summary>
        /// <param name="gameEventListener"></param>
        public void DeRegister(GameEventListener gameEventListener) => _listeners.Remove(gameEventListener);
    }
}
