using UnityEngine;
using UnityEngine.Events;


namespace GameBooster.Events.Components
{
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField] public GameEvent _gameEvent;
        [SerializeField] public UnityEvent _unityEvent;

        /// <summary>
        /// On Awake Register the GameEventListener to the linked event.
        /// </summary>
        public void Awake() => _gameEvent.Register(this);

        /// <summary>
        /// On Destroy Register the GameEventListener to the linked event.
        /// </summary>
        public void OnDestroy() => _gameEvent.DeRegister(this);

        /// <summary>
        ///  Raise the Unity Event
        /// </summary>
        public virtual void RaiseEvent() => _unityEvent.Invoke();
    }
}