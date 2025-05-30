﻿using System.ComponentModel.DataAnnotations;

namespace Tutorial5.DTOs;

public class PatientDto
{
    public int? IdPatient { get; set; }

    [MaxLength(100)]
    public string FirstName { get; set; }

    [MaxLength(100)]
    public string LastName { get; set; }

    public DateTime Birthdate { get; set; }

    public List<PrescriptionDto>? Prescriptions { get; set; }
}