# Usando o PI Notification com Telegram

## Objetivo


> *O projeto tem como objetivo documentar os testes realizados com o PI Notification(OSIsoft) e Telegram.*

## Motivação

Configurar o PI Notification para envio de mensagens via Telegram.


## Desenvolvimento

A versão do PI Notification que foi testado foi a versão 2012, que já se encontra desatualizada atualmente.




Tanto o [Telegram](https://telegram.org/) quanto o [PI Web API](https://techsupport.osisoft.com/Documentation/PI-Web-API/help.html) trabalham com várias
linguagens de programação(c#, php, python). Para o nosso caso iremos utilizar como interface o [Node-Red](https://nodered.org/).

A escolha do uso do *Node-Red* se dá pela facilidade de implementação, documentação e por ser voltado para tecnologias de IoT. Desta forma estamos alinhados 
com as tendências da Industria 4.0.

O nosso Node-Red está na versão ```v0.19.3``` e rodando em ambiente Windows - ```Windows Server 2008 R2```.

Com o Node-Red devidamente configurado temos que instalar os seguintes nodes:

1. **Telegram**: o telegram possui vários nodes mas utilizamos dois:
	+ [node-red-contrib-chatbot](https://flows.nodered.org/node/node-red-contrib-chatbot):
		* Configurado bot com menus de navegação
	+ [node-red-contrib-telegrambot](https://flows.nodered.org/node/node-red-contrib-telegrambot).
		* Configurado para envio de notificações 
		
2. **PI Web API**: encontrado alguns node referenciados como PI Web API mas utilizado:
	+ [node-red-contrib-osisoft-web-api](https://flows.nodered.org/node/node-red-contrib-osisoft-web-api).
		* Utilizado como fonte de dados

## Telegram

Como falado anteriormente foi utilizado dois nodes telegram para este projeto. A configuração comum para os dois node é que precisamos criar um bot no 
telegram para as duas condições.
Para criar um [bot](https://core.telegram.org/bots) primeiramente temos que ter uma conta no telegram e seguir os
seguintes [passos](https://medium.com/tht-things-hackers-team/10-passos-para-se-criar-um-bot-no-telegram-3c1848e404c4):

Depois de ter configurado o bot no telegram temos que anotar o **botname** e **token**, com estas informações já temos condições de iniciar a configuração
do Node-Red. 

## Conclusão

## Help

Caso precisem te ajuda ou tenham alguma sugestão, deixe seu comentário [Aqui](https://github.com/dedynobre/usando-telegram-com-piwebapi/issues).