using Microsoft.AspNetCore.Mvc;
using SLK.XClinic.Abstract;
using System.Threading.Tasks;

namespace SLK.XClinic.Base;

public interface IWorkFlowService
{
    //Task<Result> CheckState(string workflowId, WorkflowContext context, string state);

    //Task<Result> CheckState<T>(WorkflowContext context, T state);

    //Task<Result> CheckStep<T>(WorkflowContext context, string step);

    //Task<bool> CheckTask<T>(WorkflowContext context, string task);

    //Task<Result> TriggerStep<T>(WorkflowContext context, string step);

    //Task StepTriggered<T>(WorkflowContext context, string step);
}