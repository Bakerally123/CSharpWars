﻿using System;

namespace CSharpWars.Model
{
    public class Bot
    {
        public Guid Id { get; set; }
        public Int32 SysId { get; set; }
        public String Name { get; set; }
        public Int32 LocationX { get; set; }
        public Int32 LocationY { get; set; }
        public Orientation Orientation { get; set; }
        public Int32 MaximumHealth { get; set; }
        public Int32 CurrentHealth { get; set; }
        public Int32 MaximumStamina { get; set; }
        public Int32 CurrentStamina { get; set; }
        public String Script { get; set; }
        public String Memory { get; set; }
        public Move PreviousMove { get; set; }
        public virtual Player Team { get; set; }
    }
}