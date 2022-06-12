using System.Runtime.Serialization;

namespace MegafonSmsAPI
{
    [DataContract]
	public class SendResult
	{
		/// <summary>
		/// Статус отправки, содержит подробную информацию о результате отправки сообщения
		/// </summary>
        [DataMember(Name = "status")]
        public SendStatus Status { get; set; }

		/// <summary>
		/// Id сообщения на стороне клиента
		/// </summary>
		[DataMember(Name = "msg_id")]
		public string MessageId { get; set; }
	}
}
