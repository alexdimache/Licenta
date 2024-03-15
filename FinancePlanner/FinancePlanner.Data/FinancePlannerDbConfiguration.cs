using Microsoft.Extensions.Configuration;

namespace FinancePlanner.Data
{
    public class FinancePlannerDbConfiguration
    {
        public static int GetSqlCommandTimeoutInSeconds(IConfiguration configuration)
        {
            if (configuration == null || !int.TryParse(configuration.GetSection(Constants.SQL_COMMAND_TIMEOUT_CONFIGURATION_SECTION).Value, out var result))
            {
                result = Constants.SQL_COMMAND_TIMEOUT_SECONDS;
            }

            return result;
        }
    }
}
