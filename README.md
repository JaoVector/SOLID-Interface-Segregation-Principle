# SOLID Interface Segregation Principle
Projeto para apresentar a implementação do Quarto princípio de SOLID.

## O que é ISP?
Imagine que foi solicitada uma determinada funcionalidade, e esta funcionalidade será implementada através de uma interface, um tempo depois foi solicitada uma nova classe que vai implementar a mesma interface, agora já são duas classes para uma interface.

Com o decorrer do tempo foi adicionada uma nova funcionalidade a interface, de uso exclusivo da primeira classe, porém por via de regra como a segunda classe e a primeira compartilham da mesma interface, o método deve ser adicionado a segunda classe mesmo que não vá ser utilizado.

Para solucionar esse problema surge o princípio de segregação de interface, partindo da ideia de que cada interface deve ser especializada para implementar os métodos que serão utilizados de acordo com a regra de negócio por sua respectiva classe, assim não sobrarão métodos vazios ou inúteis em outras classes.

## Para saber mais detalhes acesse o artigo abaixo:
[Artigo Interface Segregation Principle](https://medium.com/@JoaoVictorCarneiroAureliano/interface-segregation-principle-isp-e001d601949c)
