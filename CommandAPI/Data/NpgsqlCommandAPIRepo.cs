using System;
using System.Collections.Generic;
using System.Linq;
using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandAPI.Data
{
    public class NpgsqlCommandAPIRepo : ICommandAPIRepo
    {
        private readonly CommandContext _context;

        public NpgsqlCommandAPIRepo(CommandContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.CommandItems.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
