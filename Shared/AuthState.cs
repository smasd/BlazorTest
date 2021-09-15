namespace BlazorTest.Shared
{
    public class AuthState
    {
        public bool ShowAuthDialog { get; set; }

        public NewUser NewUser { get; private set; } = new NewUser();

        public Login Login { get; private set; } = new Login();

        public void ToggleAuthDialog(bool state=false)
        {
            ShowAuthDialog = state;
        }
    }
}