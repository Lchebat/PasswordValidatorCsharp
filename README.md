# PasswordValidatorCsharp
Validador de senhas. (C#, .Net Core 6.0, xUnit, API REST)

- Primeiro foram criados 2 projetos em uma solução. Um para realização dos testes unitários com xUnit e outro a API de validação de senhas. 
- A classe PasswordService foi criada que ditará as regras de negócio, ou seja, ela irá realizar as validações da senha. Também foi adicionado a injeção de depêndencia para diminuir o acoplamento entre o controller e as validações que serão feitas na senha. 
- Foi criado a classe PasswordVerifier para extender a classe string e assim a classe PasswordService apenas chamará os métodos de extensão criados na classe PasswordVerifier.