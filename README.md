**Módulos de Instalação:**
- Desenvolvimento para Desktop com .NET
- Desenvolvimento com a Plataforma Universal Windows

**Windows Forms**
- RAD (Rapid Application Development)
- Qualquer linguagem que suporta CLS (Common Language Specification)
- Podemos Desenvolver usando um editor, mas usaremos o Visual Studio .NET

**Vantagens do Uso do Visual Studio:**
- Arrastar e soltar
- IntelliSense
- Debug Integrado
- Controle de Fonte

**Na arquitetura do .NET Framework, qual é a camada mais inferior, que faz acesso direto à plataforma Windows?** <br>
Common Language Runtime <br>
Acessa diretamente a plataforma Windows.

**Quais são as características que compõem um projeto em Windows Forms usando C#?**
- Idiomas: C#
- Plataformas: Windows
- Tipos de projeto: Área de Trabalho

Estas são as características que estão associadas a um projeto Windows Forms em C#.

**No projeto de Windows Forms, qual é a propriedade que está associada ao título da janela?**
- Text

Esta é a propriedade que está associada ao título da janela.

**Porque devemos criar um padrão para nomear componentes em um projeto Windows Forms?**
- Para melhor entendimento do programa, mas sem uma regra pré-definida para o padrão

O uso dos padrões melhora o entendimento do programa durante uma manutenção ou expansão, seja por você, que fez o programa, seja por outra pessoa do time de desenvolvimento. Mas este padrão não possui uma regra, o time de desenvolvimento é quem o especifica.

**Em que local nós podemos ver todos os eventos de um componente?**
- Na janela Propriedades, no botão Eventos

É aqui que os eventos de um componente podem ser visualizados.

**Qual é o processo que desenha, na prática, os componentes de um formulário?**
- A execução do InitializeComponent quando a classe do formulário é instanciada

É no InitializeComponent que as classes são desenhadas no formulário, no momento que o Form é instanciado.

**Qual a propriedade do TextBox que retorna o conteúdo do que foi digitado nele?**
- .Text

Esta é a propriedade que retorna o conteúdo do TextBox.

**Qual a propriedade que modifica a posição do componente no formulário?**
- Location

Esta é a propriedade que configura a posição do componente no formulário.

**Onde especificamos o formulário padrão do projeto?**
- No programa inicial

Nas propriedades do projeto, definimos o programa principal do projeto. E é dentro do código do programa inicial que especificamos o formulário padrão.

**Para classificar a senha, tivemos que adicionar um código que manipula expressões regulares. Para aceitar a manipulação de expressões regulares, que módulo do .NET tivemos que referenciar no projeto?**
- System.Text.RegularExpressions

Este é o módulo do .NET Framework para manipular expressões regulares.

**Como represento, a nível de código, a retirada do caractere que suprime o texto digitado, quando incluímos a senha no TextBox?**
- Txt_Senha.PasswordChar = '\0';

É com este símbolo que retiramos a supressão do caractere que esconde a senha.