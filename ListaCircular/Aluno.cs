namespace ListaDuplamenteEncadeada
{
    public class Aluno
    {
        public int Valor;
        
        public Aluno Prox;
        public Aluno Anter;
        
        public Aluno(int d)
        {
            Valor = d;
        }
    }
}