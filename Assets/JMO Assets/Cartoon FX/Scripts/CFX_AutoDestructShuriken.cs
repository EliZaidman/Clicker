using UnityEngine;
using System.Collections;


[RequireComponent(typeof(ParticleSystem))]
public class CFX_AutoDestructShuriken : MonoBehaviour
{
	public bool OnlyDeactivate;
	
	void start()
	{
		StartCoroutine("CheckIfAlive");
	}
	
	IEnumerator CheckIfAlive ()
	{
		yield return new WaitForSeconds(2f);
		ParticleSystem ps = this.GetComponent<ParticleSystem>();
		
		while(true && ps != null)
		{
			yield return new WaitForSeconds(0.5f);
			if(!ps.IsAlive(true))
			{
				if(OnlyDeactivate)
				{
						this.gameObject.SetActive(false);

				}
				else
					GameObject.Destroy(this.gameObject);
				break;
			}
		}
	}
}
