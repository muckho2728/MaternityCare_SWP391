﻿using MaternityCare_Backend.Service.EmailServices;
using MaternityCare_Backend.Service.EmailServices.DTOs;
using Quartz;

namespace MaternityCare_Backend.Service.Jobs
{
	public class EmailSendingJob : IJob
	{
		private readonly IEmailSender emailSender;

		public EmailSendingJob(IEmailSender emailSender)
		{
			this.emailSender = emailSender;
		}
		public Task Execute(IJobExecutionContext context)
		{
			var dataMap = context.MergedJobDataMap;
			string to = dataMap.GetString("to");
			string subject = dataMap.GetString("subject");
			string body = dataMap.GetString("body");

			var mail = new Mail(to, subject, body);
			emailSender.SendEmail(mail);
			return Task.CompletedTask;
		}
	}
}
