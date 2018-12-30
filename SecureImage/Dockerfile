FROM microsoft/dotnet:2.1-runtime
MAINTAINER Matt Bentley "mabentley@deloitte.co.uk"

ADD /bin/Release/netcoreapp2.1/publish /app
WORKDIR /app

# Harden Image
COPY ./harden.sh .
RUN apt-get update && \
    apt-get install -y dos2unix && \
    dos2unix harden.sh && \
    apt-get --purge remove -y dos2unix && \
    rm -rf /var/lib/apt/lists/* && \
    chmod +x harden.sh && \
    sh harden.sh && \
    rm harden.sh

# # Set container exposed port if ASP.NET Core
# EXPOSE 8080

# # Set binding for Kestrel if ASP.NET Core
# ENV ASPNETCORE_URLS=http://+:8080

# Force container to run as a non-root user
USER appuser

# ENTRYPOINT / RUN
ENTRYPOINT ["dotnet", "SecureImage.dll"]