using Alura.Adopet.Console.Modelos;
using Alura.Adopet.Console.Util;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Adopet.Testes
{
    internal static class LeitorDeArquivosMock
    {
        public static Mock<LeitorDeArquivo> CriaMock(List<Pet> listaDePet)
        {
            var leitorDeArquivo = new Mock<LeitorDeArquivo>(MockBehavior.Default,
                It.IsAny<string>());

            leitorDeArquivo.Setup(_ => _.RealizaLeitura()).Returns(listaDePet);

            return leitorDeArquivo;
        }
    }
}
