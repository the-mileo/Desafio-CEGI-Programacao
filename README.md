DESAFIO CEGI

Como testar o jogo:
-CLone esse repositório para o computador de teste
- No aplicativo Unity Hub, ache a opção Add e clique nela
- Selecione a pasta que você clonou
- Abra o projeto baixado
- Clique no botão de play localizado na parte de cima do editor
- O jogo deve estar rodando

Estrutura Geral do Programa:

Em relação à hierarquia:
Foram usados dois canvas principais, um para Inventário, e outro para o Shop. Em cada um deles, foram implementados diferentes subestruturas com componentes Image e TextMeshPro para segurar as diferentes informações necessárias de itens, slots de itens, etc.
O Shop e Inventário ambos têm números de slots facilmente ajustáveis, através do uso de GridLayouts, o que facilita a maintenence.
Os dados de exibição (ícone, texto, etc.) são derivados de scripts de ItemSOs que contém informações específicas de cada item
Uma ideia de PopUp de informação sobre itens existe dentro da hierarquia, com possibilidade alta de ser implementada no futuro
Vários panels diferentes foram usados para demarcar áreas diferentes do shop

Em relação aos Scripts:
Os itemSOs comportam várias variáveis que dizem como se relacionar ao shop e ao inventário, incluindo coisas como stats, icon, maxStacks, etc.
Foram programados dois managers (um para o shop e outro para o inventory) que dialogam entre si e com os seus respectivos slots para ver se a compra é possível e efetuá-la
Tanto shop quanto inventory também possuem scripts para seus slots, que também têm funções internas que dialogam com seus managers e configuram os dados dos slots

