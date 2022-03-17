/* 
 * ToDo and Tracker
 *
 * For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Task
    /// </summary>
    [DataContract]
        public partial class Task :  IEquatable<Task>, IValidatableObject
    {
        /// <summary>
        /// Defines Priority
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PriorityEnum
        {
            /// <summary>
            /// Enum NotAnalysed for value: notAnalysed
            /// </summary>
            [EnumMember(Value = "notAnalysed")]
            NotAnalysed = 1,
            /// <summary>
            /// Enum High for value: high
            /// </summary>
            [EnumMember(Value = "high")]
            High = 2,
            /// <summary>
            /// Enum Medium for value: medium
            /// </summary>
            [EnumMember(Value = "medium")]
            Medium = 3,
            /// <summary>
            /// Enum Low for value: low
            /// </summary>
            [EnumMember(Value = "low")]
            Low = 4        }
        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public PriorityEnum? Priority { get; set; }
        /// <summary>
        /// Defines State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum
        {
            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 1,
            /// <summary>
            /// Enum Started for value: started
            /// </summary>
            [EnumMember(Value = "started")]
            Started = 2,
            /// <summary>
            /// Enum Blocked for value: blocked
            /// </summary>
            [EnumMember(Value = "blocked")]
            Blocked = 3,
            /// <summary>
            /// Enum Completed for value: completed
            /// </summary>
            [EnumMember(Value = "completed")]
            Completed = 4,
            /// <summary>
            /// Enum Abandoned for value: abandoned
            /// </summary>
            [EnumMember(Value = "abandoned")]
            Abandoned = 5        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name (required).</param>
        /// <param name="projectIds">projectIds.</param>
        /// <param name="priority">priority.</param>
        /// <param name="stepNum">stepNum.</param>
        /// <param name="expectedStartTime">expectedStartTime.</param>
        /// <param name="expectedFinishTime">expectedFinishTime.</param>
        /// <param name="expectedTimeDuration">[ISO_8601](https://en.wikipedia.org/wiki/ISO_8601#Durations).</param>
        /// <param name="state">state.</param>
        /// <param name="recurRule">recurRule.</param>
        /// <param name="events">events.</param>
        /// <param name="assignedUser">assignedUser.</param>
        public Task(long? id = default(long?), string name = default(string), List<long?> projectIds = default(List<long?>), PriorityEnum? priority = default(PriorityEnum?), int? stepNum = default(int?), DateTime? expectedStartTime = default(DateTime?), DateTime? expectedFinishTime = default(DateTime?), string expectedTimeDuration = default(string), StateEnum? state = default(StateEnum?), string recurRule = default(string), List<ModelEvent> events = default(List<ModelEvent>), long? assignedUser = default(long?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Task and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.Id = id;
            this.ProjectIds = projectIds;
            this.Priority = priority;
            this.StepNum = stepNum;
            this.ExpectedStartTime = expectedStartTime;
            this.ExpectedFinishTime = expectedFinishTime;
            this.ExpectedTimeDuration = expectedTimeDuration;
            this.State = state;
            this.RecurRule = recurRule;
            this.Events = events;
            this.AssignedUser = assignedUser;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ProjectIds
        /// </summary>
        [DataMember(Name="projectIds", EmitDefaultValue=false)]
        public List<long?> ProjectIds { get; set; }


        /// <summary>
        /// Gets or Sets StepNum
        /// </summary>
        [DataMember(Name="stepNum", EmitDefaultValue=false)]
        public int? StepNum { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedStartTime
        /// </summary>
        [DataMember(Name="expectedStartTime", EmitDefaultValue=false)]
        public DateTime? ExpectedStartTime { get; set; }

        /// <summary>
        /// Gets or Sets ExpectedFinishTime
        /// </summary>
        [DataMember(Name="expectedFinishTime", EmitDefaultValue=false)]
        public DateTime? ExpectedFinishTime { get; set; }

        /// <summary>
        /// [ISO_8601](https://en.wikipedia.org/wiki/ISO_8601#Durations)
        /// </summary>
        /// <value>[ISO_8601](https://en.wikipedia.org/wiki/ISO_8601#Durations)</value>
        [DataMember(Name="expectedTimeDuration", EmitDefaultValue=false)]
        public string ExpectedTimeDuration { get; set; }


        /// <summary>
        /// Gets or Sets RecurRule
        /// </summary>
        [DataMember(Name="recurRule", EmitDefaultValue=false)]
        public string RecurRule { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<ModelEvent> Events { get; set; }

        /// <summary>
        /// Gets or Sets AssignedUser
        /// </summary>
        [DataMember(Name="assignedUser", EmitDefaultValue=false)]
        public long? AssignedUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProjectIds: ").Append(ProjectIds).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  StepNum: ").Append(StepNum).Append("\n");
            sb.Append("  ExpectedStartTime: ").Append(ExpectedStartTime).Append("\n");
            sb.Append("  ExpectedFinishTime: ").Append(ExpectedFinishTime).Append("\n");
            sb.Append("  ExpectedTimeDuration: ").Append(ExpectedTimeDuration).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  RecurRule: ").Append(RecurRule).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  AssignedUser: ").Append(AssignedUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="input">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ProjectIds == input.ProjectIds ||
                    this.ProjectIds != null &&
                    input.ProjectIds != null &&
                    this.ProjectIds.SequenceEqual(input.ProjectIds)
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.StepNum == input.StepNum ||
                    (this.StepNum != null &&
                    this.StepNum.Equals(input.StepNum))
                ) && 
                (
                    this.ExpectedStartTime == input.ExpectedStartTime ||
                    (this.ExpectedStartTime != null &&
                    this.ExpectedStartTime.Equals(input.ExpectedStartTime))
                ) && 
                (
                    this.ExpectedFinishTime == input.ExpectedFinishTime ||
                    (this.ExpectedFinishTime != null &&
                    this.ExpectedFinishTime.Equals(input.ExpectedFinishTime))
                ) && 
                (
                    this.ExpectedTimeDuration == input.ExpectedTimeDuration ||
                    (this.ExpectedTimeDuration != null &&
                    this.ExpectedTimeDuration.Equals(input.ExpectedTimeDuration))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.RecurRule == input.RecurRule ||
                    (this.RecurRule != null &&
                    this.RecurRule.Equals(input.RecurRule))
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.AssignedUser == input.AssignedUser ||
                    (this.AssignedUser != null &&
                    this.AssignedUser.Equals(input.AssignedUser))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectIds != null)
                    hashCode = hashCode * 59 + this.ProjectIds.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.StepNum != null)
                    hashCode = hashCode * 59 + this.StepNum.GetHashCode();
                if (this.ExpectedStartTime != null)
                    hashCode = hashCode * 59 + this.ExpectedStartTime.GetHashCode();
                if (this.ExpectedFinishTime != null)
                    hashCode = hashCode * 59 + this.ExpectedFinishTime.GetHashCode();
                if (this.ExpectedTimeDuration != null)
                    hashCode = hashCode * 59 + this.ExpectedTimeDuration.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.RecurRule != null)
                    hashCode = hashCode * 59 + this.RecurRule.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.AssignedUser != null)
                    hashCode = hashCode * 59 + this.AssignedUser.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
