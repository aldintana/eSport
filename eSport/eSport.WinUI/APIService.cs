using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using eSport.Model;
using Flurl.Http;
using System.Windows.Forms;

namespace eSport.WinUI
{
    class APIService
    {
        private string _route = null;

        public static string KorisnickoIme { get; set; }
        public static string Lozinka { get; set; }
        public static int LogiraniKorisnikId { get; set; }
        public static bool Admin { get; set; }

        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object request = null)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            if(request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }
            var result = await url.WithBasicAuth(KorisnickoIme,Lozinka).GetJsonAsync<T>();
            return result;
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";  
            var result = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}";
            try
            {
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                GenerateMessage(ex);
                return default(T);
            }
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            try
            {
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                GenerateMessage(ex);
                return default(T);
            }
        }

        public async Task<T> Delete<T>(object id)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/{id}";
            try
            {
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).DeleteAsync().ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                GenerateMessage(ex);
                return default(T);
            }
        }

        public async void GenerateMessage(FlurlHttpException ex)
        {
            var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

            var stringBuilder = new StringBuilder();
            foreach (var error in errors)
            {
                stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
            }

            MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public async Task<bool> GenerisiTurnir<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.ApiURL}/{_route}/generisiTurnir/{id}";
            try
            {
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<bool>();
            }
            catch (FlurlHttpException ex)
            {
                GenerateMessage(ex);
                return default(bool);
            }
        }
    }
}
