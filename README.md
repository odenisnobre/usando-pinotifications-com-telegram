# Usando o PI Notifications com Telegram

## Objetivo


> *O projeto tem como objetivo documentar os testes realizados com o PI Notifications(OSIsoft) e Telegram.*

## Motivação

Possibilidade de envio de notificações para o Telegram via PI Notifications.


## Desenvolvimento

A versão do PI Notification que foi testado foi a versão 2012, que já se encontra desatualizada atualmente.

No ambiente testado, o PI Notifications estava configurado para envio de notificações somente por e-mail e webservice.

Para a possibilidade de enviar mensagens para Telegram foi criado um webservice para poder fazer a interface entre o PI Notifications e Telegram.

Durante os testes foram desenvolvidas e testadas duas soluções:

* > Envio de mensagem de forma direta pelo notifications
* > Envio de mensagem via Node-Red

### Webservice

Como dito, foi desenvolvido um webservice para fazer a interface entre PI Notifications e Telegram.

<img src="https://github.com/dedynobre/usando-pinotifications-com-telegram/blob/master/media/img-12.jpg"/></br>

O webservice tem três métodos:

+ **_HelloWorld_**: que serve somente de testes
+ **_SendData_**: usado para interface com outros softwares, que no nosso caso, será o Node-Red. Este método possui o método HTTP Post que será enviado para uma aplicação externa. Como o webservice foi desenvolvido para trabalhar com uma notificação no PI Notifications foram seguidos os parametros conforme definições abaixo:
	- **servidor**: endereço no servidor com sua respectiva porta(se houver)
	- **caminho**: endereço hoje será publicado a mensagem
	- **par1**: parâmetro 01 da mensagem, retornando o nome da notificação - "nome"
	- **par2**: parâmetro 02 da mensagem, retornando o status do atributo trigger - "status"
	- **par3**: parâmetro 03 da mensagem, retornando o id da notificação para ser usada como filtro - "id"
	<img src="https://github.com/dedynobre/usando-pinotifications-com-telegram/blob/master/media/img-13.jpg"/></br>
+ **_enviaMessagem_**: usado para envio direto entre de mensagem para Telegram sem necessidade de nenhum servidor adicional. Com três parametros:
	- **token_bot**: token do bot telegram
	- **chat_id**: chat id do usuário, lista ou grupo do telegram
	- **messagem**: a mensagem para ser enviada para os usuários
	<img src="https://github.com/dedynobre/usando-pinotifications-com-telegram/blob/master/media/img-14.jpg"/></br>

### Testes solução 01

Usando a solução 01 - **enviaMessagem** - podemos enviar mensagem mais rapidamente pois os parametros são simples.

> <img src="https://github.com/dedynobre/usando-pinotifications-com-telegram/blob/master/media/img-06.jpg"/></br>

> <img src="https://github.com/dedynobre/usando-pinotifications-com-telegram/blob/master/media/img-07.jpg"/></br>
	
> Desta forma basta entrar com os três parametros necessário que a mensagem será enviada ao usuário do Telegram.

> Os paramentros podem ser linkados com atributos do AF.

``` A desvantagem desta solução é que a mensagem fica sempre limitada. Para customizar a mensagem seria necessário usar string builder para deixar a mensagem personalizada dentro do atributo do AF. ```


### Testes solução 02

Usando a solução 02 - **sendData** - podemos enviar mensagem para uma aplicação terceira que irá receber os parametros da mensagem e formatar a mensagem conforme necessidade.

No nosso teste utilizamos o [Node-Red](https://nodered.org/) como aplicação para receber os parametros, formatar a mensagem e enviá-la para os usuários.

A escolha do uso do *Node-Red* se dá pela facilidade de implementação, documentação e por ser voltado para tecnologias de IoT. Desta forma estamos alinhados 
com as tendências da Industria 4.0.

O nosso Node-Red está na versão ```v0.19.3``` e rodando em ambiente Windows - ```Windows Server 2008 R2```.

O  telegram possui vários nodes mas utilizamos dois:
+ [node-red-contrib-chatbot](https://flows.nodered.org/node/node-red-contrib-chatbot):
	* Configurado bot com menus de navegação
+ [node-red-contrib-telegrambot](https://flows.nodered.org/node/node-red-contrib-telegrambot).
	* Configurado para envio de notificações 

Como o webservice envia uma requisição usando o método POST temos que criar no Node-Red um flow para receber estes dados:

> <img src="https://github.com/dedynobre/usando-pinotifications-com-telegram/blob/master/media/img-15.jpg"/></br>

> Com esse flow é possível receber os dados do Notification e tratar os mesmos com seu respectivos filtros, se necessário.

> <img src="https://github.com/dedynobre/usando-pinotifications-com-telegram/blob/master/media/img-01.jpg"/></br>

> <img src="https://github.com/dedynobre/usando-pinotifications-com-telegram/blob/master/media/img-05.jpg"/></br>

> <img src="https://github.com/dedynobre/usando-pinotifications-com-telegram/blob/master/media/img-08.jpg"/></br>





## Conclusão

## Help

Caso precisem te ajuda ou tenham alguma sugestão, deixe seu comentário [Aqui](https://github.com/dedynobre/usando-telegram-com-piwebapi/issues).