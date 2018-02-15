using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DesislavsHotDogs
{
    [Activity(Label = "DesislavMapActivity")]
    public class DesislavMapActivity : Activity
    {
        private Button externalMapButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.DesislavMapView);

            FindViews();

            HandleEvents();
        }
        
        private void FindViews()
        {
            externalMapButton = FindViewById<Button>(Resource.Id.externalMapButton);
        }

        private void HandleEvents()
        {
            externalMapButton.Click += ExternalMapButton_Click;
        }

        private void ExternalMapButton_Click(object sender, EventArgs e)
        {
            Android.Net.Uri desislavLocationUri = Android.Net.Uri.Parse("geo:42.683911, 23.337857");

            Intent mapIntent = new Intent(Intent.ActionView, desislavLocationUri);
            StartActivity(mapIntent);
        }
    }
}