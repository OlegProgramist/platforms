﻿namespace Task5.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Represent Carrier.
    /// </summary>
    [Serializable]
    public class Carrier
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Carrier" /> class.
        /// </summary>
        /// <param name="id">Id of Carrier.</param>
        /// <param name="name"> Name of Carrier.</param>
        /// <param name="phoneNumber">Phone number of Carrier.</param>
        /// <param name="email">Email of Carrier.</param>
        /// <param name="vehicleId">Vehicle Id of Carrier.</param>
        public Carrier(
            int id,
            string name,
            string phoneNumber,
            string email,
            int vehicleId)
        {
            this.CarrierId = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.VehicleId = vehicleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Carrier"/> class.
        /// </summary>
        public Carrier()
        {
            this.Vehicle = new Vehicle();
        }

        /// <summary>
        /// Gets or sets <see cref="Id"/> for <see cref="Carrier"/>.
        /// </summary>
        /// <value>Id for <see cref="Carrier"/>.</value>
        [Key]
        public int CarrierId { get; set; }

        /// <summary>
        /// Gets or sets <see cref="Name"/> for <see cref="Carrier"/>.
        /// </summary>
        /// <value><see cref="Name"/> for <see cref="Carrier"/>.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets <see cref="PhoneNumber"/> for <see cref="Carrier"/>.
        /// </summary>
        /// <value><see cref="PhoneNumber"/> for <see cref="Carrier"/>.</value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets <see cref="Email"/> for <see cref="Carrier"/>.
        /// </summary>
        /// <value><see cref="Email"/> for <see cref="Carrier"/>.</value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Id for <see cref="Vehicle"/>.
        /// </summary>
        /// <value>Id for <see cref="Vehicle"/>.</value>
        public int VehicleId { get; set; }

        /// <summary>
        /// Gets or sets <see cref="Vehicle"/> for <see cref="Carrier"/>.
        /// </summary>
        /// <value><see cref="Vehicle"/> for <see cref="Carrier"/>.</value>
        public virtual Vehicle Vehicle { get; set; }

        /// <summary>
        /// To String Method for Carrier.
        /// </summary>
        /// <returns>String with Carrier info.</returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.Name, this.PhoneNumber, this.Email);
        }
    }
}
