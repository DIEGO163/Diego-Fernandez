/*Escribir un programa que contenga:
1. Árbol binario 2. Árbol con múltiples hijos 3. Contar niveles 4. Contar hojas 5. Contar nodos 6. Navegación horizontal 7. Expresión matemática con + - * / tomar en cuenta las prioridades*/
using System;

namespace TareaArbol
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo()
            {

                Valor = "/",
                nivel = 0,
                Hijos ={
                    new Nodo{
                        Valor="*",
                        Hijos={
                            new Nodo{
                                Valor="5"
                            },
                            new Nodo{
                                Valor ="8"
                            }
                        }
                    },
                    new Nodo{
                        Valor ="-",
                        Hijos={
                            new Nodo{
                                Valor="3"
                            },
                            new Nodo{
                                Valor="2"
                            }
                        }
                    },
                    new Nodo{
                        Valor="+",
                        Hijos={
                            new Nodo{
                                Valor="1"
                            },
                            new Nodo{
                                Valor="6"
                            }

                        }
                    },

                    new Nodo{
                        Valor="/",
                        Hijos={
                            new Nodo{
                                Valor="2"
                            },
                            new Nodo{
                                Valor="6"
                            }

                        }
                    },



                },
            };

            ControladorArbol controladorArbol = new ControladorArbol();
            Console.WriteLine($"el numero de hojas del arbol es de : {controladorArbol.ContarHojas(raiz)}");
            Console.WriteLine($"el numero de niveles del arbol es de : {controladorArbol.ContarNiveles(raiz)}");
            Console.WriteLine($"el numero de nodos del arbol es de : {controladorArbol.ContarNodos(raiz)}");


        }
    }
}