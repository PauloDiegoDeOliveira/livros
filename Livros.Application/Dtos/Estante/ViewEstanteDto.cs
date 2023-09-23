﻿using Livros.Application.Dtos.Obra;
using Livros.Domain.Enums;

namespace Livros.Application.Dtos.Lista
{
    public class ViewEstanteDto
    {
        public string UsuarioId { get; set; }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Publico { get; set; }
        public EStatus Status { get; set; }

        public IList<ViewObraDto> Obras { get; set; }
    }
}