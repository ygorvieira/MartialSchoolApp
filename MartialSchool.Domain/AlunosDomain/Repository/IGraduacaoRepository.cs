using MartialSchool.Domain.Entities;

namespace MartialSchool.Domain.Repository
{
    public interface IGraduacaoRepository
    {
        void CadastroGraduacao(Graduacao graduacao);
    }
}
