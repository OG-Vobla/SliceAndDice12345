namespace SliceAndDice12345.Data
{
    public class SingletonServise
    {
        bool isAuth;
        public bool GetUser()
        { 
            return isAuth;
        }
        public void SetUser(bool newUser)
        {
            isAuth = newUser;
        }
    }
}
