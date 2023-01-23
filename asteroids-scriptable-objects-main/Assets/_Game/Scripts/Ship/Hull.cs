using DefaultNamespace.ScriptableEvents;
using UnityEngine;
using Variables;

namespace Ship
{
    public class Hull : MonoBehaviour
    {
        //[SerializeField] private IntVariable _health;
        [SerializeField] private ScriptableEventIntReference _onHealthChangedEvent;
        [SerializeField] private IntReference _healthRef;
        [SerializeField] private IntObservable _healthObservable;
        [SerializeField] private Health hp;
        
        public GameController stats;

        private void Start()
        {
            _healthObservable.ApplyChange(-_healthObservable.Value+stats.playerHealth);
        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (string.Equals(other.gameObject.tag, "Asteroid"))
            {
                if(stats.godmode == false)
                {
                    Debug.Log("Hull collided with Asteroid");
                    // TODO can we bake this into one call?
                    //_healthRef.ApplyChange(-1);
                    //_onHealthChangedEvent.Raise(_healthRef);
                    hp.TakeDamage(stats.asteroidDmg);
                    _healthObservable.ApplyChange(-stats.asteroidDmg);
                }
                
            }
        }
    }
}
