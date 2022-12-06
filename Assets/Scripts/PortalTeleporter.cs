using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour {

	public Transform player;
	public Transform reciever;
	public bool debug;
	private bool playerIsOverlapping = false;
	public AudioSource warpSound;
	public bool angleHit;
	// Update is called once per frame
	void Update () {
		if (playerIsOverlapping)
		{
			Vector3 portalToPlayer = player.position - transform.position;
			float dotProduct = Vector3.Dot(transform.up, portalToPlayer);
			if (debug)
			{
				print(dotProduct);
			}
			// If this is true: The player has moved across the portal
			if (dotProduct < 0f)

			{
				warpSound.Play();
				if (debug)
				{
					print("2");
				}
				// Teleport him!
				float rotationDiff = -Quaternion.Angle(transform.rotation, reciever.rotation);
				rotationDiff += 180;
				player.Rotate(Vector3.up, rotationDiff);

				Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;

				if (angleHit)
				{
					var relativeIntersectY = (transform.position.z + (20 / 2)) - player.transform.position.z;

					var normalizedRelativeIntersectionY = (relativeIntersectY - (20 / 2));
					var bounceAngle = normalizedRelativeIntersectionY * 7.5f;

					float ballVx = 40 * Mathf.Cos(bounceAngle);
					float ballVy = 40 * -Mathf.Sin(bounceAngle);

					player.GetComponent<Rigidbody>().velocity = new Vector3(-player.GetComponent<Rigidbody>().velocity.x, player.GetComponent<Rigidbody>().velocity.y, -ballVy);
				}
				else {
					player.GetComponent<Rigidbody>().velocity = new Vector3(player.GetComponent<Rigidbody>().velocity.x, player.GetComponent<Rigidbody>().velocity.y, player.GetComponent<Rigidbody>().velocity.z);
				}
				player.position = reciever.position + positionOffset;
				playerIsOverlapping = false;
			}
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Ball")
		{
			playerIsOverlapping = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Ball")
		{
			playerIsOverlapping = false;
		}
	}
}
