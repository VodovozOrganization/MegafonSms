using System.Runtime.Serialization;

namespace MegafonSmsAPI
{
    [DataContract]
    public class SmsMessage
    {
		/// <summary>
		/// Номер телефона, в формате 71234567890
		/// </summary>
		[DataMember(Name = "to")]
		public ulong Phone { get; set; }

		/// <summary>
		/// Подпись отправителя – это подпись адресата, которую абоненты видят на своем телефоне при получении SMS сообщения.
		/// Возможные спецсимволы: <![CDATA['!"#$%()*+,-./:;<=>?@[\]^_`{|}~]]>
		/// Размер подписи ограничен 11 (одиннадцатью) символами.
		/// </summary>
		[DataMember(Name = "from")]
		public string Sender { get; set; }

		/// <summary>
		/// Id сообщения на стороне клиента (A-Za-z0-9_:-, макс. 16 символов.)
		/// </summary>
		[DataMember(Name = "msg_id")]
		public string MessageId { get; set; }

		/// <summary>
		/// Текст сообщения, максимум 1000 символов.
		/// </summary>
		[DataMember(Name = "message")]
		public string Text { get; set; }

		/// <summary>
		/// URL для отправки уведомлений о статусе сообщения. 
		/// Не обязательный параметр.
		/// </summary>
		[DataMember(Name = "callback_url")]
        public string CallbackUrl { get; set; }
	}
}
