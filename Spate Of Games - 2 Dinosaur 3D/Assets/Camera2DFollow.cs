using UnityEngine;
using System.Collections;
// modified camera follow from unity sample assets

namespace UnitySampleAssetsModified
{
    /*
     * target = FindObjectOfType<PlayerController>().transform;
     */
    public class Camera2DFollow : MonoBehaviour
    {

        public Transform target;
        public float damping = 1;
        public float lookAheadFactor = 3;
        public float lookAheadReturnSpeed = 0.5f;
        public float lookAheadMoveThreshold = 0.1f;

		private Vector3 offsetY;
		private float offsetZ;
        private Vector3 lastTargetPosition;
        private Vector3 currentVelocity;
        private Vector3 lookAheadPos;

        /*
        // Use this for initialization
        private void Awake()
        {
            //target = FindObjectOfType<PlayerController>().transform;
            GlobalEventManager.OnPlayerDie.AddListener(FindPlayerAct);
            lastTargetPosition = target.position;

			// offset view height
			offsetY = (transform.position - target.position);
			offsetY.x=0;
			offsetY.z=0;


            offsetZ = (transform.position - target.position).z;
            transform.parent = null;
        }
        */
        private void Start()
        {
            
            //target = FindObjectOfType<PlayerController>().transform;
            //GlobalEventManager.OnPlayerDie.AddListener(FindPlayerAct);
            lastTargetPosition = target.position;

            // offset view height
            offsetY = (transform.position - target.position);
            offsetY.x = 0;
            offsetY.z = 0;


            offsetZ = (transform.position - target.position).z;
            transform.parent = null;
        }

        // Update is called once per frame
        private void LateUpdate()
        {
            if (target)
            {

                transform.position = new Vector3(transform.position.x, transform.position.y, target.position.z + 10f);



                /*
                // only update lookahead pos if accelerating or changed direction
                float xMoveDelta = (target.position - lastTargetPosition).x;

                bool updateLookAheadTarget = Mathf.Abs(xMoveDelta) > lookAheadMoveThreshold;

                if (updateLookAheadTarget)
                {
                    lookAheadPos = lookAheadFactor * Vector3.right * Mathf.Sign(xMoveDelta);
                }
                else
                {
                    lookAheadPos = Vector3.MoveTowards(lookAheadPos, Vector3.zero, Time.deltaTime * lookAheadReturnSpeed);
                }

                Vector3 aheadTargetPos = target.position + lookAheadPos + Vector3.forward * offsetZ + offsetY;
                Vector3 newPos = Vector3.SmoothDamp(transform.position, aheadTargetPos, ref currentVelocity, damping);

                transform.position = newPos;

                lastTargetPosition = target.position;
                */
            }
        }

        public void FindPlayerAct()
        {
            StartCoroutine(FindPlayer());
        }

        public IEnumerator FindPlayer()
        {
            yield return new WaitForSeconds(1f);
            Debug.Log("FindPlayer");
            //target = FindObjectOfType<PlayerController>().transform;
            if (target)
            {
                Debug.Log("Find");
            }
            else
            {
                Debug.Log("No");
            }
        }
        

    }
}