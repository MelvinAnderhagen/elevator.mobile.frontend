using Javax.Net.Ssl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Android.Net;

namespace FrontEnd.Clients
{
    public sealed class LocalhostAndroidHttpsMessageHandler : AndroidMessageHandler
    {
        public LocalhostAndroidHttpsMessageHandler()
        {
            ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert is { Issuer: "CN=localhost" })
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
        }

        protected override IHostnameVerifier GetSSLHostnameVerifier(HttpsURLConnection connection)
        => new CustomHostnameVerifier();

        private sealed class CustomHostnameVerifier : Java.Lang.Object, IHostnameVerifier
        {
            public bool Verify(string hostname, ISSLSession session)
                => HttpsURLConnection.DefaultHostnameVerifier.Verify(hostname, session)
                   || (hostname == "10.0.2.2" && session.PeerPrincipal.Name == "CN=localhost");
        }
    }
}
