namespace Panel_logowania
{
    public class User
    {
        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public string passwordSHA512()
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(UserPassword);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                {
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                }

                return hashedInputStringBuilder.ToString();
            }
        }
    }
}