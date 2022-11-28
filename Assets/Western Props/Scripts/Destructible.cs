// --------------------------------------
// This script is totally optional. It is an example of how you can use the
// destructible versions of the objects as demonstrated in my tutorial.
// Watch the tutorial over at http://youtube.com/brackeys/.
// --------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

	public GameObject destroyedVersion; // Reference to the shattered version of the object

	// If the player clicks on the object
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == ("bullet"))
		{
			// Spawn a shattered object
			Instantiate(destroyedVersion, transform.position, transform.rotation);
			// Remove the current object
			Destroy(gameObject);

		}

		else if (gameObject.tag == ("bottle"))
		{
				if (collision.gameObject.tag == ("floor"))
				{
					// Spawn a shattered object
					Instantiate(destroyedVersion, transform.position, transform.rotation);
					// Remove the current object
					Destroy(gameObject);
				}
			}
	}

}
