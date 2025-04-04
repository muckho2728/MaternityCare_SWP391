﻿using System.ComponentModel.DataAnnotations;

namespace MaternityCare_Backend.Service.FetusHealthServices.DTOs
{
	public record FetusHealthForUpdateDto
	{
		[Range(0.00001, double.MaxValue, ErrorMessage = "Value must be a positive number.")]
		public double? HeadCircumference { get; init; }
		[Range(0.00001, double.MaxValue, ErrorMessage = "Value must be a positive number.")]
		public double? AmnioticFluidLevel { get; init; }
		[Range(0.00001, double.MaxValue, ErrorMessage = "Value must be a positive number.")]
		public double? CrownRumpLength { get; init; }
		[Range(0.00001, double.MaxValue, ErrorMessage = "Value must be a positive number.")]
		public double? BiparietalDiameter { get; init; }
		[Range(0.00001, double.MaxValue, ErrorMessage = "Value must be a positive number.")]
		public double? FemurLength { get; init; }
		[Range(0.00001, double.MaxValue, ErrorMessage = "Value must be a positive number.")]
		public double? EstimatedFetalWeight { get; init; }
		[Range(0.00001, double.MaxValue, ErrorMessage = "Value must be a positive number.")]
		public double? AbdominalCircumference { get; init; }
		[Range(0.00001, double.MaxValue, ErrorMessage = "Value must be a positive number.")]
		public double? GestationalSacDiameter { get; init; }
	}
}
