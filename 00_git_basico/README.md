# Git Básico

## Introdução
O Git é um sistema distribuído de controle de versão de códigos-fontes. Usamos programas deste tipo para facilitar a gestão das mudanças que realizamos nos programas que escrevemos, e simplificar o trabalho em equipe.

## Instalando o Git for Windows

Instalar o Git em computadores Windows é extremamente fácil. Basta entrar no site do [Git for Windows](https://gitforwindows.org/) e clicar em **Download**. isso iniciará o download do instalador do Git.

Após o download, inicie o instalador e siga os passos deixando todas as opções no padrão. Não se preocupe em mudar nada.

## Criando uma Conta no GitHub

O [GitHub](https://github.com/) é a maior comunidade de código aberto da atualidade. Muitos projetos ficam hospedados nele, e os componentes mais usados em várias linguagensde programação tem seus fontes, documentação, e suporte baseados no GitHub.

Crie uma conta neste site para hospedar os trabalhos que desenvolverá ao longo dos tutoriais.

## Criando seu primeiro repositório

Com a conta criada no GitHub, clique no seu retrato no canto superior direito da tela do GitHun e escolha a opção do menu que diz *Your Repositories*. Na página que carregar, clique no botão verde *New*, dê um nome criativo ao seu repositório e clique no próximo botão verde *Create Repository*.

## Clonando Seu Repositório

1) Na página do seu repositório haverá um botão verde (sempre os botões verdes!) escrito *Code*. Clique nele e copie a URL que aparece na caixa de texto ou simplesmente clique no ícone de copiar ao lado.
2) Escolha uma pasta no seu computador (ex: `C:\Projetos`) e clique com o botão direito do mouse dentro dela. No menu de contexto haverá uma opção *Open Git Bash*, que abrirá um terminal já posicionado nesta pasta de projeto.
3) Digite `git clone`, dê um espaço e pressione a tecla *Insert* no seu teclado para colar a URL do repositório que você copiou previamente. A linha deverá ficar algo assim:

```bash
git clone https://github.com/fabiogusmao/tutoriais-dotnet.git
```

Após o Git trabalhar você terá uma nova pasta no seu diretório de projetos. Para mudar para ela no Git Bash digite o comando `cd` seguido do nome do repositório.

## Exercícios

Os próximos conceitos serão explicados através de exercícios rápidos. Há muita documentação sobre o funcionamento do Git na Internet, mas uma abordagem mais prática ás vezes pode facilitar o entendimento.


1) [Manipulando Arquivos](./exercicios/01_manipulando_arquivos.md)
2) [Trabalhando com branches](./exercicios/02_trabalhando_com_branches.md)
