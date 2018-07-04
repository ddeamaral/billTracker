namespace marriednowwhat.Models.Db
{
    public class DbInitializer
    {
        private readonly BillContext _billContext;

        public DbInitializer (BillContext _billContext)
        {
            this._billContext = _billContext;
        }

        public static async void Initialize ()
        {
            using (var db = new BillContext ())
            {
                await db.Database.EnsureCreatedAsync ();

                db.Bills.Add (new Bill () { Name = "Rent" });
                db.SaveChanges ();
            }
        }
    }
}