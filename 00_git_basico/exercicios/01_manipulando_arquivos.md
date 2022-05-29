# Exercício: Manipulção de Arquivos

Neste exercício guiado faremos as operações mais básicas com arquivos no Git. Como vamos trabalhar pela linha de comando, é recomendado abrir o `Git Bash`na pasta do repositório que clonamos e executar os comandos que vamos demonstrar na ordem, para que as coisas façam sentido.

## 1) Criando um arquivo

Você pode criar o arquivo da meneira que quiser, usando o Windows Explorer, uma IDE como o Visual Studio ou pelo terminal. para exemplificar, simplesmente digite o seguinte comando no Git Bash:

```bash
ls -a
echo "hello, world!" > hello.txt
ls -a
cat hello.txt
```
O resultado final no console exibirá que o arquivo `hello.txt` foi criado e contém o texto `hello, world!`.

## 2) Gravando o Arquivo no Repositório

O arquivo `hello.txt`está criado em nosso computador, mas o Git ainda não está controlando ele. Para isso, precisamos realizar uma confirmação ou *Commit` no Git. Podemos fazer commit de um ou mais arquivos, e ainda podemos escolher mais mudanças nos arquivos queremos enviar neste momento. Para criar um commit contendo o novo arquivo `hello.txt` que criamos, devemos executar o seguinte script:

```bash
# exibe mudanças no diretório
git status
# Adiciona o arquivo hello.txt ao "stage"
git add hello.txt
# exibe novamente as mudanças
git status
# Efetiva a criação do commit
git commit -m "Criando hello.txt"
# exibe histórico de commits
git log
```

## 3) Alterando um Arquivo

Quando alteramos um arquivo, fazemos os mesmos passos. Vamos adicionar uma segunda linha em `hello.txt`.

```bash
# adiciona nova linha a hello.txt
echo "hello again!" >> hello.txt
# confirma alteração
cat hello.txt
git status
# repete os passos anteriores, agora para a mudança
git add hello.txt
git status
git commit -m "Modificando hello.txt"
git log
```
## 4) Visualizando um Commit

É possível visualizar as mudanças de cada commit com o commando `git show`. Para isto, visualize o log primeiro usando `git log` e copie o ID do commit que quer visualizar e depois invoque o comando usando a sintaxe abaixo, onde `COMMIT` é o ID que você copiou:

```bash
git show COMMIT
```

# 5) Comparando Commits

Nese caso a sintaxe é parecida com a do comando anterior, só que ássamos dois IDs de commits que queremos comparar:
```
id1=3342893dbb727b491ef11300848e9a6e4fbb6077
id2=151f5bfb9481822b5ba4004456bc69dcd8409572
git diff $id1 $id2
```
Note que neste exemplo `$id1` e `$id2` são o comando mais antigo e o mais novo, e a mudança deve ser destada em verde e com um sinal de `+` na frente. Se acidentalmente invertermos os IDs a diferença será exibida de maneira oposta, indicando que a linha foi removida (`-`).

## 6) Desfazendo uma mudança

Podemos ter errado ao adicionar a linha `hello again!` ao arquivo. Para voltar o repositório para um estado anterior, basta usar o seguinte comando, onde `ID` é o ID do commit para o qual desejamos voltar.:

```bash
git reset ID
```
Este comando mantém os arquivos com as mudanças, e volta o estado repositório como estava quando o commit fornecido como argumento foi criado. Os commits subsequentes foram apagados. Use este comando com muito cuidado!

Caso queira que o comando `git reset` volte os arquivos ao estado original do commit, isto é possível passando o argumento --hard, como no exmeplo abaixo:

```bash
# utilize com muito cuidado! os arquivos serão modificados!
git reset ID --hard
```

## 07) Git Ignore

É possível especificar regras para o Git ignorar o versionamento de arquivos e pastas com determinados nomes ou extensões. Isso é desejável porque quando criamos programas em C# ou outras linguagens costumam ser gerados diretórios e arquivos que não fazem parte do fonte, como os EXEs e DLLs compilados, os objetos intermediários da compilação etc. 

Para ignorar tais arquivos crie um arquivo chamado `.gitignore` na pasta de nível mais alto que desejamos que obedecça essa regra:

```bash
# Cria diretório bin para nosso executável
mkdir bin
# Simula criação de um programa dentro de bin
touch bin/program.exe
# prova que program.exe existe dentro de bin
ls bin
git status
# cria arquivo .gitignore com conteúdo "bin"
echo "bin" >> ".gitignore"
cat .gitignore
git status
# adiciona .gitignore ao stage
git add .gitignore
# cria commit de gitignore
git commit -m "Ignorando pasta bin"
git log
```

## Conclusão

Aprendemos aqui os comandos mais básicos do Git. No [próximo exercício](./02_trabalhando_com_branches.md) vamos apender como criar e manipular branches.