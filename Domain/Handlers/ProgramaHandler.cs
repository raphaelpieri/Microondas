using Domain.Commands.Input;
using Domain.Commands.Result;
using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObject;
using Flunt.Notifications;
using Shareds.Commands;

namespace Domain.Handlers
{
    public class ProgramaHandler : Notifiable, ICommandHandler<NovoProgramaCommand>
    {
        private readonly IProgramaRepositorio _repositorio;

        public ProgramaHandler(IProgramaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public ICommandResult Handle(NovoProgramaCommand command)
        {
            RemoveAllNotifications();
            var tempo = new Tempo(command.Tempo);
            var potencia = new Potencia(command.Potencia);
            var caracter = new Caracter(command.Caracter);

            var aquecimento = new Aquecimento(tempo, potencia, caracter, command.Chave);
            var programa = new Programa(command.Nome, command.Instrucoes, aquecimento);

            AddNotifications(tempo.Notifications);
            AddNotifications(potencia.Notifications);
            AddNotifications(caracter.Notifications);

            var existePrograma = _repositorio.Get(programa.Nome) != null;
            if(existePrograma)
                AddNotification("Nome", "Ja existe um programa com o mesmo nome informado");

            if (Invalid)
                return new NovoProgramaResult(false, "Por favor corrija os campos abaixo", Notifications);

            _repositorio.Novo(programa);

            return new NovoProgramaResult(true, "Novo programa cadastrado com sucesso", new {Nome = programa.Nome});
        }
    }
}