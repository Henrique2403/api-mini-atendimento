API em .NET 8 que simula um sistema simples de atendimento ao cliente. Inclui CRUD de clientes e atendimentos, autenticação JWT, integração com ViaCEP e logs com Serilog. Projeto criado para estudo prático de backend com ASP.NET Core.

# 📞 Atendimento API  

**Atendimento API** é uma Web API desenvolvida em **.NET 8** que simula um sistema simples de canais de atendimento ao cliente.  
O projeto tem como objetivo praticar conceitos fundamentais de desenvolvimento backend com **ASP.NET Core**, incluindo:  

- ✅ Criação de **APIs RESTful**  
- ✅ **CRUD** de clientes e atendimentos  
- ✅ **Relacionamento entre entidades** (Cliente → Atendimentos)  
- ✅ **Autenticação com JWT**  
- ✅ Integração com API externa (**ViaCEP**)  
- ✅ **Logs estruturados** com Serilog  

---

## 🚀 Objetivo  
Servir como estudo prático para fixar conceitos de desenvolvimento backend em .NET, simulando um cenário de CRM de atendimento ao cliente em diferentes canais (WhatsApp, e-mail, chat, etc.).  

---

## ⚙️ Como rodar o projeto  

### 1. Clonar o repositório  
```bash
git clone https://github.com/seu-usuario/atendimento-api.git
cd atendimento-api
```

---

### 2. Restaurar dependências
```bash
dotnet restore
```

---

### 3. Configurar banco de dados
No arquivo appsettings.json, configure a ConnectionStrings para usar seu SQL Server local ou SQLite.

---

### 4. Rodar migrations do Entity Framework
```bash
dotnet ef database update
```

---

### 5. Executar o projeto
```bash
dotnet run
```

---

### 6. Acessar no navegador

- Swagger: https://localhost:5001/swagger
- Endpoints principais:
    - /api/clientes
    - /api/atendimentos
 
---

# 📌 Exemplos de Payload

### Criar Cliente
```json
{
  "nome": "Henrique Cruz",
  "email": "henrique@email.com",
  "telefone": "11999999999",
  "cep": "01001000"
}
```

---

### Criar Atendimento
```json
{
  "clienteId": 1,
  "canal": "WhatsApp",
  "mensagem": "Preciso de ajuda com minha fatura",
  "status": "Aberto"
}
```
