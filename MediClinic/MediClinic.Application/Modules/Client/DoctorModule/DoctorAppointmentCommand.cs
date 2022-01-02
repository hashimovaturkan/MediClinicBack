using MediatR;
using MediClinic.Application.Core.Infrastructure;
using MediClinic.Domain.Models.DataContexts;
using MediClinic.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediClinic.Application.Modules.Client.DoctorModule
{
    public class DoctorAppointmentCommand : IRequest<CommandJsonResponse>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Date { get; set; }
        public int? DoctorId { get; set; }
        public class DoctorAppointmentCommandHandler : IRequestHandler<DoctorAppointmentCommand, CommandJsonResponse>
        {

            readonly MediClinicDbContext db;
            public DoctorAppointmentCommandHandler(MediClinicDbContext db)
            {
                this.db = db;
            }
            public async Task<CommandJsonResponse> Handle(DoctorAppointmentCommand request, CancellationToken cancellationToken)
            {
                var response = new CommandJsonResponse();

                try
                {
                    var appointment = new Appointment();
                    appointment.Message = request.Message;
                    appointment.Email = request.Email;
                    appointment.Name = request.Name;
                    appointment.IsAccepted = false;
                    appointment.Phone = request.Phone;
                    appointment.DoctorId = request.DoctorId;
                    appointment.Date = DateTime.Parse(request.Date);
                    await db.Appointments.AddAsync(appointment);
                }
                catch (Exception ex)
                {
                    var a = ex;
                    throw;
                }

                
                await db.SaveChangesAsync(cancellationToken);

                response.Error = false;
                response.Message = "Successfully, Your appointment was accepted!";
                return response;

            }
        }
    }
}
