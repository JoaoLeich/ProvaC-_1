public class CursoIngles : Curso
{

    public String ProeficienciaIngles { get; set; }

    public CursoIngles(int Semestres) : base(Semestres)
    {

        this.MediaNecessaria = 6.0;

    }
    public CursoIngles(int Semestres, int SemestreAtual) : base(Semestres, SemestreAtual)
    {

        this.MediaNecessaria = 6.0;

    }

    public void DefinirProeficiencia()
    {

        switch (this.SemestreAtual)
        {

            case 0:
                this.ProeficienciaIngles = "D3";
                break;
            case 2:
                this.ProeficienciaIngles = "C3";
                break;
            case 4:
                this.ProeficienciaIngles = "B3";
                break;
            case 6:
                this.ProeficienciaIngles = "A3";
                break;
            case 8:
                this.ProeficienciaIngles = "A2";
                break;
            case 10:
                this.ProeficienciaIngles = "A1";
                break;

        }

    }



}