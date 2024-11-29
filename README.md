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

# Cenário
- O cenário do jogo é a nave da qual Darth Vader invadiu. Ele se baseia em dois corredores e uma grande sala, onde em cada um desses há uma certa quantidade de inimigos. Os corredores e a sala são separados por portas.
## Porta 1:
![Imagem do WhatsApp de 2024-11-26 à(s) 15 47 40_2ead0c11](https://github.com/user-attachments/assets/1b79964b-34dd-4079-aa5b-2013a9775551)
![Imagem do WhatsApp de 2024-11-26 à(s) 15 49 01_b3a8a28c](https://github.com/user-attachments/assets/47761921-777e-44f7-9151-2b18e414dda4)
## Porta 2:
![Imagem do WhatsApp de 2024-11-26 à(s) 15 49 51_8e5ec7cf](https://github.com/user-attachments/assets/3a8aebd3-94d3-4daf-9d8e-034696f818b5)
## Porta 3:
![Imagem do WhatsApp de 2024-11-26 à(s) 15 51 14_d092e06a](https://github.com/user-attachments/assets/9d80632c-e1a3-467c-bd67-415c6822a3b7)

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

# Scripts
 <h2>Jogador.cs:</h2>
 Atributos:
 <ul>
  <li>controleJogador: Referência ao componente "CharacterController do objeto do jogador. Usado para o movimento e colisões.</li>
  <li>cam: Referência ao componente "Transform" da câmera. Usado para fazer o jogador se mover de acordo com a direção da câmera.</li>
  <li>velocidade: Valor float, que define quão rápido o jogador se moverá.</li>
  <li>vida: Valor int, armazena um valor que define quanto dano de ataques o jogador pode levar antes de perder o jogo.</li>
  <li>mover: Um Vector3 que armazena valores nos eixos X e Z para movimentar o CharacterController do jogador e a direção da câmera, para que o jogador se mova com ela.</li>
  <li>horizontal e vertical: floats que recebem valores de acordo com as teclas de movimento pressionadas.</li>
 </ul>
  Métodos:
  <ul>
   <li>Start: Executado apenas uma vez, logo após o carregamento e antes do primeiro frame.
       Cursor.lockState: define se o cursor vai ficar livre, preso à janela atual, ou travado no centro da tela, seu valor é = CursorLockMode.Locked, pois o jogador não precisará clicar em nenhum elemento.
       controleJogador = GetComponent<CharacterController>(); Atrela controleJogador ao componente CharacterController do objeto que recebe o script, no caso, o modelo do jogador.
       cam = Camera.main.transform; 
   </li>
  </ul>

  <h2>Menu.cs</h2>
  Arquivo com as funções dos botões da tela inicial do jogo.
  <ul>
<li>O método SairJogo é acessado quando o botão de sair é clicado, e usa “Application.Quit” para fechar o jogo.</li>
<li>Os métodos IniciarJogo, Reiniciar e Voltar, são executados quando os botões com o mesmo texto são clicados, todos usam o método “LoadScene” troca a cena atual para as cenas do jogo no menu principal, do jogo no menu de derrota e do menu principal, respectivamente.</li>
</ul>

 <h2>Fase.cs</h2>
 Script que controla as portas da nave, que separam o jogo em três fases.
 Cada porta contém uma instância desse script, com os métodos Start e Update do Unity e “AbrirPorta”.
 Também possuem os atributos “inimigosDerrotados", uma variável int e static (para que seja igual em todas as instâncias), cujo valor sobe em 1 toda vez que um inimigo é morto pelo jogador.
“totalInimigos”, possui um valor único para cada instância, que determina quantos inimigos devem ser derrotados para que o jogador possa progredir.
 Quando o número de inimigos derrotados alcança o total, o método “AbrirPorta é chamado” esse método, também único para cada instância da classe, chama uma animação que move a porta, permitindo que o jogador passe por ela.

<h2>

# Referências (Assets):
- Darth Vader: https://skfb.ly/onpSP
- Sabre de Luz: https://skfb.ly/ot8Ey
- Star Destroyer: https://skfb.ly/o9vyx
- Skybox: https://assetstore.unity.com/packages/2d/textures-materials/deep-space-skybox-pack-11056
- Assets do cenário: https://assetstore.unity.com/packages/3d/environments/sci-fi/modular-sci-fi-corridor-142811
