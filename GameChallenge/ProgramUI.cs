using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameChallenge
{
    class ProgramUI
    {
        private HeroRepository _heroRepo = new HeroRepository();
        private EnemyRepository _enemyRepo = new EnemyRepository();
        
        public void Run()
        {
            SetUpGame();
            RunGame();
        }
        private void SetUpGame()
        {
            CreateHero();
            CreateEnemy();
            ShowHeroDetails();
            ShowEnemyDetails();
        }
        private void RunGame()
        {
            bool ran = false;
            var hero = _heroRepo.CharacterDetails();
            var enemy = _enemyRepo.CharacterDetails();
            while (hero.CheckIfAlive(hero.Health) && enemy.CheckIfAlive(enemy.Health))
            {
                var input = PromptPlayer();
                switch (input)
                {
                    case 1:
                        Attack();
                        break;
                    case 2:
                        ran = true;
                        goto Runner;
                    default:
                        break;
                }
            }
            EndGame();
            Runner:
           if(ran)
            {
                 Flee();
                ran = false;
            }
        }
        private int PromptPlayer()
        {
            Console.WriteLine("Choose your next action:\n" +
                "1. Attack\n" +
                "2. Flee");
            var input = int.Parse(Console.ReadLine());
            return input;
            
        }
        private void Attack()
        {
           
            // Get characters attack values
            var hero = _heroRepo.CharacterDetails();
            var enemy = _enemyRepo.CharacterDetails();
            //Get hero attack value
            _enemyRepo.TakeDamage(hero.ATKPower);
            _heroRepo.TakeDamage(enemy.ATKPower);
            // Get new health points of enemy
            Console.WriteLine($"{enemy.Name}'s health is {enemy.Health}");
            Console.WriteLine($"{hero.Name}'s health is {hero.Health}");
            // Then, the hero will strike.
            // Then, decrement points from enemy health.
            // Print details
        }

        private void Flee()
        {
            Console.WriteLine($"You ran from {_enemyRepo.CharacterDetails().Name}!");
            Console.ReadLine();
           
        }
        private void EndGame()
        {

            Console.WriteLine($"You defeated {_enemyRepo.CharacterDetails().Name}!");
            Console.Read();
        }
        private void CreateHero()
        {
            Console.WriteLine("What's your name, soldier?");
            string name = Console.ReadLine();
            _heroRepo.CreateCharacter(name);
        }
        private void CreateEnemy()
        {
            Console.WriteLine("Who are we hunting?\n");
            string name = Console.ReadLine();
            _enemyRepo.CreateCharacter(name);
        }
        private void ShowHeroDetails()
        {
            Console.WriteLine("Here are the details for your Hero:");
            var hero = _heroRepo.CharacterDetails();
            Console.WriteLine($"Character Details: " +
                $"Name: {hero.Name}\n" +
                $"Health: {hero.Health}\n" +
                $"Attack Power: {hero.ATKPower}\n");
        }
        private void ShowEnemyDetails()
        {
            Console.WriteLine("Here are the details for the enemy:");
            var enemy = _enemyRepo.CharacterDetails();
            Console.WriteLine($"Character Details: " +
            $"Name: {enemy.Name}\n" +
            $"Health: {enemy.Health}\n" +
            $"Attack Power: {enemy.ATKPower}\n");
        }
    }
}