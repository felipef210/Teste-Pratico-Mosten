# 🎬 MostenMovies&Series

Bem-vindo ao **MostenMovies&Series**! Este projeto é composto por uma API em .NET 8 (MoviesMostenAPI) e uma aplicação web Angular (MoviesMostenAPP) para gerenciamento e exibição de filmes e séries.

---

## 📚 Funcionalidades Principais

- **Cadastro de Filmes/Séries:**
  - Adicione filmes ou séries com informações detalhadas (título, gênero, foto e descrição).
- **Listagem e Busca:**
  - Visualize todos os títulos cadastrados e utilize filtros para encontrar rapidamente o que procura.
- **Detalhes:**
  - Veja informações completas de cada filme/série ao clicar em **"Ver detalhes"** como: título, gênero, foto, descrição e quantidade de avaliações positivas e negativas.
- **Avaliação:**
  - Curta ou não curta títulos, promovendo interação.

---

## 🏗️ Estrutura do Projeto

```
MoviesMostenAPI/   # Backend .NET 8 (Web API)
MoviesMostenAPP/   # Frontend Angular
```

### Backend (MoviesMostenAPI)
- **ASP.NET Core 8**;
- **Entity Framework Core** para persistência de dados;
- **AutoMapper** para mapeamento de DTOs (Data Transfer Objects);
- **Migrations** para versionamento do banco.

### Frontend (MoviesMostenAPP)
- **Angular**;
- **Componentização** para reuso de UI;
- **Serviços** para integração com a API.

---

## 🚀 Como Executar

### 1. Backend
1. Navegue até `MoviesMostenAPI/`
2. Execute:
   ```bash
   dotnet run
   ```

### 2. Frontend
1. Navegue até `MoviesMostenAPP/`
2. Execute:
   ```bash
   npm install
   ng serve
   ```
3. Acesse: [http://localhost:4200](http://localhost:4200)

---

## 💡 Observações
- Certifique-se de que o backend esteja rodando antes de acessar o frontend;
- As configurações de conexão estão em `appsettings.json`;
- Os contadores de avaliações gerais (total de avaliações, total de avaliações positivas e total de avaliações negativas) estão disponíveis na *home page*, já os contadores individuais de cada registro estão presentes na sua respectiva página de detalhes.

---

## 👨‍💻 Autor
- Felipe Miranda (felipef210)

---

## 📄 Licença
Este projeto é apenas para fins de demonstração.
