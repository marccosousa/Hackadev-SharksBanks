﻿using AutoMapper;
using SharkBank.API.Domain.DTO;
using SharkBank.API.Domain.Models;

namespace SharkBank.API.Domain.Profiles
{
    public class UsuarioProfile: Profile
    {
        public UsuarioProfile () 
        {
            CreateMap<Usuario, UsuarioDTO>().
                ForMember(usuarioDTO => usuarioDTO.Conta, opt => opt.MapFrom(usuario => usuario.Conta));
            CreateMap<Usuario, UsuarioReduzidoDTO>();
            CreateMap<LoginDTO, Usuario>();
            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<Transacao, TransacaoDTO>();
            CreateMap<Conta, ContaDTO>()
                .ForMember(dest => dest.Transacoes, opt => opt.MapFrom(src => src.Transacoes));
            CreateMap<Conta, ContaReduzidaDTO>(); 
        }
    }
}
