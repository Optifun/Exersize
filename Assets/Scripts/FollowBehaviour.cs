using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class FollowBehaviour : MonoBehaviour
    {
        public Transform Target;

        public Vector2 Boundary;

        public void Follow(Transform target)
        {
            Target = target;
        }

        private void Update()
        {
            if (Target == null)
                return;

            Vector3 delta = Target.position - transform.position;

            if (Mathf.Abs(delta.x) >= Boundary.x || Mathf.Abs(delta.y) >= Boundary.y)
                transform.position = transform.position + delta * Time.deltaTime;
        }

        private void OnDrawGizmos()
        {
            var hOffset = new Vector3(Boundary.x, 0, 0);
            var vOffset = new Vector3(0, Boundary.y, 0);
            Vector3 center = transform.position;

            var defaultColor = Gizmos.color;
            Gizmos.color = Color.green;

            // right up -> right down
            Gizmos.DrawLine(center + hOffset + vOffset, center + hOffset - vOffset);
            Gizmos.DrawLine(center - hOffset - vOffset, center + hOffset - vOffset);
            Gizmos.DrawLine(center - hOffset - vOffset, center - hOffset + vOffset);
            Gizmos.DrawLine(center - hOffset + vOffset, center + hOffset + vOffset);
            Gizmos.color = defaultColor;
        }
    }
}