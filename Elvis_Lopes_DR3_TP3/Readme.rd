Olá Elvis,

Nas etapas 5 e 6 de Desenvolvimento com serviços WCF e Microsoft Azure, você compreendeu o que é o banco de dados SQL do Azure 
e quais são as suas principais características. Também aprendeu a projetar uma aplicação simples que realiza acesso a um banco 
de dados SQL do Azure utilizando C# e ADO.NET. Você viu como os procedimentos armazenados podem ajudar a separar o código em SQL 
do código em C#.

Nesse TP03, você deve criar, com o Visual Studio, 

I) uma solução com um projeto do tipo ASP.NET Web Application (.NET Framework). 
II) Essa aplicação deve ser uma API web que 
III) fornece operações de criação, leitura, atualização e deleção de amigos. 
IV) Cada amigo deve possuir nome, sobrenome, e-mail, telefone e data de aniversário.
IV) Cada amigo deve possuir nome, sobrenome, e-mail, telefone e data de aniversário.

Essas operações devem ser persistidas em um banco de dados SQL do Azure, 
onde deve ser criada uma tabela para armazenar os dados de amigos. 
As operações devem ser implementadas como procedimentos armazenados e devem ser invocados a partir do código em C# na API web.
