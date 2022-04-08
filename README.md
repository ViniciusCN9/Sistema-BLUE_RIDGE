# Gerenciador de eventos BLUE RIDGE

Projeto simulador de um sistema informático para casas de eventos.

### Tecnologias utilizadas
 
- .NET 5.0
- ASP.NET Core
- EF Core 5.0
- Identity
- MySql 8.0
- HTML, CSS
- Javascript, JQuery

## Configurações iniciais

### Senha de usuário do banco de dados

Arquivo *appsettings.json* -> Propriedade *"ConnectionStrings":*

### Dados cadastrados

**Administrador**

- Email: admin@admin.com
| Senha: admin

**Usuários**

- Email: user@user.com
| Senha: user

- Email: pedro@user.com
| Senha: pedro

- Email: maria@user.com
| Senha: maria

## Funcionalidades

### Permissões

Usuários com a permissão de admin podem fazer cadastros, monitorar eventos e vendas, e dar/retirar permissões a outros usuários.

Usuários comuns podem ver os eventos cadastrados, comprar ingressos e monitorar suas compras.

### Cadastros

Podem ser cadastrados: gêneros musicais, estabelecimentos e eventos.

### Compras

O sistema de compra conta com validações lógicas e as informações ficam armazenadas no banco de dados.

### Dashboard

Está disponível para os administradores e possúi uma interface para melhor acompanhamento das vendas relacionadas a cada evento.

### Imagens

Cada evento pode receber uma imagem e está será visualizada pelo usuário comum.
As imagens de evento ficam salvas na pasta [Assets/img](wwwRoot/Assets/img).

## Considerações

O projeto proporcionou o avanço dos conhecimentos no padrão MVC e na tecnologia ASP.NET.
