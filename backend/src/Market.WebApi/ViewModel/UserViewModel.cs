namespace Market.WebApi.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<GameViewModel> Games { get; set; }
    }
}
