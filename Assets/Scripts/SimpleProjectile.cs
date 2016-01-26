using UnityEngine;
public class SimpleProjectile : Projectile,ITakeDamage {

	public int Damage;
	public  GameObject DestroyedEffect;
	public int PointToGiveToPlayer;
	public float TimeToLive;
	public void Update()
	{
	
		if ((TimeToLive -= Time.deltaTime) <= 0) {
			DestroyProjectile();
			return;
		}
		transform.Translate ((Direction+ new Vector2(10f,0f))*Speed*Time.deltaTime,Space.World);

	}

	public void TakeDamage(int damage,GameObject instigator)
	{
		if (PointToGiveToPlayer != 0) {
				
			var projectile = instigator.GetComponent<Projectile>();

		
			   }
	}

	protected override void OnCollideOwner ()
	{
		DestroyProjectile();
	}

	protected override void OnCollideTakeDamage (Collider2D other, ITakeDamage takeDamage)
	{
		takeDamage.TakeDamage (Damage, gameObject);
		DestroyProjectile ();
	}

	private void DestroyProjectile()
	{

	
	if (DestroyedEffect != null) {
				
		
			Instantiate(DestroyedEffect,transform.position,transform.rotation);
				Destroy(gameObject);
		}
	}

}
