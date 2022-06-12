using System.Runtime.Serialization;

namespace MegafonSmsAPI
{
    [DataContract]
	public class SendStatus
	{
		/// <summary>
		/// Цифровой идентификатор статуса
		/// </summary>
		[DataMember(Name = "code")]
        public int Code { get; set; }

		/// <summary>
		/// Описание ответа
		/// </summary>
		[DataMember(Name = "description")]
        public string Description { get; set; }

		/// <summary>
		/// Набор дополнительных параметров, для более полного понимания ответа
		/// </summary>
		[DataMember(Name = "payload")]
        public string Payload { get; set; }

		/// <summary>
		/// Значение статуса соответствующее идентификатору статуса
		/// </summary>
		public string Status => GetStatusCode(Code);

		private string GetStatusCode(int statusCode)
        {
            switch (statusCode)
            {
				case 0: 
					return "Запрос выполнен успешно";
				case 20101:
					return "Обязательное поле отсутствует или поле содержит данные в неверном формате";
				case 20102:
					return "Сообщение с таким msg_id уже передано для отправки";
				case 1:
					return "Message Length is invalid";
				case 2:
					return "Command Length is invalid";
				case 3:
					return "Invalid Command ID";
				case 4:
					return "Incorrect BIND Status for given command";
				case 5:
					return "ESME Already in Bound State";
				case 6:
					return "Invalid Priority Flag";
				case 7:
					return "Invalid Registered Delivery Flag";
				case 8:
					return "System Error";
				case 10:
					return "Invalid Source Address";
				case 11:
					return "Invalid Dest Addr";
				case 12:
					return "Message ID is invalid";
				case 13:
					return "Bind Failed";
				case 14:
					return "Invalid Password";
				case 15:
					return "Invalid System ID";
				case 17:
					return "Cancel SM Failed";
				case 19:
					return "Replace SM Failed";
				case 20:
					return "Message Queue Full. Превышено максимально допустимое время пребывания SMS в очереди.";
				case 21:
					return "Invalid Service Type";
				case 51:
					return "Invalid number of destinations";
				case 52:
					return "Invalid Distribution List name";
				case 64:
					return "Destination flag is invalid (submit_multi)";
				case 66:
					return "Invalid 'submit with replace' request (i.e. submit_sm with replace_if_present_flag set)";
				case 67:
					return "Invalid esm_class field data";
				case 68:
					return "Cannot Submit to Distribution List";
				case 69:
					return "submit_sm or submit_multi failed. Отправка сообщения прервана из-за внутренней ошибки(например, потеряно соединение с smsc до получения submit_sm_resp).";
				case 72:
					return "Invalid Source address TON";
				case 73:
					return "Invalid Source address NPI";
				case 80:
					return "Invalid Destination address TON";
				case 81:
					return "Invalid Destination address NPI";
				case 83:
					return "Invalid system_type field";
				case 84:
					return "Invalid replace_if_present flag";
				case 85:
					return "Invalid number of messages";
				case 88:
					return "Throttling error (ESME has exceeded allowed message limits). Превышены ограничения по лимиту pdu/s, заданному на платформе для данной компании. Либо обшая перегрузка одной из нод.";
				case 97:
					return "Invalid Scheduled Delivery Time";
				case 98:
					return "Invalid message validity period (Expiry time)";
				case 99:
					return "Predefined Message Invalid or Not Found";
				case 100:
					return "ESME Receiver Temporary App Error Code";
				case 101:
					return "ESME Receiver Permanent App Error Code";
				case 102:
					return "ESME Receiver Reject Message Error Code";
				case 103:
					return "query_sm request failed";
				case 192:
					return "Error in the optional part of the PDU Body.";
				case 193:
					return "Optional Parameter not allowed";
				case 194:
					return "Invalid Parameter Length.";
				case 195:
					return "Expected Optional Parameter missing";
				case 196:
					return "Invalid Optional Parameter Value";
				case 254:
					return "Delivery Failure (used for data_sm_resp)";
				case 255:
					return "Unknown Error";
				case 257:
					return "Ошибка приёма сообщения smsc (Трансмиттер для региона смс не подключен).";
				case 1281:
					return "Pdu запрещена по правилам роутинга (номера нет в списке ращрешённых или смс не разрешены для system_id, нет сессии для ussd).";
				case 1282:
					return "Заданный адрес у получателя находится в черных списках.";
				case 1284:
					return "В тексте сообщения найдены запрещенные слова или части слов.";
				case 1288:
					return "Отправка в данный регион недоступна для данной компании";
				default:
					return "Неизвестный код статуса";
            }
        }
	}
}
