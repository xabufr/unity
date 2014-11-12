using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour
{

		public Transform origin;
		public Object bullet;
		public GameObject fire;
		private float lastShoot = 0;

		// Update is called once per frame
		void Update ()
		{
				if (Input.GetButton ("Fire1") && Time.realtimeSinceStartup - lastShoot > (1.0/4.0)) {
						lastShoot = Time.realtimeSinceStartup;
						GameObject newBullet = (GameObject)Instantiate (bullet, origin.position, origin.rotation);
						Destroy (newBullet, 1);
						newBullet.rigidbody.AddRelativeForce (Vector3.forward * 2000);
						foreach (MeshRenderer o in fire.GetComponentsInChildren<MeshRenderer>()) {
								o.enabled = true;
						}
				} else {
						
						foreach (MeshRenderer o in fire.GetComponentsInChildren<MeshRenderer>()) {
								o.enabled = false;
						}
				}
		}
}
