using System.Collections;
using UnityEngine;

public class AttackState : BaseState
{
    private float moveTimer;
    private float losePlayerTimer;
    private float shotTimer;
    public AudioClip shootSound = Resources.Load("Sounds/Shoot") as AudioClip;

    public override void Enter()
    {
        moveTimer = 0;
        losePlayerTimer = 0;
        shotTimer = 0;
    }

    public override void Exit()
    {
        enemy.SetShooting(false);
    }

    public override void Perform()
    {
        if (enemy.CanSeePlayer())
        {
            losePlayerTimer = 0;
            moveTimer += Time.deltaTime;
            shotTimer += Time.deltaTime;
            enemy.transform.LookAt(enemy.Player.transform);
            enemy.Agent.SetDestination(enemy.Player.transform.position);

            if (shotTimer > enemy.fireRate && !enemy.isDying)
            {
                Shoot();
            }

            if (moveTimer > Random.Range(3, 7))
            {
                enemy.Agent.SetDestination(enemy.transform.position + (Random.insideUnitSphere * 5));
                moveTimer = 0;
            }
        }
        else
        {
            losePlayerTimer += Time.deltaTime;
            if (losePlayerTimer > 8)
            {
                stateMachine.ChangeState(new PatrolState());
            }
        }
    }

    private void Shoot()
    {
        Transform gunbarrel = enemy.gunBarrel;
        if (gunbarrel)
        {
            enemy.SetShooting(true);

            GameObject bullet = GameObject.Instantiate(Resources.Load("Prefabs/Bullet") as GameObject, gunbarrel.position, enemy.transform.rotation);
            Vector3 shootDirection = (enemy.Player.transform.position - gunbarrel.transform.position).normalized;
            AudioSource.PlayClipAtPoint(shootSound, enemy.Player.transform.position);
            bullet.GetComponent<Rigidbody>().velocity = Quaternion.AngleAxis(Random.Range(-3f, 3f), Vector3.up) * shootDirection * 40;

            Debug.Log("Shoot");
            shotTimer = 0;
            enemy.StartCoroutine(ResetShootingAnimation());
        }
    }

    private IEnumerator ResetShootingAnimation()
    {
        yield return new WaitForSeconds(0.1f);
        enemy.SetShooting(false);
    }
}
