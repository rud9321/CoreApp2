using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Susa.Core.Entities.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Broadcasts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Rang = table.Column<int>(nullable: false),
                    Acceptance_Time = table.Column<int>(nullable: false),
                    Rejection_Time = table.Column<int>(nullable: false),
                    Surveyor_Expertise_Type_Id = table.Column<int>(nullable: false),
                    Number_of_Requested_Surveyor = table.Column<int>(nullable: false),
                    Classification_Type_Id = table.Column<int>(nullable: false),
                    Rattings = table.Column<string>(nullable: true),
                    Location_Id = table.Column<int>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Broadcasts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classification_Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classification_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Survey_Case_Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey_Case_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Survey_Case_Vehicle_Details",
                columns: table => new
                {
                    Survey_Case_Vehicle_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Survey_Case_ID = table.Column<long>(nullable: true),
                    Motor_Vehicle_Id = table.Column<long>(nullable: true),
                    Registration_No = table.Column<string>(nullable: true),
                    ChasisNo = table.Column<string>(nullable: true),
                    EngineNo = table.Column<string>(nullable: true),
                    Fitness_Ceertificate_Validate_Date = table.Column<DateTime>(nullable: true),
                    Permit_No = table.Column<string>(nullable: true),
                    Type_of_Permit = table.Column<string>(nullable: true),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    MgfYear = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    OdometerReading = table.Column<string>(nullable: true),
                    Hypo = table.Column<string>(nullable: true),
                    VARIANT = table.Column<string>(nullable: true),
                    FUELTYPE = table.Column<string>(nullable: true),
                    REGISTRATIONDATE = table.Column<string>(nullable: true),
                    RegisteredOwner = table.Column<string>(nullable: true),
                    Transfer_Date = table.Column<string>(nullable: true),
                    Class_Vehicle = table.Column<string>(nullable: true),
                    Pre_Accident_Condition = table.Column<string>(nullable: true),
                    Laden_Wt = table.Column<string>(nullable: true),
                    Unladen_Wt = table.Column<string>(nullable: true),
                    CNG_KIT_Status = table.Column<string>(nullable: true),
                    Permit_Area = table.Column<string>(nullable: true),
                    Road_Tax_ValidUpto = table.Column<string>(nullable: true),
                    seating_capacity = table.Column<string>(nullable: true),
                    VINSearchFound = table.Column<int>(nullable: true),
                    PermitValidUpto = table.Column<DateTime>(nullable: true),
                    CubicCapacity = table.Column<string>(nullable: true),
                    FitnessNo = table.Column<string>(nullable: true),
                    IsRCAvailable = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey_Case_Vehicle_Details", x => x.Survey_Case_Vehicle_Id);
                });

            migrationBuilder.CreateTable(
                name: "Survey_Cases",
                columns: table => new
                {
                    Survey_Case_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Survey_Case_No = table.Column<string>(nullable: true),
                    Survey_Case_Date = table.Column<DateTime>(nullable: true),
                    Survey_ClaimNO = table.Column<string>(nullable: true),
                    Survey_PolicyNO = table.Column<string>(nullable: true),
                    Company_Id = table.Column<long>(nullable: true),
                    WorkShopId = table.Column<int>(nullable: true),
                    Customer_Name = table.Column<string>(nullable: true),
                    Customer_Address = table.Column<string>(nullable: true),
                    Customer_Mobile = table.Column<string>(nullable: true),
                    Customer_LandLine = table.Column<string>(nullable: true),
                    Case_Type_Id = table.Column<long>(nullable: true),
                    Surveyor_ID = table.Column<long>(nullable: true),
                    Assigned_DateTime = table.Column<DateTime>(nullable: true),
                    Survey_Location = table.Column<string>(nullable: true),
                    Survey_GeoCodes = table.Column<string>(nullable: true),
                    Survey_Status_ID = table.Column<int>(nullable: true),
                    Status_Change_DateTime = table.Column<DateTime>(nullable: true),
                    DateofAllotmentofsurvey = table.Column<DateTime>(nullable: true),
                    DateofSurvey = table.Column<DateTime>(nullable: true),
                    PlaceofSurvey = table.Column<string>(nullable: true),
                    InsuredName = table.Column<string>(nullable: true),
                    InsuredAddress = table.Column<string>(nullable: true),
                    InsuredMobile = table.Column<string>(nullable: true),
                    EmailID = table.Column<string>(nullable: true),
                    CmpnyName = table.Column<string>(nullable: true),
                    SURVEY_CASE_SERIALNO = table.Column<long>(nullable: true),
                    Policy_Type = table.Column<string>(nullable: true),
                    Policy_Start_Date = table.Column<string>(nullable: true),
                    Policy_End_Date = table.Column<string>(nullable: true),
                    Policy_Value = table.Column<string>(nullable: true),
                    SLNO = table.Column<string>(nullable: true),
                    Intimation_Date = table.Column<string>(nullable: true),
                    Intimation_Time = table.Column<string>(nullable: true),
                    Intimation_PlaceG = table.Column<string>(nullable: true),
                    DelayinIntimation = table.Column<bool>(nullable: true),
                    IntimationDelayReason = table.Column<string>(nullable: true),
                    USERID = table.Column<int>(nullable: true),
                    InsuredContactNo = table.Column<string>(nullable: true),
                    InspectionOfficialName = table.Column<string>(nullable: true),
                    InspectionOfficialContactNo = table.Column<string>(nullable: true),
                    AreaID = table.Column<int>(nullable: true),
                    WorkShopNotes = table.Column<string>(nullable: true),
                    StateID = table.Column<int>(nullable: true),
                    CityID = table.Column<int>(nullable: true),
                    AssessmentCase = table.Column<bool>(nullable: true),
                    TemplateID = table.Column<int>(nullable: true),
                    IsEstimateSubmitted = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey_Cases", x => x.Survey_Case_ID);
                });

            migrationBuilder.CreateTable(
                name: "Survey_Trackings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Survey_Case_Id = table.Column<int>(nullable: false),
                    Surveyor_Id = table.Column<int>(nullable: false),
                    Job_Start_Time = table.Column<DateTime>(nullable: false),
                    Job_Start_Location_Id = table.Column<int>(nullable: false),
                    Vehicle_Type_Id = table.Column<int>(nullable: false),
                    Check_In_Time = table.Column<int>(nullable: false),
                    Check_Out_Time = table.Column<int>(nullable: false),
                    Check_Out_Location_Id = table.Column<int>(nullable: false),
                    Total_Distance = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey_Trackings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surveyor_Expertise_Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveyor_Expertise_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surveyors",
                columns: table => new
                {
                    Surveyor_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SurveyorCode = table.Column<string>(nullable: true),
                    Surveyor_Name = table.Column<string>(nullable: true),
                    Surveyor_EmailId = table.Column<string>(nullable: true),
                    Surveyor_MobileNo = table.Column<string>(nullable: true),
                    Surveyor_LandLine = table.Column<string>(nullable: true),
                    StateID = table.Column<int>(nullable: true),
                    CityID = table.Column<int>(nullable: true),
                    Surveyor_Address = table.Column<string>(nullable: true),
                    BillAddress = table.Column<string>(nullable: true),
                    Surveyor_License_No = table.Column<string>(nullable: true),
                    Surveyor_License_Expiry_Date = table.Column<string>(nullable: true),
                    SURVEYOR_COMPANY_NAME = table.Column<string>(nullable: true),
                    COMPANY_ID = table.Column<long>(nullable: true),
                    Surveyor_GSTIN = table.Column<string>(nullable: true),
                    Surveyor_PAN = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    IFSCCode = table.Column<string>(nullable: true),
                    BankAddress = table.Column<string>(nullable: true),
                    BankAccNo = table.Column<string>(nullable: true),
                    MICRCode = table.Column<string>(nullable: true),
                    CaseTypeAllowed = table.Column<int>(nullable: true),
                    CaseAllocation = table.Column<int>(nullable: true),
                    NoOfCases = table.Column<int>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true),
                    WatermarkYNG = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveyors", x => x.Surveyor_Id);
                });

            migrationBuilder.CreateTable(
                name: "User_Types",
                columns: table => new
                {
                    User_Type_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User_Type_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Types", x => x.User_Type_Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Company_ID = table.Column<int>(nullable: true),
                    User_Type_Id = table.Column<int>(nullable: true),
                    Surveyor_Id = table.Column<int>(nullable: true),
                    WorkshopId = table.Column<int>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true),
                    IsActive = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    CreadtedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle_Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkShops",
                columns: table => new
                {
                    WorkShopId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkShopName = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    GSTIN = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkShops", x => x.WorkShopId);
                });

            migrationBuilder.CreateTable(
                name: "Live_Surveyors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SurveyorRefId = table.Column<long>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Lat = table.Column<string>(nullable: true),
                    Lng = table.Column<string>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Live_Surveyors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Live_Surveyors_Surveyors_SurveyorRefId",
                        column: x => x.SurveyorRefId,
                        principalTable: "Surveyors",
                        principalColumn: "Surveyor_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Live_Surveyors_SurveyorRefId",
                table: "Live_Surveyors",
                column: "SurveyorRefId",
                unique: true,
                filter: "[SurveyorRefId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Broadcasts");

            migrationBuilder.DropTable(
                name: "Classification_Types");

            migrationBuilder.DropTable(
                name: "Live_Surveyors");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Survey_Case_Status");

            migrationBuilder.DropTable(
                name: "Survey_Case_Vehicle_Details");

            migrationBuilder.DropTable(
                name: "Survey_Cases");

            migrationBuilder.DropTable(
                name: "Survey_Trackings");

            migrationBuilder.DropTable(
                name: "Surveyor_Expertise_Types");

            migrationBuilder.DropTable(
                name: "User_Types");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vehicle_Types");

            migrationBuilder.DropTable(
                name: "WorkShops");

            migrationBuilder.DropTable(
                name: "Surveyors");
        }
    }
}
