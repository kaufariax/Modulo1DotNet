programa
{
	
	funcao inicio()
	{
		inteiro anos
		inteiro meses
		inteiro dias
		inteiro resultado
		
		escreva("Digite sua idade em anos: ")
		leia(anos)

		escreva ("Digite sua idade em meses: ")
		leia(meses)

		escreva ("Digite sua idade em dias: ")
		leia(dias)

		anos = anos*365
		meses = meses*30
		dias = dias
		resultado = (anos + meses + dias)

		escreva(resultado)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 301; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */