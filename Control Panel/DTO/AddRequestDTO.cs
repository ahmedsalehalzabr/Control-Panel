﻿namespace Control_Panel.DTO
{
    public class AddRequestDTO
    {
        public required string Name { get; set; }

        public  string? Email { get; set; }

        public required string Phone { get; set; }

        public bool Favorite { get; set; }
    }
}
