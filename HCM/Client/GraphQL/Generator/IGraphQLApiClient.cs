using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;
using HCM.Client.GraphQL.Client;
using System.Threading.Tasks;

public interface IGraphQLApiClient
{
	/// <param name="name">name of Client</param>
	/// <param name="names">names is list variant of name of Client</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Client")]
	GraphQLQuery<GqlClient> Client (string sessionToken, long? _id = null, long?[] _ids = null, Gql_ClientFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_ClientOrdering[] orderBy = null, Func<GqlClient, GqlClient> fields = null );
	

	/// <param name="name">name of Country</param>
	/// <param name="names">names is list variant of name of Country</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Country")]
	GraphQLQuery<GqlCountry> Country (string sessionToken, long? _id = null, long?[] _ids = null, Gql_CountryFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_CountryOrdering[] orderBy = null, Func<GqlCountry, GqlCountry> fields = null );
	

	/// <param name="dateOfBirth">dateOfBirth of Employee</param>
	/// <param name="dateOfBirths">dateOfBirths is list variant of dateOfBirth of Employee</param>
	/// <param name="email">email of Employee</param>
	/// <param name="emails">emails is list variant of email of Employee</param>
	/// <param name="gender">gender of Employee</param>
	/// <param name="genders">genders is list variant of gender of Employee</param>
	/// <param name="image">image of Employee</param>
	/// <param name="images">images is list variant of image of Employee</param>
	/// <param name="name">name of Employee</param>
	/// <param name="names">names is list variant of name of Employee</param>
	/// <param name="password">password of Employee</param>
	/// <param name="passwords">passwords is list variant of password of Employee</param>
	/// <param name="phone">phone of Employee</param>
	/// <param name="phones">phones is list variant of phone of Employee</param>
	/// <param name="user">user of Employee</param>
	/// <param name="users">users is list variant of user of Employee</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Employee")]
	GraphQLQuery<GqlEmployee> Employee (string sessionToken, long? _id = null, long?[] _ids = null, DateTime? dateOfBirth = null, DateTime?[] dateOfBirths = null, string email = null, string[] emails = null, Gql_EmployeeFilter filter = null, int? first = null, string gender = null, string[] genders = null, string image = null, string[] images = null, string name = null, string[] names = null, int? offset = null, Gql_EmployeeOrdering[] orderBy = null, string password = null, string[] passwords = null, string phone = null, string[] phones = null, string user = null, string[] users = null, Func<GqlEmployee, GqlEmployee> fields = null );
	

	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("EmployeeCount")]
	GraphQLQuery<int?> EmployeeCount (string sessionToken, Func<int?, int?> fields = null );
	

	/// <param name="date">date of Events</param>
	/// <param name="dates">dates is list variant of date of Events</param>
	/// <param name="description">description of Events</param>
	/// <param name="descriptions">descriptions is list variant of description of Events</param>
	/// <param name="score">score of Events</param>
	/// <param name="scores">scores is list variant of score of Events</param>
	/// <param name="subject">subject of Events</param>
	/// <param name="subjects">subjects is list variant of subject of Events</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Events")]
	GraphQLQuery<GqlEvents> Events (string sessionToken, long? _id = null, long?[] _ids = null, DateTime? date = null, DateTime?[] dates = null, string description = null, string[] descriptions = null, Gql_EventsFilter filter = null, int? first = null, int? offset = null, Gql_EventsOrdering[] orderBy = null, int? score = null, int?[] scores = null, string subject = null, string[] subjects = null, Func<GqlEvents, GqlEvents> fields = null );
	

	/// <param name="name">name of Experience</param>
	/// <param name="names">names is list variant of name of Experience</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Experience")]
	GraphQLQuery<GqlExperience> Experience (string sessionToken, long? _id = null, long?[] _ids = null, Gql_ExperienceFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_ExperienceOrdering[] orderBy = null, Func<GqlExperience, GqlExperience> fields = null );
	

	/// <param name="duration">duration of LearningItem</param>
	/// <param name="durations">durations is list variant of duration of LearningItem</param>
	/// <param name="name">name of LearningItem</param>
	/// <param name="names">names is list variant of name of LearningItem</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("LearningItem")]
	GraphQLQuery<GqlLearningItem> LearningItem (string sessionToken, long? _id = null, long?[] _ids = null, string duration = null, string[] durations = null, Gql_LearningItemFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_LearningItemOrdering[] orderBy = null, Func<GqlLearningItem, GqlLearningItem> fields = null );
	

	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("LearningItemsList")]
	GraphQLQuery<GqlLearningItem> LearningItemsList (string sessionToken, Func<GqlLearningItem, GqlLearningItem> fields = null );
	

	/// <param name="description">description of LearningPath</param>
	/// <param name="descriptions">descriptions is list variant of description of LearningPath</param>
	/// <param name="name">name of LearningPath</param>
	/// <param name="names">names is list variant of name of LearningPath</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("LearningPath")]
	GraphQLQuery<GqlLearningPath> LearningPath (string sessionToken, long? _id = null, long?[] _ids = null, string description = null, string[] descriptions = null, Gql_LearningPathFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_LearningPathOrdering[] orderBy = null, Func<GqlLearningPath, GqlLearningPath> fields = null );
	

	/// <param name="name">name of Project</param>
	/// <param name="names">names is list variant of name of Project</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Project")]
	GraphQLQuery<GqlProject> Project (string sessionToken, long? _id = null, long?[] _ids = null, Gql_ProjectFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_ProjectOrdering[] orderBy = null, Func<GqlProject, GqlProject> fields = null );
	

	/// <param name="name">name of Role</param>
	/// <param name="names">names is list variant of name of Role</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Role")]
	GraphQLQuery<GqlRole> Role (string sessionToken, long? _id = null, long?[] _ids = null, Gql_RoleFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_RoleOrdering[] orderBy = null, Func<GqlRole, GqlRole> fields = null );
	

	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("RoleCount")]
	GraphQLQuery<int?> RoleCount (string sessionToken, Func<int?, int?> fields = null );
	

	/// <param name="name">name of Scope</param>
	/// <param name="names">names is list variant of name of Scope</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Scope")]
	GraphQLQuery<GqlScope> Scope (string sessionToken, long? _id = null, long?[] _ids = null, Gql_ScopeFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_ScopeOrdering[] orderBy = null, Func<GqlScope, GqlScope> fields = null );
	

	/// <param name="name">name of Tag</param>
	/// <param name="names">names is list variant of name of Tag</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Tag")]
	GraphQLQuery<GqlTag> Tag (string sessionToken, long? _id = null, long?[] _ids = null, Gql_TagFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_TagOrdering[] orderBy = null, Func<GqlTag, GqlTag> fields = null );
	

	/// <param name="name">name of Team</param>
	/// <param name="names">names is list variant of name of Team</param>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("Team")]
	GraphQLQuery<GqlTeam> Team (string sessionToken, long? _id = null, long?[] _ids = null, Gql_TeamFilter filter = null, int? first = null, string name = null, string[] names = null, int? offset = null, Gql_TeamOrdering[] orderBy = null, Func<GqlTeam, GqlTeam> fields = null );
	

	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("TeamCount")]
	GraphQLQuery<int?> TeamCount (string sessionToken, Func<int?, int?> fields = null );
	

    
	/// <summary>Adds Employees to Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addClientEmployees")]
	GraphQLQuery<string> AddClientEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Employees to Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addCountryEmployees")]
	GraphQLQuery<string> AddCountryEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Experience to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeExperience")]
	GraphQLQuery<string> AddEmployeeExperience (string sessionToken, string[] experience, string name, Func<string, string> fields = null );
	

	/// <summary>Adds IsFrom to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeIsFrom")]
	GraphQLQuery<string> AddEmployeeIsFrom (string sessionToken, string[] isFrom, string name, Func<string, string> fields = null );
	

	/// <summary>Adds IsMemberOf to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeIsMemberOf")]
	GraphQLQuery<string> AddEmployeeIsMemberOf (string sessionToken, string[] isMemberOf, string name, Func<string, string> fields = null );
	

	/// <summary>Adds IsTo to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeIsTo")]
	GraphQLQuery<string> AddEmployeeIsTo (string sessionToken, string[] isTo, string name, Func<string, string> fields = null );
	

	/// <summary>Adds LivesIn to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeLivesIn")]
	GraphQLQuery<string> AddEmployeeLivesIn (string sessionToken, string[] livesIn, string name, Func<string, string> fields = null );
	

	/// <summary>Adds WorksAs to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeWorksAs")]
	GraphQLQuery<string> AddEmployeeWorksAs (string sessionToken, string name, string[] worksAs, Func<string, string> fields = null );
	

	/// <summary>Adds WorksFor to Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEmployeeWorksFor")]
	GraphQLQuery<string> AddEmployeeWorksFor (string sessionToken, string name, string[] worksFor, Func<string, string> fields = null );
	

	/// <summary>Adds Event_of to Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEventsEvent_of")]
	GraphQLQuery<string> AddEventsEvent_of (string sessionToken, string[] event_of, string subject, Func<string, string> fields = null );
	

	/// <summary>Adds Is_from to Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEventsIs_from")]
	GraphQLQuery<string> AddEventsIs_from (string sessionToken, string[] is_from, string subject, Func<string, string> fields = null );
	

	/// <summary>Adds Is_to to Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEventsIs_to")]
	GraphQLQuery<string> AddEventsIs_to (string sessionToken, string[] is_to, string subject, Func<string, string> fields = null );
	

	/// <summary>Adds Scopes to Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addEventsScopes")]
	GraphQLQuery<string> AddEventsScopes (string sessionToken, string[] scopes, string subject, Func<string, string> fields = null );
	

	/// <summary>Adds Employees to Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addExperienceEmployees")]
	GraphQLQuery<string> AddExperienceEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Content to LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addLearningItemContent")]
	GraphQLQuery<string> AddLearningItemContent (string sessionToken, string[] content, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Next to LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addLearningItemNext")]
	GraphQLQuery<string> AddLearningItemNext (string sessionToken, string name, string[] next, Func<string, string> fields = null );
	

	/// <summary>Adds Learnings to LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addLearningPathLearnings")]
	GraphQLQuery<string> AddLearningPathLearnings (string sessionToken, string[] learnings, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Prerequisite to LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addLearningPathPrerequisite")]
	GraphQLQuery<string> AddLearningPathPrerequisite (string sessionToken, string name, string[] prerequisite, Func<string, string> fields = null );
	

	/// <summary>Adds Tags to LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addLearningPathTags")]
	GraphQLQuery<string> AddLearningPathTags (string sessionToken, string name, string[] tags, Func<string, string> fields = null );
	

	/// <summary>Adds Events to Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addProjectEvents")]
	GraphQLQuery<string> AddProjectEvents (string sessionToken, string[] events, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Team to Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addProjectTeam")]
	GraphQLQuery<string> AddProjectTeam (string sessionToken, string name, string[] team, Func<string, string> fields = null );
	

	/// <summary>Adds Employees to Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addRoleEmployees")]
	GraphQLQuery<string> AddRoleEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Adds IsRequiredBy to Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addRoleIsRequiredBy")]
	GraphQLQuery<string> AddRoleIsRequiredBy (string sessionToken, string[] isRequiredBy, string name, Func<string, string> fields = null );
	

	/// <summary>Adds IsScopeOf_ to Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addScopeIsScopeOf_")]
	GraphQLQuery<string> AddScopeIsScopeOf_ (string sessionToken, string[] isScopeOf_, string name, Func<string, string> fields = null );
	

	/// <summary>Adds IsTagOf to Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTagIsTagOf")]
	GraphQLQuery<string> AddTagIsTagOf (string sessionToken, string[] isTagOf, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Exp_requeres to Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTeamExp_requeres")]
	GraphQLQuery<string> AddTeamExp_requeres (string sessionToken, string[] exp_requeres, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Members to Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTeamMembers")]
	GraphQLQuery<string> AddTeamMembers (string sessionToken, string[] members, string name, Func<string, string> fields = null );
	

	/// <summary>Adds Roles to Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTeamRoles")]
	GraphQLQuery<string> AddTeamRoles (string sessionToken, string name, string[] roles, Func<string, string> fields = null );
	

	/// <summary>Adds WorksOn to Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("addTeamWorksOn")]
	GraphQLQuery<string> AddTeamWorksOn (string sessionToken, string name, string[] worksOn, Func<string, string> fields = null );
	

	/// <summary>Creates a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createClient")]
	GraphQLQuery<string> CreateClient (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Creates a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createCountry")]
	GraphQLQuery<string> CreateCountry (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Creates a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createEmployee")]
	GraphQLQuery<string> CreateEmployee (string sessionToken, string name, DateTime? dateOfBirth = null, string email = null, string gender = null, string image = null, string password = null, string phone = null, string user = null, Func<string, string> fields = null );
	

	/// <summary>Creates a Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createEvents")]
	GraphQLQuery<string> CreateEvents (string sessionToken, int? score, string subject, DateTime? date = null, string description = null, Func<string, string> fields = null );
	

	/// <summary>Creates a Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createExperience")]
	GraphQLQuery<string> CreateExperience (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Creates a LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createLearningItem")]
	GraphQLQuery<string> CreateLearningItem (string sessionToken, string name, string duration = null, Func<string, string> fields = null );
	

	/// <summary>Creates a LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createLearningPath")]
	GraphQLQuery<string> CreateLearningPath (string sessionToken, string name, string description = null, Func<string, string> fields = null );
	

	/// <summary>Creates a Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createProject")]
	GraphQLQuery<string> CreateProject (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Creates a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createRole")]
	GraphQLQuery<string> CreateRole (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Creates a Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createScope")]
	GraphQLQuery<string> CreateScope (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Creates a Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createTag")]
	GraphQLQuery<string> CreateTag (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Creates a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("createTeam")]
	GraphQLQuery<string> CreateTeam (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteClient")]
	GraphQLQuery<string> DeleteClient (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Employees from Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteClientEmployees")]
	GraphQLQuery<string> DeleteClientEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteCountry")]
	GraphQLQuery<string> DeleteCountry (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Employees from Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteCountryEmployees")]
	GraphQLQuery<string> DeleteCountryEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployee")]
	GraphQLQuery<string> DeleteEmployee (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Experience from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeExperience")]
	GraphQLQuery<string> DeleteEmployeeExperience (string sessionToken, string[] experience, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes IsFrom from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeIsFrom")]
	GraphQLQuery<string> DeleteEmployeeIsFrom (string sessionToken, string[] isFrom, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes IsMemberOf from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeIsMemberOf")]
	GraphQLQuery<string> DeleteEmployeeIsMemberOf (string sessionToken, string[] isMemberOf, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes IsTo from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeIsTo")]
	GraphQLQuery<string> DeleteEmployeeIsTo (string sessionToken, string[] isTo, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes LivesIn from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeLivesIn")]
	GraphQLQuery<string> DeleteEmployeeLivesIn (string sessionToken, string[] livesIn, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes WorksAs from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeWorksAs")]
	GraphQLQuery<string> DeleteEmployeeWorksAs (string sessionToken, string name, string[] worksAs, Func<string, string> fields = null );
	

	/// <summary>Deletes WorksFor from Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEmployeeWorksFor")]
	GraphQLQuery<string> DeleteEmployeeWorksFor (string sessionToken, string name, string[] worksFor, Func<string, string> fields = null );
	

	/// <summary>Deletes a Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEvents")]
	GraphQLQuery<string> DeleteEvents (string sessionToken, string subject, Func<string, string> fields = null );
	

	/// <summary>Deletes Event_of from Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEventsEvent_of")]
	GraphQLQuery<string> DeleteEventsEvent_of (string sessionToken, string[] event_of, string subject, Func<string, string> fields = null );
	

	/// <summary>Deletes Is_from from Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEventsIs_from")]
	GraphQLQuery<string> DeleteEventsIs_from (string sessionToken, string[] is_from, string subject, Func<string, string> fields = null );
	

	/// <summary>Deletes Is_to from Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEventsIs_to")]
	GraphQLQuery<string> DeleteEventsIs_to (string sessionToken, string[] is_to, string subject, Func<string, string> fields = null );
	

	/// <summary>Deletes Scopes from Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteEventsScopes")]
	GraphQLQuery<string> DeleteEventsScopes (string sessionToken, string[] scopes, string subject, Func<string, string> fields = null );
	

	/// <summary>Deletes a Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteExperience")]
	GraphQLQuery<string> DeleteExperience (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Employees from Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteExperienceEmployees")]
	GraphQLQuery<string> DeleteExperienceEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes a LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningItem")]
	GraphQLQuery<string> DeleteLearningItem (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Content from LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningItemContent")]
	GraphQLQuery<string> DeleteLearningItemContent (string sessionToken, string[] content, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Next from LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningItemNext")]
	GraphQLQuery<string> DeleteLearningItemNext (string sessionToken, string name, string[] next, Func<string, string> fields = null );
	

	/// <summary>Deletes a LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningPath")]
	GraphQLQuery<string> DeleteLearningPath (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Learnings from LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningPathLearnings")]
	GraphQLQuery<string> DeleteLearningPathLearnings (string sessionToken, string[] learnings, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Prerequisite from LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningPathPrerequisite")]
	GraphQLQuery<string> DeleteLearningPathPrerequisite (string sessionToken, string name, string[] prerequisite, Func<string, string> fields = null );
	

	/// <summary>Deletes Tags from LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteLearningPathTags")]
	GraphQLQuery<string> DeleteLearningPathTags (string sessionToken, string name, string[] tags, Func<string, string> fields = null );
	

	/// <summary>Deletes a Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteProject")]
	GraphQLQuery<string> DeleteProject (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Events from Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteProjectEvents")]
	GraphQLQuery<string> DeleteProjectEvents (string sessionToken, string[] events, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Team from Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteProjectTeam")]
	GraphQLQuery<string> DeleteProjectTeam (string sessionToken, string name, string[] team, Func<string, string> fields = null );
	

	/// <summary>Deletes a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRole")]
	GraphQLQuery<string> DeleteRole (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Employees from Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRoleEmployees")]
	GraphQLQuery<string> DeleteRoleEmployees (string sessionToken, string[] employees, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes IsRequiredBy from Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteRoleIsRequiredBy")]
	GraphQLQuery<string> DeleteRoleIsRequiredBy (string sessionToken, string[] isRequiredBy, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes a Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteScope")]
	GraphQLQuery<string> DeleteScope (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes IsScopeOf_ from Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteScopeIsScopeOf_")]
	GraphQLQuery<string> DeleteScopeIsScopeOf_ (string sessionToken, string[] isScopeOf_, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes a Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTag")]
	GraphQLQuery<string> DeleteTag (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes IsTagOf from Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTagIsTagOf")]
	GraphQLQuery<string> DeleteTagIsTagOf (string sessionToken, string[] isTagOf, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeam")]
	GraphQLQuery<string> DeleteTeam (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Exp_requeres from Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeamExp_requeres")]
	GraphQLQuery<string> DeleteTeamExp_requeres (string sessionToken, string[] exp_requeres, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Members from Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeamMembers")]
	GraphQLQuery<string> DeleteTeamMembers (string sessionToken, string[] members, string name, Func<string, string> fields = null );
	

	/// <summary>Deletes Roles from Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeamRoles")]
	GraphQLQuery<string> DeleteTeamRoles (string sessionToken, string name, string[] roles, Func<string, string> fields = null );
	

	/// <summary>Deletes WorksOn from Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("deleteTeamWorksOn")]
	GraphQLQuery<string> DeleteTeamWorksOn (string sessionToken, string name, string[] worksOn, Func<string, string> fields = null );
	

	/// <summary>Merge a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeClient")]
	GraphQLQuery<string> MergeClient (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Merge a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeCountry")]
	GraphQLQuery<string> MergeCountry (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Merge a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeEmployee")]
	GraphQLQuery<string> MergeEmployee (string sessionToken, string name, DateTime? dateOfBirth = null, string email = null, string gender = null, string image = null, string password = null, string phone = null, string user = null, Func<string, string> fields = null );
	

	/// <summary>Merge a Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeEvents")]
	GraphQLQuery<string> MergeEvents (string sessionToken, int? score, string subject, DateTime? date = null, string description = null, Func<string, string> fields = null );
	

	/// <summary>Merge a Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeExperience")]
	GraphQLQuery<string> MergeExperience (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Merge a LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeLearningItem")]
	GraphQLQuery<string> MergeLearningItem (string sessionToken, string name, string duration = null, Func<string, string> fields = null );
	

	/// <summary>Merge a LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeLearningPath")]
	GraphQLQuery<string> MergeLearningPath (string sessionToken, string name, string description = null, Func<string, string> fields = null );
	

	/// <summary>Merge a Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeProject")]
	GraphQLQuery<string> MergeProject (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Merge a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeRole")]
	GraphQLQuery<string> MergeRole (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Merge a Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeScope")]
	GraphQLQuery<string> MergeScope (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Merge a Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeTag")]
	GraphQLQuery<string> MergeTag (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Merge a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("mergeTeam")]
	GraphQLQuery<string> MergeTeam (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a Client entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateClient")]
	GraphQLQuery<string> UpdateClient (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a Country entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateCountry")]
	GraphQLQuery<string> UpdateCountry (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a Employee entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateEmployee")]
	GraphQLQuery<string> UpdateEmployee (string sessionToken, string name, DateTime? dateOfBirth = null, string email = null, string gender = null, string image = null, string password = null, string phone = null, string user = null, Func<string, string> fields = null );
	

	/// <summary>Updates a Events entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateEvents")]
	GraphQLQuery<string> UpdateEvents (string sessionToken, int? score, string subject, DateTime? date = null, string description = null, Func<string, string> fields = null );
	

	/// <summary>Updates a Experience entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateExperience")]
	GraphQLQuery<string> UpdateExperience (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a LearningItem entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateLearningItem")]
	GraphQLQuery<string> UpdateLearningItem (string sessionToken, string name, string duration = null, Func<string, string> fields = null );
	

	/// <summary>Updates a LearningPath entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateLearningPath")]
	GraphQLQuery<string> UpdateLearningPath (string sessionToken, string name, string description = null, Func<string, string> fields = null );
	

	/// <summary>Updates a Project entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateProject")]
	GraphQLQuery<string> UpdateProject (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a Role entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateRole")]
	GraphQLQuery<string> UpdateRole (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a Scope entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateScope")]
	GraphQLQuery<string> UpdateScope (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a Tag entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateTag")]
	GraphQLQuery<string> UpdateTag (string sessionToken, string name, Func<string, string> fields = null );
	

	/// <summary>Updates a Team entity</summary>
	/// <param name="sessionToken">Token Used on production</param>
	[GraphQLField("updateTeam")]
	GraphQLQuery<string> UpdateTeam (string sessionToken, string name, Func<string, string> fields = null );
	

    
}
