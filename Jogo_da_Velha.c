/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
//Devs: Bernardo  
//Kennedy

#include <stdio.h>
#include <stdlib.h>

#define qtd_linha 3
#define qtd_coluna 3
#define jogador_X 'X'
#define jogador_O 'O'

//função verificar ganhador (parametro)
char verificaGanhador(char tabuleiro[qtd_linha][qtd_coluna]) {
    int l, c;
    
    //verificar se deu velha na linha
    for (l = 0; l < qtd_linha; l++) {
        if (tabuleiro[l][0] == tabuleiro[l][1] && tabuleiro[l][1] == tabuleiro[l][2] && tabuleiro[l][0] != '_') {
            return tabuleiro[l][0];
        }
    }
    
    //verificar se deu velha na coluna
    for (c = 0; c < qtd_coluna; c++) {
        if (tabuleiro[0][c] == tabuleiro[1][c] && tabuleiro[1][c] == tabuleiro[2][c] && tabuleiro[0][c] != '_') {
            return tabuleiro[0][c];
        }
    }
    
    if (tabuleiro[0][0] == tabuleiro[1][1] && tabuleiro[1][1] == tabuleiro[2][2] && tabuleiro[0][0] != '_') {
        return tabuleiro[0][0];
    }
    if (tabuleiro[0][2] == tabuleiro[1][1] && tabuleiro[1][1] == tabuleiro[2][0] && tabuleiro[0][2] != '_') {
        return tabuleiro[0][2];
    }

   
    return '_';
}

int main(int argc, char *argv[]) {
    
    //variavéis
    char jogador1[100], jogador2[100];
    int posicao, l, c;
    char tabuleiro[qtd_linha][qtd_coluna];
    char vez = jogador_X;  
    char ganhador = '_';   
    
    //1° jogador e 2° jogador
    printf("Digite o nome do 1° jogador (X): ");
    scanf("%s", jogador1);
    printf("Digite o nome do 2° jogador (O): ");
    scanf("%s", jogador2);
    
    //matriz para fazer o jogo da velha 
    for (l = 0; l < qtd_linha; l++) {
        for (c = 0; c < qtd_coluna; c++) {
            tabuleiro[l][c] = '_';
        }
    }
    
    while(1) {
       
       //vez do jogador
        printf("\nVez do jogador: %c\n", vez);
            
        for (l = 0; l < qtd_linha; l++) {
            for (c = 0; c < qtd_coluna; c++) {
                printf("%c ", tabuleiro[l][c]);
            }
            printf("\n");
        }
       
       //posição
        printf("Digite a posição que deseja jogar (1-9): ");
        scanf("%d", &posicao);
        
        //verificar posição
        if (posicao < 1 || posicao > 9) {
            printf("Posição inválida! Tente novamente.\n");
            continue;
        }
        
        l = (posicao - 1) / qtd_linha;
        c = (posicao - 1) % qtd_coluna;
        
        if (tabuleiro[l][c] == '_') {
            tabuleiro[l][c] = vez;
        } else {
            printf("Posição já ocupada! Tente novamente.\n");
            continue;
        }
        
        //verificar ganhador
        ganhador = verificaGanhador(tabuleiro);
        if (ganhador != '_') {
            printf("\nJogador %c venceu!\n", ganhador);
            break;
        }
        
        if (vez == jogador_X) {
            vez = jogador_O;
        } else {
            vez = jogador_X;
        }
    }
    //exibir o tabuleiro a cada jogada 
    for (l = 0; l < qtd_linha; l++) {
        for (c = 0; c < qtd_coluna; c++) {
            printf("%c ", tabuleiro[l][c]);
        }
        printf("\n");
    }

    return 0;
}
