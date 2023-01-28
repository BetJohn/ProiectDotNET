const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:5375';

const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
      "/api/tricou",
      "/api/bluza",
      "/api/pantaloni",
      "/api/sosete",
      "/api/tricoulatrening",
      "/api/trening"
   ],
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  }
]

module.exports = PROXY_CONFIG;
