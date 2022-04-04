﻿using System;
using System.Collections.Generic;
using System.Text;
using CS4227.Characters.Enemies;
using CS4227.Characters;


namespace CS4227.Visitor
{
    class SetDifficultyImpossibleVisitor : VisitorInterface
    {

        public void visit(BearEnemy bearEnemy)
        {
            bearEnemy.setHealth((int)(bearEnemy.getHealth() * 2));
            bearEnemy.setAttack((int)(bearEnemy.getHealth() * 2));
            Console.WriteLine("***VISITOR: Set Difficulty Visitor is called***");


        }

        public void visit(SnakeEnemy snakeEnemy)
        {
            snakeEnemy.setHealth((int)(snakeEnemy.getHealth() * 2));
            snakeEnemy.setAttack((int)(snakeEnemy.getHealth() * 2));
            Console.WriteLine("***VISITOR: Set Difficulty Visitor is called***");

        }

        public void visit(Player player)
        {
            player.setHealth((int)(player.getHealth() * .25));
            player.setAttack((int)(player.getHealth() * .25));
            Console.WriteLine("***VISITOR: Set Difficulty Visitor is called***");

        }
    }
}
