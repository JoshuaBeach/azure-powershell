// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Peering Service
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSPeeringService
    {
        /// <summary>
        /// Initializes a new instance of the PSPeeringService class.
        /// </summary>
        public PSPeeringService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PSPeeringService class.
        /// </summary>
        /// <param name="location">The location of the resource.</param>
        /// <param name="peeringServiceLocation">The PeeringServiceLocation of
        /// the Customer.</param>
        /// <param name="peeringServiceProvider">The MAPS Provider
        /// Name.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="tags">The resource tags.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="id">The ID of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        public PSPeeringService(string location, string peeringServiceLocation = default(string), string peeringServiceProvider = default(string), string provisioningState = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string name = default(string), string id = default(string), string type = default(string))
        {
            PeeringServiceLocation = peeringServiceLocation;
            PeeringServiceProvider = peeringServiceProvider;
            ProvisioningState = provisioningState;
            Location = location;
            Tags = tags;
            Name = name;
            Id = id;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the PeeringServiceLocation of the Customer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringServiceLocation")]
        public string PeeringServiceLocation { get; set; }

        /// <summary>
        /// Gets or sets the MAPS Provider Name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peeringServiceProvider")]
        public string PeeringServiceProvider { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource. Possible values
        /// include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the location of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the ID of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}