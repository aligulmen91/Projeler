﻿namespace _030Composition
{
    internal partial class Program
    {
        public class DbMigrator
        {
            private readonly Logger _logger;

           
            public DbMigrator(Logger logger)
            {
                _logger = logger;
              
               
            }
            public void Migrate()
            {
                _logger.Log("The migrating message");
                }
        }
    }
}
