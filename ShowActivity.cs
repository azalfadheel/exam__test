
using Android.App;
using Android.OS;
using Android.Widget;
using XA_Mid2_Lab_Re;

namespace XA1_Mid2_Lab
{
    [Activity(Label = "Show_Activity")]
    public class ShowActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_show);

            var show2 = FindViewById<TextView>(Resource.Id.show);
            
            var showall2 = FindViewById<Button>(Resource.Id.showall);











            showall2.Click += delegate
            {

                var sq = new MySqliteDBRE();
                var Contacts = sq.GetAllUsers();

                string s = "";
                foreach (var Contact in Contacts)
                {
                    s += Contact.Id + "    " + Contact.Name + "   " + Contact.Mobile + "\n";
                }

                show2.Text = s.ToString();
            };
        }
    }
}