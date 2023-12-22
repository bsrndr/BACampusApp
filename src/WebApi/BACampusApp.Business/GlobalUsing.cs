﻿global using Microsoft.EntityFrameworkCore;
global using AutoMapper;
global using BACampusApp.Business.Abstracts;
global using BACampusApp.Business.Constants;
global using BACampusApp.Business.Concretes;
global using BACampusApp.Core.Utilities.Results;
global using BACampusApp.DataAccess.Interfaces.Repositories;
global using BACampusApp.Dtos.Admin;
global using BACampusApp.Entities.DbSets;
global using BACampusApp.Core.Utilities.Helpers;
global using BACampusApp.Dtos.Account;
global using BACampusApp.Dtos.ActivityStateLog;
global using IResult = BACampusApp.Core.Utilities.Results.IResult;
global using BACampusApp.Dtos.Categorys;
global using Microsoft.AspNetCore.Http;
global using BACampusApp.Dtos.Classroom;
global using BACampusApp.Dtos.ClassroomStudent;
global using BACampusApp.Dtos.ClassroomTrainers;
global using BACampusApp.Dtos.Comment;
global using BACampusApp.Dtos.Educations;
global using BACampusApp.Dtos.EducationSubject;
global using System.Net.Mail;
global using System.Net;
global using Microsoft.Extensions.Options;
global using BACampusApp.Authentication.Options;
global using BACampusApp.Dtos.HomeWork;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.IdentityModel.Tokens;
global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Claims;
global using System.Text;
global using PhoneNumbers;
global using BACampusApp.Dtos.StudentHomework;
global using BACampusApp.Dtos.Students;
global using BACampusApp.Dtos.Subjects;
global using BACampusApp.Dtos.SupplementaryResources;
global using BACampusApp.Dtos.SupplementaryResourceTags;
global using BACampusApp.Dtos.Tag;
global using BACampusApp.Dtos.TechnicalUnits;
global using BACampusApp.Dtos.Trainers;
global using Microsoft.AspNetCore.Identity;
global using BACampusApp.Entities.Enums;
global using Microsoft.Extensions.Localization;
global using BACampusApp.Dtos.RoleLog;
global using BACampusApp.Business.TypedHttpClients;
global using BACampusApp.Dtos.Branch;
global using BACampusApp.Core.Enums;
global using BACampusApp.Dtos.TrainerLogTable;
global using BACampusApp.Dtos.StudentLogTable;
global using BACampusApp.Core.Enums;
global using BACampusApp.Dtos.UserPasswords;