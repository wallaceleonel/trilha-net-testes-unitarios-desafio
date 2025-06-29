using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        Assert.False(resultado);
    }

    [Fact] // Corrigido!
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

        var resultado = _validacoes.MultiplicarElementosPorDois(lista);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };

        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };

        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        Assert.Equal(-8, resultado);
    }

    public class ValidacoesLista
{
    public List<int> RemoverNumerosNegativos(List<int> lista) =>
        lista.Where(n => n >= 0).ToList();

    public bool ListaContemDeterminadoNumero(List<int> lista, int numero) =>
        lista.Contains(numero);

    public List<int> MultiplicarElementosPorDois(List<int> lista) =>
        lista.Select(n => n * 2).ToList();

    public int RetornarMaiorNumeroLista(List<int> lista) =>
        lista.Max();

    public int RetornarMenorNumeroLista(List<int> lista) =>
        lista.Min();
}

}
