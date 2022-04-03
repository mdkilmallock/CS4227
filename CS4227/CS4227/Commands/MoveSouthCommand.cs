﻿using System;
using System.Collections.Generic;
using System.Text;
using CS4227.Constructs;
using CS4227.Facade;

namespace CS4227.Commands
{
    class MoveSouthCommand : Command
    {
        MazeFacade maze;

        public MoveSouthCommand(MazeFacade maze)
        {
            this.maze = maze;
        }

        public void execute()
        {
            maze.movePlayerSouth();
        }

        public void undo() { }

        public string getType()
        {
            return "MoveSouth";
        }
    }
}
