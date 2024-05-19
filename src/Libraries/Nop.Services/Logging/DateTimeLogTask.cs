using Nop.Core.Domain.Common;
using Nop.Services.ScheduleTasks;

namespace Nop.Services.Logging;

/// <summary>
/// Represents a task to clear [Log] table
/// </summary>
public partial class DateTimeLogTask : IScheduleTask
{
    #region Fields

    protected readonly CommonSettings _commonSettings;
    protected readonly ILogger _logger;

    #endregion

    #region Ctor

    public DateTimeLogTask(CommonSettings commonSettings,
        ILogger logger)
    {
        _commonSettings = commonSettings;
        _logger = logger;
    }

    #endregion

    #region Methods

    /// <summary>
    /// Executes a task
    /// </summary>
    public virtual async System.Threading.Tasks.Task ExecuteAsync()
    {
        var utcNow = DateTime.UtcNow;

        await _logger.DateTimeLogAsync(utcNow,null);
    }

    #endregion
}