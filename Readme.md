# Criando uma APP de cadastro em memória

## Sequencia do que foi feito na Aplicação

1.Montamos uma classe EntidadeBase.cs que é uma classe abstrata para termos um ID para outras classes endarem dela

2.Classe Serie.cs erda do EntidadeBase.cs

3.Classe de repositorio(IRepositorio.cs) que imprementa uma interface e repositorio

4.Classe SerieRepositorio.cs para determinar que ele tenha os metodo de listagens e retonrar id's

5.Classe SerieRepositorio.cs é a que a gente vai utilizar no nosso programa principal(program.cs) e vamos utilizar sempre esse SerieRepositorio