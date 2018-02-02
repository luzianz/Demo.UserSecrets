using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Demo.UserSecrets {

	public class Startup {

		private readonly IConfiguration configuration;

		public Startup(IConfiguration configuration) =>
			this.configuration = configuration ??
				throw new ArgumentNullException(nameof(configuration));

		public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
			app.Run(async(context) => {
				if (env.IsDevelopment()) {
					var myPassword = configuration.GetValue("MyPassword", "not found");
					await context.Response.WriteAsync("<p>Using the User Secrets API, you can store sensitive info seperately from your project. This way you won't risk divulging your sensitive data in a git repo or by other means of sharing your project.<p>");
					await context.Response.WriteAsync($"<p>'MyPassword' is {myPassword}</p>");
				} else {
					await context.Response.WriteAsync("User secrets are only available running in a 'Development' environment.");
				}
			});
		}
	}
}