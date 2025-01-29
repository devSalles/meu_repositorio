#include <stdio.h>
#include <stdlib.h>

int main() {
    int linhas, colunas;

    // Solicita o número de linhas e colunas da matriz
    printf("Informe o número de linhas: ");
    scanf("%d", &linhas);
    printf("Informe o número de colunas: ");
    scanf("%d", &colunas);

    // Alocação dinâmica da matriz original
    int **matriz = (int **)malloc(linhas * sizeof(int *));
    for(int i = 0; i < linhas; i++) {
        matriz[i] = (int *)malloc(colunas * sizeof(int));
    }

    // Entrada dos elementos da matriz
    printf("Insira os elementos da matriz:\n");
    for(int i = 0; i < linhas; i++) {
        for(int j = 0; j < colunas; j++) {
            printf("Elemento [%d][%d]: ", i + 1, j + 1);
            scanf("%d", &matriz[i][j]);
        }
    }

    // Alocação dinâmica da matriz transposta
    int **transposta = (int **)malloc(colunas * sizeof(int *));
    for(int i = 0; i < colunas; i++) {
        transposta[i] = (int *)malloc(linhas * sizeof(int));
    }

    // Cálculo da transposta
    for(int i = 0; i < linhas; i++) {
        for(int j = 0; j < colunas; j++) {
            transposta[j][i] = matriz[i][j];
        }
    }

    // Exibição da matriz original
    printf("\nMatriz original:\n");
    for(int i = 0; i < linhas; i++) {
        for(int j = 0; j < colunas; j++) {
            printf("%d ", matriz[i][j]);
        }
        printf("\n");
    }

    // Exibição da matriz transposta
    printf("\nMatriz transposta:\n");
    for(int i = 0; i < colunas; i++) {
        for(int j = 0; j < linhas; j++) {
            printf("%d ", transposta[i][j]);
        }
        printf("\n");
    }

    // Liberação da memória alocada
    for(int i = 0; i < linhas; i++) {
        free(matriz[i]);
    }
    free(matriz);

    for(int i = 0; i < colunas; i++) {
        free(transposta[i]);
    }
    free(transposta);

    return 0;
}
