using System;
using Xamarin.Forms;

namespace TodoREST
{
	public partial class TodoListPage : ContentPage
	{
		bool alertShown = false;

		public TodoListPage ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if (Constants.RestUrl.Contains("api.visitkorea.or.kr"))
            {
                if (!alertShown)
                {
                    await DisplayAlert(
                        "투어 API를 이용한 어플리케이션입니다",
                        "이 어플리케이션은 투어 API와 xamarin을 이용해 개발한 어플리케이션입니다. 전국에 진행 중이거나, 오늘부터 시작하는 축제에 관한 정보를 보여드립니다.",
                        "확인");
                    alertShown = true;
                }
            }
            else
            {
                await DisplayAlert(
                    "faile to rest api call"
                    , " ", "확"
                );
            }

            layoutPageNum.Text = Constants.pagenum.ToString();
            listView.ItemsSource = await App.TodoManager.GetTasksAsync();

		}

		void OnAddItemClicked (object sender, EventArgs e)
		{
			var todoItem = new TodoItem () {
                resultCode = Guid.NewGuid ().ToString ()
			};
			var todoPage = new TodoItemPage (true);
			todoPage.BindingContext = todoItem;
			Navigation.PushAsync (todoPage);
		}

		void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
		{
			var todoItem = e.SelectedItem as TodoItem;
			var todoPage = new TodoItemPage ();
			todoPage.BindingContext = todoItem;
			Navigation.PushAsync (todoPage);
		}

		void beforeBtnClicked (object sender, EventArgs e)
		{
            if (Constants.pagenum == 1)
            {
                DisplayAlert(
                    "첫번째 페이지 입니!!"
                    , " ", "확인"
                );
            }else
                Constants.pagenum -= 1;
            
            OnAppearing();
        }

		void nextBtnClicked(object sender, EventArgs e)
		{
            Constants.pagenum += 1;		
            OnAppearing();
        }
	}
}
