using UnityEngine;

namespace MyFps
{
    public class Bullet : MonoBehaviour
    {
        #region Variables
        [SerializeField]
        private float attackDamage = 5f;

        //임팩트 이펙트
        public GameObject hitImpactPrefab;
        #endregion

        #region Unity Event Method
        /*private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Pistol")
                return;

            Debug.Log($"========={other.tag}");

            IDamageable damageable = other.transform.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(attackDamage);
            }

            //Vfx
            if (hitImpactPrefab)
            {
                GameObject effectGo = Instantiate(hitImpactPrefab, transform.position, Quaternion.LookRotation(transform.forward * -1));
                Destroy(effectGo, 2f);
            }

            //kill
            Destroy(gameObject);
        }*/

        private void OnCollisionEnter(Collision collision)
        {
            IDamageable damageable = collision.transform.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(attackDamage);
            }

            //Vfx
            if (hitImpactPrefab)
            {
                GameObject effectGo = Instantiate(hitImpactPrefab, transform.position, Quaternion.LookRotation(transform.forward * -1));
                Destroy(effectGo, 2f);
            }

            //kill
            Destroy(gameObject);
        }
        #endregion
    }
}
