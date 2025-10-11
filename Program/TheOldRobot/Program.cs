// See https://aka.ms/new-console-template for more information

namespace TheOldRobot
{
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }
        public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];

        public void SetCommands(int index, IRobotCommand command)
        {
            if (index >= 0 && index < Commands.Length)
                Commands[index] = command;
        }
        
        public void Run()
        {
            foreach (IRobotCommand? command in Commands)
            {
                command?.Run(this);
                Console.WriteLine($"[{X} {Y} {IsPowered}]");
            }
        }
    }

    public interface IRobotCommand
    {
        void Run(Robot robot);
    }

    public class OnCommand : IRobotCommand
    {
        public void Run(Robot robot) => robot.IsPowered = true;
    }

    public class OffCommand : IRobotCommand
    {
        public void Run(Robot robot) => robot.IsPowered = false;
    }

    public class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        { 
            if(robot.IsPowered) robot.Y += 1;
        }
    }
    
    public class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot) { 
            if(robot.IsPowered) robot.Y -= 1;
        }
    }
    
    public class WestCommand : IRobotCommand
    {
        public void Run(Robot robot) { 
            if(robot.IsPowered) robot.X -= 1;
        }
    }
    
    public class EastCommand : IRobotCommand {
        public void Run(Robot robot) { 
            if(robot.IsPowered) robot.X += 1;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Robot robot = new Robot();
            var commands = new IRobotCommand[3];
            
            Console.WriteLine("Enter 3 commands (options: on, off, north, south, east, west):");
            int count = 0;
            while (count < 3)
            {
                Console.Write($"Command {count + 1}: ");
                string? input = Console.ReadLine();

                switch (input?.ToLower())
                {
                    case "on":
                        commands[count] = new OnCommand();
                        break;
                    case "off":
                        commands[count] = new OffCommand();
                        break;
                    case "north":
                        commands[count] = new NorthCommand();
                        break;
                    case "south":
                        commands[count] = new SouthCommand();
                        break;
                    case "east":
                        commands[count] = new EastCommand();
                        break;
                    case "west":
                        commands[count] = new WestCommand();
                        break;
                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        continue;  
                }

                count++;
            }
            for (int i =0; i<3; i++)
                robot.SetCommands(i, commands[i]);
            
            Console.WriteLine("\nRunning robot...");
            robot.Run();
        }
    }
}