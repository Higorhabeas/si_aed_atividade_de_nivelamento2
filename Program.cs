﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters;

namespace si_aed_atividade_de_nivelamento2
{
    class Program{

        static void Main (){
            //Exercicio_1();
            //Exercicio_2A();
            //Exercicio_2B();
            int []A ={1,2,3,4,5};
            int []B = {3,4,5,6,7};
            //Exercicio_3(A,B);
            Exercicio_3B(A,B);
        }

        static void Exercicio_1(){            
            
            for (int i = 1000 ; i < 10000; i++){
                int parte1 = i / 100;
                int parte2 = i % 100;
                if(Math.Pow(((parte1) + (parte2)), 2) == i){
                    Console.WriteLine(i);
                }
            }
                 
        }

        static void Exercicio_2A(){
            Console.Write("Digite o número para verificação :");
            int num = int.Parse(Console.ReadLine());
            int contador=0;
            for (int i = 2; i < num; i++){
                
                if ( num % i == 0){
                    contador ++;                   
                }
            }
            if (contador>0){
                Console.WriteLine("Este número não é primo");
            }else{
                Console.WriteLine("Este número é primo");
            }             
        }

        static void Exercicio_2B(){
            int somaDivisor=0;
            for (int i = 1; i < 1000; i++){
                for (int j = 1; j < i; j++){
                    if (i % j == 0){
                        somaDivisor +=j;
                    }
                }
                if (i == somaDivisor){
                    Console.WriteLine(i);
                } 
            }
        }

        static void Exercicio_3(int []v1, int []v2){
            int Cont = 0;
            for (int i = 0; i < v1.Length; i++){
                for (int j = 0; j < v2.Length; j++){
                    if (v1 [i] == v2[j]){
                        Cont++;
                    }
                }
            }

            int [] v3 = new int [Cont];
            Cont = 0;
            for (int i = 0; i < v1.Length; i++){
                for (int j = 0; j < v2.Length; j++){
                    if (v1 [i] == v2[j]){
                        v3[Cont] = v2[j];
                        Cont++;    
                    }
                }
            }

            for (int i=0; i < v3.Length; i++){
                Console.Write(v3[i]);
            }
           
        }

        static void Exercicio_3B(int []v1, int []v2){
            int Cont = 0;
            for (int i = 0; i < v1.Length; i++){
                for (int j = 0; j < v2.Length; j++){
                    if (v1 [i] == v2[j]){
                        Cont++;
                    }
                }
            }

            int [] v3 = new int [v1.Length-Cont];
            Cont = 0;
            int index = 0;
            for (int i = 0; i < v1.Length; i++){

                for (int j = 0; j < v2.Length; j++){
                    if (v1 [i] == v2[j]){
                        
                        Cont++;    
                    }
                }
                if (Cont == 0){
                    v3[index] = v1[i];
                    index++;
                    
                }
                Cont = 0;
                
            }

            for (int l=0; l < v3.Length; l++){
                Console.Write(v3[l]);
            }
           
        }
    
        static void Exercicio_4(int [ , ] m1){
            int somaLinha = 0;
            int somaColuna = 0;
            for (int i = 0; i < m1.GetLength(1); i++){
                for (int j = 0; j < m1.GetLength(0); j++){
                    somaLinha += m1 [j,i];
                }
                
            }
        }
    }
    
}
