using UnityEngine;

namespace Ship
{
    public class Health : MonoBehaviour
    {
        public GameController stats;
        
        private const int MIN_HEALTH = 0;
        
        public void TakeDamage(int damage)
        { 
            
            Debug.Log("Took some damage");
            stats.playerHealth = Mathf.Max(MIN_HEALTH, stats.playerHealth - damage);
        }
    }
}
