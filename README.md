# ProvaHandcom
Repositório para a prova da Handcom


A pizzaria "Borracharia e Pizzaria do Geraldo" está com problemas em controlar seus pedidos devido a falta de organização interna e baixo número de funcionários. O senhor Geraldo Silva Coutinho, dono da pizzaria, contratou os serviços da **Handcom** para que disponibilize um sistema que resolva seu problema.

Após uma reunião com o senhor Geraldo, um grupos de analistas concluíram que seriam necessários no sistema os seguintes requisitos:

1. O sistema deve permitir o cadastro de clientes. Serão registrados:
    1. Nome do cliente
    2. Cpf do cliente
    3. Telefone do cliente
    4. Endereço do cliente

2. O sistema deve permitir o cadastro de pedidos dos clientes. Serão registrados:
    1. Número de pedido
    2. Data do pedido
    3. Data de entrega do pedido, registrado no mínimo 30 minutos depois da data do pedido.

3. O sistema deve permitir o cadastro de itens do pedido. Os itens são divididos em Pizzas, Bebidas e Sobremesas.
    1. Para pizzas, será registrado:
        1. Sabor da pizza
        2. Preço da pizza
    2. Para bebidas, será registrado:
        1. Tipo da bebida (água, refrigerante ou cerveja).
        2. Preço da bebida
    3. Para sobremesas, será registrado:
        1. Tipo (brigadeiro, beijinho ou palha italiana)
        2. Preço da sobremesa

4. O sistema deve disponibilizar um relatório com todos os clientes, pedidos, e itens já cadastrados.
5. O relatorio deve disponibilizar filtros para a listagem dos itens.



## Instruções para a realização da prova ##
1. O SGBD deve ser MYSql, Postgree ou Sql Server.
2. Deve ser desenvolvida na linguagem C# MVC, utilizando NHibernate **ou** Entity para o mapeamento dos objetos.
3. Alterar o arquivo "standup.txt" cada vez que for realizar algo no sistema, com data de início da tarefa, data de finalização e o que foi/será realizado.
4. Podem ser realizados inúmeros commits.
