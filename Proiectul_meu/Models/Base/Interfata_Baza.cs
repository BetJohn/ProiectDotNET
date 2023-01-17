namespace Proiectul_meu.Models.Base
{
    public interface Interfata_Baza
    {
        Guid Id { get; set; }

        DateTime? DateCreated { get; set; }

        DateTime? DateModified { get; set; }
    }
}
