
namespace StarRating.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
		public string Title { get; set;}
        public string Rating { get; set; }

        public DefaultViewModel()
		{
			Title = "DotVVM Star Rating";
            Rating = "1";
		}
    }
}


