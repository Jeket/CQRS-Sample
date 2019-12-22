﻿using CQRS_Command.Core;

namespace CQRS_Command.Commands
{
    public class EditCategoryCommand : ICommand
    {
        public EditCategoryCommand(int CategoryId, string name, string description)
        {
            this.CategoryId = CategoryId;
            this.Name = name;
            this.Description = description;
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}