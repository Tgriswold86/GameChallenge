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
            EndGame();
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
            var hero = _heroRepo.CharacterDetails();
            var enemy = _enemyRepo.CharacterDetails();

            while (hero.IsAlive && enemy.IsAlive)
            {
                PromptPlayer();
            }
        }

        private void PromptPlayer()
        {
            Console.WriteLine("Choose your next action:\n" +
                "1. Attack\n" +
                "2. Flee\n" +
                "3. Hide");

            var input = int.Parse(Console.ReadLine());

            HandleBattleInput(input);
        }

        private void HandleBattleInput(int input)
        {
            switch (input)
            {
                case 1:
                    Attack();
                    break;
                case 2:
                    Flee();
                    break;
                case 3:
                    Hide();
                    break;
                default:
                    break;
            }
        }

        private void Attack()
        {
            // Get characters attack values
            var hero = _heroRepo.CharacterDetails();
            var enemy = _enemyRepo.CharacterDetails();

            //Get hero attack value
            _enemyRepo.TakeDamage(hero.ATKPower);

            // Get new health points of enemy
            Console.WriteLine($"{enemy.Name}'s health is {enemy.Health}");

            // Then, the hero will strike.
            // Then, decrement points from enemy health.
            // Print details
        }

        private void Flee()
        {
            throw new NotImplementedException();
        }

        private void Hide()
        {
            throw new NotImplementedException();
        }

        private void EndGame()
        {
            throw new NotImplementedException();
        }

        private void CreateHero()
        {
            Console.WriteLine("What's your name, soldier?");

            string name = Console.ReadLine();

            _heroRepo.CreateCharacter(name);
        }
        private void CreateEnemy()
        {
            Console.WriteLine("Who's your enemy?\n");

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
