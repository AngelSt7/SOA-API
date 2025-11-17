using MailKit.Net.Smtp;
using MimeKit;

namespace SOA.features.auth.services
{
    public class EmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailAsync(string to, string subject, string body, string token)
        {
            var host = _config["SmtpSettings:Host"];
            var port = int.Parse(_config["SmtpSettings:Port"]);
            var user = _config["SmtpSettings:User"];
            var pass = _config["SmtpSettings:Pass"];

            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("SOA App", user));
            email.To.Add(new MailboxAddress("", to));
            email.Subject = subject;

            email.Body = new TextPart("html") { Text = body };

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(host, port, MailKit.Security.SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(user, pass);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }

        public string GetConfirmationEmailBody(string token)
        {
            return $@"
<!DOCTYPE html>
<html lang='es'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Confirma tu cuenta</title>
</head>
<body style='margin: 0; padding: 0; font-family: Arial, sans-serif; background-color: #f4f4f4;'>
    <table role='presentation' style='width: 100%; border-collapse: collapse;'>
        <tr>
            <td align='center' style='padding: 40px 0;'>
                <table role='presentation' style='width: 600px; border-collapse: collapse; background-color: #ffffff; box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1); border-radius: 8px;'>
                    
                    <tr>
                        <td style='background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); padding: 40px 30px; text-align: center; border-radius: 8px 8px 0 0;'>
                            <h1 style='color: #ffffff; margin: 0; font-size: 28px; font-weight: bold;'>¡Bienvenido a SOA App!</h1>
                        </td>
                    </tr>
                    
                    <tr>
                        <td style='padding: 40px 30px;'>
                            <h2 style='color: #333333; margin: 0 0 20px 0; font-size: 22px;'>Confirma tu cuenta</h2>
                            <p style='color: #666666; line-height: 1.6; margin: 0 0 20px 0; font-size: 16px;'>
                                Gracias por registrarte. Para completar tu registro y comenzar a usar tu cuenta, 
                                por favor confirma tu dirección de correo electrónico haciendo clic en el botón de abajo.
                            </p>

                            <table role='presentation' style='width: 100%; background-color: #f8f9fa; border: 2px dashed #667eea; border-radius: 6px; margin: 20px 0;'>
                                <tr>
                                    <td style='padding: 20px; text-align: center;'>
                                        <p style='margin: 0 0 8px 0; color: #666666; font-size: 13px; font-weight: bold;'>Tu código de confirmación:</p>
                                        <p style='margin: 0; color: #667eea; font-size: 18px; font-weight: bold; font-family: monospace; letter-spacing: 2px;'>
                                            {token}
                                        </p>
                                    </td>
                                </tr>
                            </table>
                            
                            <table role='presentation' style='margin: 30px 0;'>
                                <tr>
                                    <td align='center'>
                                        <a href='https://yourapp.com/confirm?token={token}' style='background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); color: #ffffff; padding: 16px 40px; text-decoration: none; border-radius: 6px; font-weight: bold; font-size: 16px; display: inline-block; box-shadow: 0 4px 6px rgba(102, 126, 234, 0.4);'>
                                            Confirmar mi cuenta
                                        </a>
                                    </td>
                                </tr>
                            </table>
                            
                            <table role='presentation' style='width: 100%; background-color: #fff3cd; border-left: 4px solid #ffc107; border-radius: 4px; margin: 20px 0;'>
                                <tr>
                                    <td style='padding: 15px;'>
                                        <p style='margin: 0; color: #856404; font-size: 14px;'>
                                            ⏱️ <strong>Importante:</strong> Este enlace expirará en <strong>15 minutos</strong> por razones de seguridad.
                                        </p>
                                    </td>
                                </tr>
                            </table>
                            
                            <p style='color: #666666; line-height: 1.6; margin: 20px 0 0 0; font-size: 14px;'>
                                Si no puedes hacer clic en el botón, copia y pega el siguiente enlace en tu navegador:
                            </p>
                            <p style='color: #667eea; word-break: break-all; font-size: 13px; margin: 10px 0;'>
                                https://yourapp.com/confirm?token={token}
                            </p>
                        </td>
                    </tr>
                    
                    <tr>
                        <td style='background-color: #f8f9fa; padding: 30px; text-align: center; border-radius: 0 0 8px 8px;'>
                            <p style='color: #999999; margin: 0 0 10px 0; font-size: 13px;'>
                                Si no creaste esta cuenta, puedes ignorar este correo de forma segura.
                            </p>
                            <p style='color: #999999; margin: 0; font-size: 13px;'>
                                © 2024 SOA App. Todos los derechos reservados.
                            </p>
                        </td>
                    </tr>
                    
                </table>
            </td>
        </tr>
    </table>
</body>
</html>";
        }
    }
}