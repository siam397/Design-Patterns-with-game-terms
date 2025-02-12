﻿namespace Design_Patterns.Behavioral.ChainofResponsibility.LoggerChain
{
    public class InfoLogger : Logger
    {
        public InfoLogger(int level)
        {
            _level = level;
        }

        public override void Write(string message)
        {
            Console.WriteLine("INFO :: " + message);
        }
    }
}
