namespace MegafonSmsAPI
{
    public enum StatusCode
	{
		/// <summary>
		/// 
		/// </summary>
		Ok = 0,

		/// <summary>
		/// Обязательное поле отсутствует или поле содержит данные в неверном формате
		/// </summary>
		InvalidRequiredField = 20101,

		/// <summary>
		/// Сообщение с таким msg_id уже передано для отправки
		/// </summary>
		MessageDuplicate = 20102,
	}
}
