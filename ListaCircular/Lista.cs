using System;
using System.Configuration;

namespace ListaDuplamenteEncadeada
{
    public class Lista
    {
        public Aluno Head;
        
        public Aluno Current;

        // intervalo
        public int i;
        
        public Lista()
        {
            Head = null;
        }
        
        public void ShowList()
        {
            Aluno current = Head;
            if (current == null)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                while (current != null)
                {
                    Console.WriteLine(current.Valor);
                    current = current.Prox;
                }
            }
        }
        
        public void Insert(int d)
        {
            Aluno newNode = new Aluno(d);
            if (Head == null)
            {
                Head = newNode;
                Current = Head;
                Head.Prox = newNode;
                Head.Anter = newNode;
            }
            else
            {
                Aluno temporary = Head;

                if (temporary.Prox == temporary)
                {
                    temporary.Prox = newNode;
                    temporary.Anter = newNode;
                    newNode.Prox = temporary;
                    newNode.Anter = temporary;
                }
                else if(newNode.Valor.CompareTo(Head) == -1)
                {

                    newNode.Prox = Head;
                    newNode.Anter = Head.Anter;
                    Head.Anter.Prox = newNode;
                    Head.Anter = newNode;

                    Head.Prox = Head;
                    Current = Head.Anter;
                }
                else
                {
                    while (newNode.Valor.CompareTo(temporary.Valor) == -1)
                    {
                        temporary = temporary.Prox;

                        if (temporary == Head)
                        {
                            break;
                        }
                    }
                    newNode.Prox = temporary;
                    temporary.Anter.Prox = newNode;
                    newNode.Anter = temporary.Anter;
                    temporary.Anter = newNode;
                }
            }
            
            Console.WriteLine("Adicionado");
        }
        public void Insert(Aluno newNode)
        {
            Insert(newNode.Valor);
        }
        
        public void DeleteByValue(int d)
        {
            Aluno current = Head;

            if (current != null)
            {
                if (current.Valor == d)
                {
                    if (current.Prox != null)
                    {
                        current = current.Prox;
                    }
                    else
                    {
                        current = null;
                    }
                    Head = current;
                }
                else
                {
                    while (current.Prox != null && current.Prox.Valor != d)
                    {
                        current = current.Prox;
                    }
                    if (current.Prox != null && current.Prox.Valor == d)
                    {
                        current.Prox = current.Prox.Prox;
                        current = null;
                    }
                    else
                    {
                        Console.WriteLine("Elemento não encontrado");                        
                    }
                }
            }
            
            
            Console.WriteLine("Removido");
        }

        public Boolean verifyIfListaIsEmpty()
        {
            if (Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Aluno ReturnElementoByValue(int val)
        {
            Aluno current = Head;
            if (current == null)
            {
                return null;
            }
            else
            {
                while (current != null)
                {
                    if (current.Valor == val)
                    {
                        return current;
                    }
                    current = current.Prox;
                }
                
                return null;
            }
        }
        
        public Aluno ReturnElementoByPosition(int indexSearch)
        {
            Aluno current = Head;
            int index = 0;
            
            if (current == null)
            {
                return null;
            }
            else
            {
                while (current != null)
                {
                    if (index == indexSearch)
                    {
                        return current;
                    }

                    index++;
                    current = current.Prox;
                }
                
                return null;
            }
        }
        
        public void Concatenar(Lista list)
        {
            Aluno current = Head;
            if (current == null)
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {   
                Insert(list.Head);
            }
        }
    }
}