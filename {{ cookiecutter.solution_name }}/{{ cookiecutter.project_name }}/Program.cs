using System; {%- if cookiecutter.include_sentry %}
using Sentry; {% endif %}

namespace {{ cookiecutter.project_name }} {
    class Program {
        static void Main (string[] args) {

            {%- if cookiecutter.include_sentry %}
            using (SentrySdk.Init ("https://yoursentrydsn")) {

            } {% endif %}

        }
    }
}