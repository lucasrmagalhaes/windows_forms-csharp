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

**Em um computador configurado com o idioma português, qual seria a máscara para eu ter uma data no formato YYYY.MM.DD (separados por pontos)?**
- 0000,00,00

Como o computador é em português, se eu colocar a vírgula, ele vai encarar como o separador de milhar, logo ele vai colocar o valor como 0000.00.00.

**Tenho que validar, em uma caixa de texto com máscara, a digitação de até 10 números. Construo a máscara 0000000000, mas, também, quero validar que não posso digitar letras. O que mais eu devo fazer?**
- Não é necessário fazer nada

A máscara já testa se digitamos até 10 números, sem precisar complementar com nada mais.

**Como nós podemos copiar formulários?**
- Copiando o conteúdo da rotina InitializeComponent do formulário

Esta é a forma mais correta de copiar um formulário.

**Porque é mais produtivo criar uma classe de funções para usar uma função específica?**
- Porque esta função vai poder ser usada por todos os formulários e facilitar a manutenção

Esta é razão de usar as funções em uma classe.

**Tenho uma caixa de diálogo que possui o botão AbortRetryIgnore. Se o usuário clicar no botão Abort, como eu verifico se esse botão foi clicado?**
- if (MessageBox(<Parametro do MessageBox>) == DialogResult.Abort)

É usando o DialogResult que identificamos o botão que foi clicado. Temos que comparar esta constante com o resultado da função MessageBox.

**Qual o evento que tenho que executar para abrir um formulário a partir de um clique de um botão?**
- .ShowDialog();

Este é o evento que devemos chamar para abrir um formulário a partir do clique de um botão.

**Sobre a adição de ícones (arquivos .ico) em um formulário e imagens (arquivos .png) em um botão, selecione as alternativas corretas:**
- Para adicionar ícones, usamos a propriedades Icon, de um formulário
- Para adicionar imagens, usamos a propriedades Image, de um botão

**Como nós associamos um ícone ao projeto?**
- Associamos o ícone nas propriedades do projeto

É desta maneira que associamos um ícone ao projeto.

**Qual a extensão do arquivo que representa uma solução do Visual Studio?**
- .sln

Esta é a extensão que representa uma solução do Visual Studio.

**Quando temos mais de um projeto na nossa solução, como identificamos o projeto principal, apenas olhando o Gerenciador de Soluções?**
- O projeto cujo nome estiver em negrito será o projeto principal.

A maneira mais fácil de identificar o projeto principal é verificando aquele cujo nome está em negrito.

**O que preciso fazer para referenciar uma classe de um projeto em um formulário que está dentro de outro projeto?**
- No projeto do formulário, devemos adicionar a referência ao projeto da classe e, no código fonte do formulário, devemos usar o comando using

Estes são os dois passos que devem ser seguidos para fazer a referência de um projeto em outro projeto.

**O que é preciso ser feito para podermos adicionar uma imagens a um item do menu?**
- Adicionar a imagem ao projeto e adicioná-la à propriedade Image, do item de menu

São estes os passos para adicionar as imagens aos recursos do projeto.

**Sobre as teclas de atalho, selecione a alternativa correta.**
- Podemos associar três teclas a um atalho

Pelo menos uma das teclas Ctrl, Alt e Shift deve ser escolhida para o atalho. Ou seja, podemos ter uma, duas ou todas elas no atalho, podendo escolher algo como Alt + Ctrl + B como atalho.

**Qual o evento que representa a escolha do item do menu?**
- Click

Este é o evento que representa a escolha da opção do menu.

**Como chamamos um formulário para que ele seja apresentado na área de formulários MDI, sem impedir que outros formulários sejam chamados?**
- .Show

Este é o método correto para abrir um formulário e permitir que outros também sejam abertos.

**Sobre formulários User Control, selecione a alternativa verdadeira:**
- Eles têm os mesmos componentes de um formulário Windows Forms

Tanto é que, na aula, copiamos todos os componentes de um formulário Windows Forms para um User Control.

**Como adicionamos uma imagem em uma TabPage?**
- Associando a sua TabControl a uma ImageList e escolhendo o número do índice da imagem na propriedade ImageIndex, da TabPage

É assim que associamos uma imagem à TabPage.

**Qual é o parâmetro que tenho que colocar para remover uma TabPage, no método .Remove?**
- Uma variável do tipo TabPage

Temos que ter uma variável instanciando a própria TabPage que desejamos excluir. No exemplo, usamos o comando .SelectedTab, que retorna a própria TabPage selecionada.

[PNG - ICO](https://convertico.com/)

**Como nos referenciamos a uma imagem, que está na área de recursos da solução, pelo seu nome?**
- Image MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);

É assim que nos referenciamos a uma imagem da área de recursos.

**Se, ao usar a OpenFileDialog, quero visualizar somente arquivos de texto (TXT), como devo representar isso no seu filtro de arquivos?**
```Db.Filter = "TXT|*.TXT";```

É desta forma que representamos o filtro de arquivos da caixa de diálogo OpenDialogBox.