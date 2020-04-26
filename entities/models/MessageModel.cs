﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmsDotNet.Entities
{
    class MessageModel
    {
        [ForeignKey("User")]
        public int IdOwner { get; set; }
        public UserModel Owner { get; set; }

        [ForeignKey("User")]
        public int IdTarget { get; set; }
        public UserModel Target { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Message { get; set; }

        public ReadableBy Status { get; set; }

        public DateTime Date { get; set; }
    }

    enum ReadableBy
    {
        all,
        owner,
        target,
        nobody
    }
}
