
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



# Referências (Assets):
- Darth Vader: https://skfb.ly/onpSP
- Sabre de Luz: https://skfb.ly/ot8Ey
- Star Destroyer: https://skfb.ly/o9vyx
- Skybox: https://assetstore.unity.com/packages/2d/textures-materials/deep-space-skybox-pack-11056
- Assets do cenário: https://assetstore.unity.com/packages/3d/environments/sci-fi/modular-sci-fi-corridor-142811
