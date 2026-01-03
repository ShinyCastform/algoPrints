public class Temperature : MonoBehaviour
{

	public Health health;
public int playerDamage = 2;
	public float temperatureCurrent = 36.6f;
	public float temperatureNormal = 36.6f;
	public float temperatureCritical = 34f;
	public float freezeSpeed = 0.05f;

	void Update()
	{
		temperatureCurrent -= freezeSpeed * Time.deltaTime;
 
		if (temperatureCurrent <= temperatureCritical)
		{
			health.TakeDamage(playerDamage);
		}
	}
}
