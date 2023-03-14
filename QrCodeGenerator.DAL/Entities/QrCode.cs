﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCodeGenerator.DAL.Entities
{
    public class QrCode : BaseEntity
    {
        public byte[] Code { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}