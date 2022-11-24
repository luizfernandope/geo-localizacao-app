﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppRpgEtec.Models
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordString { get; set; }
        public string Perfil { get; set; }
        public string Token { get; set; }
        public byte[] Foto { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Email { get; set; }
    }
}
