
# Jogo-Vader
>[!Important]
 >`Equipe e projeto`
>- Dupla: Christian Varandas e Gabriel Gaudí
>- Turma: 2º Mtec Desenvolvimento de Jogos Digitais
>- Sobre: Jogo baseado na cena da primeira aparição de Darth Vader, em Star Wars Episódio IV: Uma nova esperança. Trabalho a pedido das professoras Aline e Nivia.
>- Link do projeto: https://drive.google.com/drive/folders/18Tf7eQZ129ojvdyYrEN8SqbjavzvCGye?usp=drive_link 

# Gameplay
- No jogo, você assume o papel de Darth Vader, e seu objetivo é atravessar o mapa, até chegar na sala onde se encontra a princesa Leia. O jogador deve derrotar todos os inimigos em cada área, para então abrir a porta e passar para a próxima. Serão três áreas, cada uma com um número diferente de inimigos. Para eliminar um inimigo, é necessário apenas estar próximo e atacá-lo, mas eles não são indefesos. Os inimigos irão atirar lasers contra o jogador, possuindo a vantagem da distância, mas com um intervalo de tempo de um tiro para outro. O jogo acaba se o jogador morrer, ou quando ele chega ao seu objetivo.
# História do jogo
- Darth Vader invadiu a nave e precisa chegar até a princesa Leia. Seus inimigos não o deixarão passar facilmente, e por isso, ele esmagará todos aqueles em seu caminho. Ele então segue pela nave, fazendo questão de derrotar um por um, para impor medo em seus adversários. Após acabar com todos e finalmente chegar ao seu destino, ele encontra a princesa.
- Esboço dos soldados inimigos <br>
 ![EsboçoInimigo](https://github.com/user-attachments/assets/e92b1723-1145-4171-95ca-20c42554a054)
- Esboços do jogador (Darth Vader) <br>
 ![EsboçoJogador](https://github.com/user-attachments/assets/a5e12d89-8800-4c00-b22a-8501c7a73b62)
![EsboçoJogador2](https://github.com/user-attachments/assets/28be7a92-ca32-42d0-a06d-f2e8ab9ccfed)


# Cores
- Por estarmos na visão do vilão da famosa franquia, optamos por uma paleta de cores mais escura, pois agora você está do lado sombrio da força. A predominância das cores cinza e preto criam um ar misterioso e sombrio, combinando com o sentimento causado pela presença de Darth Vader. O vermelho de seu sabre de luz se destaca, com a cor vermelha sendo uma das mais intensas na psicologia das cores, podendo trasmitir fortes emoções, e também simbolizar a guerra que ocorre ali.

| Local ou personagem | Hexadecimal |
| --- | --- |
| Darth Vader | 2C2C2C |
| Sabre | A50202 |
| Chão | 214952 |
| Porta | ADAAA5 |
| Paredes | ADA6A5 |
| Texto no menu | FFFFFF |
| Botões | FFFFFF e F11313 |
| Inimigo | 3F7345, ABA8A8 e FFFFFF |

# Cenário
- O cenário do jogo é a nave da qual Darth Vader invadiu. Ele se baseia em dois corredores e uma grande sala, onde em cada um desses há uma certa quantidade de inimigos. Os corredores e a sala são separados por portas. Foram usados assets da assets store para o mapa em um geral (paredes, chão, teto, portas e obstáculos), e alguns cubos do unity para as paredes em volta das portas.
- Esboço conceitual do cenário:
  ![EsboçoCenário](https://github.com/user-attachments/assets/3772f492-c11e-4645-a9fd-35c81e940a42)

## Porta 1:
![Imagem do WhatsApp de 2024-11-29 à(s) 23 44 54_0c3f05d1](https://github.com/user-attachments/assets/9bd8fccf-ebea-4ca9-bb6d-9e0fb3a1c27b)
![Imagem do WhatsApp de 2024-11-29 à(s) 23 50 43_a09fabef](https://github.com/user-attachments/assets/601e7c69-63c5-4ee3-ba1a-5ce306c65ba2)
## Porta 2:
![Imagem do WhatsApp de 2024-11-29 à(s) 23 54 19_a469236b](https://github.com/user-attachments/assets/72f1533e-8724-4c20-bcbb-91d802054413)
## Porta 3:
![Imagem do WhatsApp de 2024-11-29 à(s) 23 55 57_5b2fcce7](https://github.com/user-attachments/assets/841ae5ee-fdde-446f-8e1d-00665ea295db)

# UI
`Menu`: O menu do jogo possui dois botões abaixo do título do jogo, sendo eles o de "Jogar" e "Sair". Como os nomes já dizem, o primeiro te leva à cena do jogo, e o segundo fecha o mesmo. O cenário por trás do menu foi feito com uma Skybox com uma imagem do espaço, e o modelo de um "Destroyer", uma nave do império no filme.
![Imagem do WhatsApp de 2024-11-26 à(s) 17 35 08_58cbb149](https://github.com/user-attachments/assets/3c72a58f-faa6-42eb-864c-abe1c49f4d19)
Ao deixar o mouse em cima de um dos botões, este muda de cor, ficando vermelho. Se retirar o mouse, ele volta ao normal.
![Imagem do WhatsApp de 2024-11-26 à(s) 17 35 40_16086434](https://github.com/user-attachments/assets/2c3dfeb2-b48e-4c90-bff9-6fe7e2764d19)
`Fim de jogo`: Ao ser derrotado ou chegar no objetivo, o jogador é direcionado para a tela de fim de jogo. Essa tela possui uma mensagem escrita "Fim de jogo" e dois botões, sendo eles um para reiniciar o jogo, e outro para retornar ao menu.
![Imagem do WhatsApp de 2024-11-26 à(s) 19 07 56_8b246e4b](https://github.com/user-attachments/assets/d81725b4-7f05-460d-9c15-38f2664334ac)
Os botões funcionam da mesma forma que os do menu. Ao passar o mouse por cima, ficará vermelho, e voltará ao normal quando retirar o mouse. O botão de reiniciar o jogo direciona o jogador para o inicio da cena, já o outro o direciona ao menu principal.
![Imagem do WhatsApp de 2024-11-26 à(s) 19 08 30_b617bce1](https://github.com/user-attachments/assets/82e7654f-ea9d-4c8c-bf71-95c44e86184f)

# Diagrama de classes
### Diagrama antigo:
![WhatsApp Image 2024-12-01 at 16 25 02](https://github.com/user-attachments/assets/2a16aa42-b204-4df9-bdb0-1e036856d0d5)
### Diagrama atual:
![Imagem do WhatsApp de 2024-12-01 à(s) 22 32 45_badd7360](https://github.com/user-attachments/assets/3620218f-0c3a-417b-bf05-7f9a74ebe086)


# Referências (Assets):
- Darth Vader: https://skfb.ly/onpSP
- Sabre de Luz: https://skfb.ly/ot8Ey
- Inimigo: https://skfb.ly/oU6PS
- Star Destroyer: https://skfb.ly/o9vyx
- Skybox: https://assetstore.unity.com/packages/2d/textures-materials/deep-space-skybox-pack-11056
- Assets do cenário: https://assetstore.unity.com/packages/3d/environments/sci-fi/modular-sci-fi-corridor-142811

# Avaliação da dupla
- Para não haver confusão na leitura: A avaliação de um integrante será escrita pelo outro, ou seja, onde estiver o nome de um, o outro integrante que escreveu.<br>
`Gabriel Gaudí`: O Gaudí fez a parte dos scripts e códigos num geral, cuidando da parte de animações e colisões também. Enquanto isso eu cuidei da parte visual do jogo (cenários, modelos, etc). Houve uma ótima comunicação entre nós dois, onde ele me esclareceu muitas dúvidas sobre programação e animações do unity também. Durante o projeto, fez sua parte respeitando o prazo, e sempre me avisando quando o projeto estava livre para eu mexer. Além de que também teve ideias muito boas, as quais nós decidimos juntos colocar no jogo ou não. Dito isso, foi uma ótima dupla, conseguimos fazer um jogo muito bom.<br>
`Christian Varandas`: pensou no conceito geral do jogo quando fizemos a análise do filme, com o mapa e objetivo.
Durante o desenvolvimento, buscou os modelos de cenário, personagens, etc; encontrando os que mais encaixassem no jogo. Com eles e o mapa que fez, criou um cenário muito bom no jogo, com os obstáculos e portas.
Também fez os dois menus temáticos e seus botões interativos.
Em cada aula um de nós fazia sua parte, assim enquanto ele criava os cenário eu pesquisava os códigos e vice-versa. As ideias se desenvolveram juntas, para que se encaixassem e para entendermos como estavam sendo feitas. Durante esse processo, conversávamos sobre todos os elementos para que ficaseemos de acordo com a decisao final e ele me ajudou muito a resolver erros no código que eu sozinho demoraria muito para perceber.
A ideia original é relativamente simples, mas a nossa cooperação e a criatividade dele transformaram isso, para que esse jogo simples ainda seja muito interessante.
