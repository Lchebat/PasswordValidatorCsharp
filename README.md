# PasswordValidatorCsharp
Validador de senhas. (C#, .Net Core 6.0, xUnit, API REST)

- Primeiro foram criados 2 projetos em uma solução. Um para realização dos testes unitários com xUnit e outro a API de validação de senhas. 
- A classe PasswordService foi criada fazer as verificações nessecárias, ou seja, realizará as validações da senha. Também foi adicionado a injeção de depêndencia para diminuir o acoplamento entre o controller e as validações que serão feitas na senha. 
- Foi criado a classe StringVerifier para extender a classe string e assim a classe PasswordService apenas chamará os métodos de extensão criados na classe StringVerifier.
- Foi adicionada uma classe CharVerifier que extende o objeto char para poder filtrar os caracteres especiais permitidos: !@#$%^&*()-+.
- Foi implementado duas classes de testes unitários utilizando xUnit. A primeira testando todos os métodos da classe StringVerifier e a segunda testando as senhas sugeridas. 
- Interface IPasswordService implementada para reduzir o acomplamento entre o controlador PasswordController e a classe PasswordService.